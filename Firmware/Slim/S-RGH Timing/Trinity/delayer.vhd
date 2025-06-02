library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- delayer

entity delayer is
	Port (
		to_slow : in STD_LOGIC;
		CLK : in STD_LOGIC;
		de_slow : out STD_LOGIC
	);
end delayer;

architecture arch of delayer is

constant del : integer := 500;
signal cnt : integer range 0 to del := 0;

begin

process (to_slow, CLK) is
begin
	if (to_slow = '0') then
		de_slow <= '0';
		cnt <= 0;
	else
		if (rising_edge(CLK)) then
			if (cnt < del) then
				cnt <= cnt + 1;
				de_slow <= '0';
			else
				de_slow <= '1';
			end if;
		end if;
	end if;
end process;

end arch;