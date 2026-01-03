library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;

--1:3 mux module
entity mux3 is
	Port (
		CES : 	out STD_LOGIC;
		CED : 	out STD_LOGIC;
		CET : 	out STD_LOGIC;
		CE_IN : 	in STD_LOGIC;
		S1 : 	in STD_LOGIC;
		S2 : 	in STD_LOGIC
	);
end mux3;

architecture rtl of mux3 is
signal SELV : std_logic_vector(1 downto 0);

begin
process (CE_IN, S1, S2)
	begin
		SELV <= S2 & S1;
		case (SELV) is
			when "01" => --S2=0, S1=1
				CES <= CE_IN;
				CED <= '1';
				CET <= '1';
			when "10" => --S2=1, S1=0
				CES <= '1';
				CED <= CE_IN;
				CET <= '1';
			when others => --S2=1, S1=1 (but also technically accounts for S2=0, S1=0)
				CES <= '1';
				CED <= '1';
				CET <= CE_IN;
		end case;
	end process;
end rtl;