-- Advanced S-RGH Code for X360ACE/DGX
-- 15432, GliGli, Octal450, ArminAustin200

library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- main module

entity post_proc is
	Port (
		POST : in STD_LOGIC;
		CLK : in STD_LOGIC;
		to_slow : out STD_LOGIC := '0';
		DBG : out STD_LOGIC := '0';
		RST0 : inout STD_LOGIC := 'Z';
		RST1 : inout STD_LOGIC := 'Z'
	);
end post_proc;

architecture arch of post_proc is

constant R_LEN : integer := 2;
constant R_END : integer := 54251;
constant T_END : integer := 65535;

constant post_rgh : integer := 11;
constant post_s_max : integer := 15;
signal post_r_cnt : integer range 0 to post_s_max := 0; --Creating a constant to count all rising edges of POST
signal post_f_cnt : integer range 0 to post_s_max := 0; --Creating a constant to count all falling edges of POST
signal r_cnt : integer range 0 to T_END := 0; -- Creating a constant to count all rising edges of CLK
signal f_cnt : integer range 0 to T_END := 0; -- Creating a constant to count all falling edges of CLK

begin

-- post counter
process (POST) is
begin
	-- Counting POST on rising edges
	if (rising_edge(POST)) then
		if (RST0 = '0') then
			post_r_cnt <= 0;
		else
			if (post_r_cnt < post_s_max) then
				post_r_cnt <= post_r_cnt + 1;
			end if;
		end if;
	end if;
	
	-- Counting POST on falling edges
	if (falling_edge(POST)) then
		if (RST0 = '0') then
			post_f_cnt <= 0;
		else
			if (post_f_cnt < post_s_max) then
				post_f_cnt <= post_f_cnt + 1;
			end if;
		end if;
	end if;
	
	DBG <= POST;
end process;

-- timing counter + reset
process (CLK) is
begin
	--Counting on rising edges of CLK
	if (rising_edge(CLK)) then -- 300 MHz
		if (post_r_cnt + post_f_cnt = post_rgh or (post_r_cnt + post_f_cnt = post_rgh - 1 and POST = '1')) then
			if (r_cnt + f_cnt /= T_END) then
				r_cnt <= r_cnt + 1;
			end if;
		else
			r_cnt <= 0;
		end if;
	end if;
	
	--Counting on falling edges of CLK
	if (falling_edge(CLK)) then -- 300 MHz
		if (post_r_cnt + post_f_cnt = post_rgh or (post_r_cnt + post_f_cnt = post_rgh - 1 and POST = '1')) then
			if (r_cnt + f_cnt /= T_END) then
				f_cnt <= f_cnt + 1;
			end if;
		else
			f_cnt <= 0;
		end if;
	end if;
		
		if (r_cnt + f_cnt >= R_END - R_LEN and r_cnt + f_cnt < R_END) then
			RST0 <= '0';
			RST1 <= '0';
		else
			if (r_cnt + f_cnt = R_END) then
				RST0 <= '1';
				RST1 <= '1';
			else
				RST0 <= 'Z';
				RST1 <= 'Z';
			end if;
		end if;
end process;

-- slowdown
process (post_r_cnt, post_f_cnt) is
begin
	if (post_r_cnt + post_f_cnt = post_rgh - 1) then
		to_slow <= '1';
	else
		to_slow <= '0';
	end if;
end process;

end arch;