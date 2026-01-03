library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;

--1:2 mux module
entity mux2 is
	Port (
		CES : 	out STD_LOGIC;
		CED : 	out STD_LOGIC;
		CE_IN : 	in STD_LOGIC;
		SEL : 	in STD_LOGIC
	);
end mux2;

architecture rtl of mux2 is
begin
	process (CE_IN, SEL)
	begin
		if SEL = '0' then
			CES <= CE_IN;
			CED <= '1';
		else
			CES <= '1';
			CED <= CE_IN;
		end if;
	end process;
end rtl;