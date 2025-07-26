-- Project Mufas RGH Code for Matrix/Coolrunner
-- 15432, Octal450, ArminAustin200

library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;
use ieee.STD_LOGIC_UNSIGNED.all;

-- main module

entity post_proc is
	Port (
		POST : in STD_LOGIC;
		CLK : in STD_LOGIC;
		CLK_D : in STD_LOGIC;
		SLOW : out STD_LOGIC := '0';
		DBG : out STD_LOGIC := '0';
		RST0 : inout STD_LOGIC := 'Z';
		RST1 : inout STD_LOGIC := 'Z'
	);
end post_proc;

architecture arch of post_proc is

constant R_LEN : integer := 1;
constant R_END : integer := 34721; -- Trinity 192MHz: 34721 and Corona/Waitsburg/Stingray 192MHz: 32710, Untested: Trinity 200MHz: 36167 and Corona/Waitsburg/Stingray 200MHz: 34073
constant T_END : integer := 40000;
constant S_DEL : integer := 490; -- Trinity: 490, Corona/Waitsburg/Stingray: 460

constant post_rgh : integer := 11;
constant post_s_max : integer := 15;
signal post_r_cnt : integer range 0 to post_s_max := 0; --Creating a constant to count all rising edges of POST
signal post_f_cnt : integer range 0 to post_s_max := 0; --Creating a constant to count all falling edges of POST

signal cnt_r : integer range 0 to T_END := 0; --Creating a constant to count all rising edges of CLK
signal cnt_f : integer range 0 to T_END := 0; --Creating a constant to count all falling edges of CLK

signal stop : STD_LOGIC := '0';
signal del_cnt : integer range 0 to S_DEL := 0;
signal to_slow : STD_LOGIC := '0';

begin

-- post limit
process (post_r_cnt, post_f_cnt) is
begin
	stop <= to_unsigned(post_r_cnt + post_f_cnt,4)(3) and to_unsigned(post_r_cnt + post_f_cnt,4)(2);
end process;

-- post counter
process (POST) is
begin
	--Counting POST on rising edges
	if (rising_edge(POST)) then
		if (RST0 = '1') then
			if (stop = '0') then
				post_r_cnt <= post_r_cnt + 1;
			end if;
		else
			post_r_cnt <= 0;
		end if;
	end if;
	
	--Counting POST on falling edges
	if (falling_edge(POST)) then
		if (RST0 = '1') then
			if (stop = '0') then
				post_f_cnt <= post_f_cnt + 1;
			end if;
		else
			post_f_cnt <= 0;
		end if;
	end if;
	
	DBG <= POST;
end process;

-- timing counter + reset
process (CLK) is
begin
	--Counting CLK on rising edges
	if (rising_edge(CLK)) then
		if (post_r_cnt + post_f_cnt = post_rgh) then --Might have to be changed to ">=" instead of "="
			if (cnt_r < T_END) then
				cnt_r <= cnt_r + 1;
			end if;
		else 
			cnt_r <= 0;
		end if;
	end if;
		
	--Counting CLK on falling edges
	if (falling_edge(CLK)) then
		if (post_r_cnt + post_f_cnt = post_RGH) then --Might have to be changed to ">=" instead of "="
			if (cnt_f < T_END) then
				cnt_f <= cnt_f + 1;
			end if;
		else
			cnt_f <= 0;
		end if;
	end if;
			
	if (cnt_r + cnt_f >= R_END - R_LEN and cnt_r + cnt_f < R_END) then
		RST0 <= '0';
		RST1 <= '0';
	else
		RST0 <= 'Z';
		RST1 <= 'Z';
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

-- delayer
process (to_slow, CLK_D) is
begin
	if (to_slow = '0') then
		SLOW <= '0';
		del_cnt <= 0;
	else
		if (rising_edge(CLK_D)) then
			if (del_cnt < S_DEL) then
				del_cnt <= del_cnt + 1;
				SLOW <= '0';
			else
				SLOW <= '1';
			end if;
		end if;
	end if;
end process;

end arch;
