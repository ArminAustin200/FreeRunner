-- EXT_CLK Code for Matrix/Coolrunner, Phat 96 MHz Version
-- 15432, GliGli, Octal450, ArminAustin200

library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;

-- main module

entity post_proc is
	Port (
		callback : in STD_LOGIC;
		POST : in STD_LOGIC;
		CLK : in STD_LOGIC;
		to_slow : out STD_LOGIC := '0';
		DBG : out STD_LOGIC := '0';
		RST : inout STD_LOGIC := 'Z'
	);
end post_proc;

architecture arch of post_proc is

constant R_LEN : integer := 1;
constant R_END : integer := 59001; -- Xenon: 59001, Zephyr: 59004
constant T_BUF : integer := 25000;
constant T_END : integer := R_END + T_BUF;

constant post_rgh : integer := 24;
constant post_s_max : integer := 31;
signal post_r_cnt : integer range 0 to post_s_max := 0; --Creating a constant to count all rising edges of POST
signal post_f_cnt : integer range 0 to post_s_max := 0; --Creating a constant to count all falling edges of POST

signal cnt_r : integer range 0 to T_END := 0; --Creating a constant to count all rising edges of CLK
signal cnt_f : integer range 0 to T_END := 0; --Creating a constant to count all falling edges of CLK

signal timeout_r : STD_LOGIC := '0'; --Creating a timeout for rising edges of CLK
signal timeout_f : STD_LOGIC := '0'; --Creating a timeout for falling edges of CLK

begin

-- post counter
process (POST, post_r_cnt, post_f_cnt) is
begin
	--Counting POST on rising edges
	if (rising_edge(POST)) then
		if (RST = '0') then
			post_r_cnt <= 0;
		else
			if (post_r_cnt < post_s_max) then
				post_r_cnt <= post_r_cnt + 1;
			end if;
		end if;
	end if;
	
	--Counting POST on falling edges
	if (falling_edge(POST)) then 
		if (RST = '0') then
			post_f_cnt <= 0;
		else
			if (post_f_cnt < post_s_max) then
				post_f_cnt <= post_f_cnt + 1;
			end if;
		end if;
	end if;
	
	if (post_r_cnt + post_f_cnt < post_s_max) then
		DBG <= POST;
	else
		DBG <= '0';
	end if;
end process;

-- timing counter + reset
process (CLK) is
begin
	if (rising_edge(CLK)) then --Counting the rising edges of CLK (96MHz)
		if (post_r_cnt + post_f_cnt >= post_rgh) then
			if (cnt_r < T_END) then
				cnt_r <= cnt_r + 1;
				timeout_r <= '0';
			else
				timeout_r <= '1';
			end if;
		else
			cnt_r <= 0;
			timeout_r <= '0';
		end if;
	end if;
	
	if (falling_edge(CLK)) then --Counting the falling edges of CLK (96MHz)
		if (post_r_cnt + post_f_cnt >= post_rgh) then
			if (cnt_f < T_END) then
				cnt_f <= cnt_f + 1;
				timeout_f <= '0';
			else
				timeout_f <= '1';
			end if;
		else
			cnt_f <= 0;
			timeout_f <= '0';
		end if;
	end if;
		
	if (cnt_r + cnt_f >= R_END - R_LEN and cnt_r + cnt_f < R_END and callback = '1') then
		RST <= '0';
	else
		if (cnt_r + cnt_f = R_END) then
			RST <= '1';
		else
			RST <= 'Z';
		end if;
	end if;
end process;

-- slowdown
process (post_r_cnt, post_f_cnt, timeout_r, timeout_f) is
begin
	if (post_r_cnt + post_f_cnt >= post_rgh - 1 and timeout_r = '0' and timeout_f = '0') then
		to_slow <= '1';
	else
		to_slow <= '0';
	end if;
end process;

end arch;