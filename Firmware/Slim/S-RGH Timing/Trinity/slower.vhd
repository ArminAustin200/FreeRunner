library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- Phat/Trinity slowdown

entity slower is
	generic (
		SCL_BITS :      STD_LOGIC_VECTOR(0 to 255) := b"1100100100100100100100100100001111100001001001001001001001001000011111000010010010010010010010010000111110000100100100100100100100100001111100001001001001001001001001000011111000010010010010010010010010000111110000100100100100100100100100001111100001111111";
		                                             -- S >< E0                   ><   ACK   >< CD                   ><   ACK   >< 04                   ><   ACK   >< 4E                   ><   ACK   >< 08                   ><   ACK   >< 80                   ><   ACK   >< 03                   ><   ACK   >< P
		SDA_SLOW_BITS : STD_LOGIC_VECTOR(0 to 255) := b"1001111111110000000000000001111111111111111100000011111100011111111111111000000000000000111000000111111111110001110000001111111110001111111111100000000000011100000000011111111111111000000000000000000000111111111110000000000000000001111111111111111100101111";
		                                             -- S >< E0                   ><   ACK   >< CD                   ><   ACK   >< 04                   ><   ACK   >< 4E                   ><   ACK   >< 80                   ><   ACK   >< 0C                   ><   ACK   >< 02                   ><   ACK   >< P
		SDA_FAST_BITS : STD_LOGIC_VECTOR(0 to 255) := b"1001111111110000000000000001111111111111111100000011111100011111111111111000000000000000111000000111111111110001110000001111111110001111111111111100000000000000000000011111111111000000000000111111000000111111111110000000000000000001110001111111111100101111"
	);
	Port (
		in_slow : in STD_LOGIC;
		CLK : in STD_LOGIC;
		SCL : out STD_LOGIC := '1';
		SDA : out STD_LOGIC := '1'
	);
end slower;

architecture arch of slower is

signal p_slow : STD_LOGIC := '0';
signal cnt : integer range 0 to 255 := 255;

begin

process(CLK, cnt, p_slow) is
begin
	if (rising_edge(CLK)) then
		if (cnt /= 255) then
			cnt <= cnt + 1;
		else
			if (p_slow /= in_slow) then
				p_slow <= in_slow;
				cnt <= 0;
			end if;
		end if;
	end if;
	
	if ((p_slow = '1' and SDA_SLOW_BITS(cnt) = '1') or (p_slow = '0' and SDA_FAST_BITS(cnt) = '1')) then
		SDA <= 'Z';
	else
		SDA <= '0';
	end if;
		
	if (SCL_BITS(cnt) = '1') then
		SCL <= 'Z';
	else
		SCL <= '0';
	end if;
end process;

end arch;