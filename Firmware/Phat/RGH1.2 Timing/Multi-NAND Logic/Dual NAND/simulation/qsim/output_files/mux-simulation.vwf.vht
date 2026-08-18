-- Copyright (C) 2017  Intel Corporation. All rights reserved.
-- Your use of Intel Corporation's design tools, logic functions 
-- and other software and tools, and its AMPP partner logic 
-- functions, and any output files from any of the foregoing 
-- (including device programming or simulation files), and any 
-- associated documentation or information are expressly subject 
-- to the terms and conditions of the Intel Program License 
-- Subscription Agreement, the Intel Quartus Prime License Agreement,
-- the Intel MegaCore Function License Agreement, or other 
-- applicable license agreement, including, without limitation, 
-- that your use is for the sole purpose of programming logic 
-- devices manufactured by Intel and sold by Intel or its 
-- authorized distributors.  Please refer to the applicable 
-- agreement for further details.

-- *****************************************************************************
-- This file contains a Vhdl test bench with test vectors .The test vectors     
-- are exported from a vector file in the Quartus Waveform Editor and apply to  
-- the top level entity of the current Quartus project .The user can use this   
-- testbench to simulate his design using a third-party simulation tool .       
-- *****************************************************************************
-- Generated on "08/16/2026 21:59:17"
                                                             
-- Vhdl Test Bench(with test vectors) for design  :          dualnand
-- 
-- Simulation tool : 3rd Party
-- 

LIBRARY ieee;                                               
USE ieee.std_logic_1164.all;                                

ENTITY dualnand_vhd_vec_tst IS
END dualnand_vhd_vec_tst;
ARCHITECTURE dualnand_arch OF dualnand_vhd_vec_tst IS
-- constants                                                 
-- signals                                                   
SIGNAL BUT : STD_LOGIC;
SIGNAL CE_IN : STD_LOGIC;
SIGNAL CED : STD_LOGIC;
SIGNAL CES : STD_LOGIC;
SIGNAL CLK : STD_LOGIC;
SIGNAL DBG : STD_LOGIC;
SIGNAL RST : STD_LOGIC;
SIGNAL SMC : STD_LOGIC;
COMPONENT dualnand
	PORT (
	BUT : IN STD_LOGIC;
	CE_IN : IN STD_LOGIC;
	CED : BUFFER STD_LOGIC;
	CES : BUFFER STD_LOGIC;
	CLK : IN STD_LOGIC;
	DBG : BUFFER STD_LOGIC;
	RST : IN STD_LOGIC;
	SMC : BUFFER STD_LOGIC
	);
END COMPONENT;
BEGIN
	i1 : dualnand
	PORT MAP (
-- list connections between master ports and signals
	BUT => BUT,
	CE_IN => CE_IN,
	CED => CED,
	CES => CES,
	CLK => CLK,
	DBG => DBG,
	RST => RST,
	SMC => SMC
	);

-- BUT
t_prcs_BUT: PROCESS
BEGIN
	BUT <= '1';
	WAIT FOR 280000 ps;
	BUT <= '0';
	WAIT FOR 290000 ps;
	BUT <= '1';
WAIT;
END PROCESS t_prcs_BUT;

-- CE_IN
t_prcs_CE_IN: PROCESS
BEGIN
	CE_IN <= '1';
	WAIT FOR 6924 ps;
	CE_IN <= '0';
	WAIT FOR 8200 ps;
	CE_IN <= '1';
	WAIT FOR 4876 ps;
	CE_IN <= '0';
	WAIT FOR 1475 ps;
	CE_IN <= '1';
	WAIT FOR 1700 ps;
	CE_IN <= '0';
	WAIT FOR 3300 ps;
	CE_IN <= '1';
	WAIT FOR 1700 ps;
	CE_IN <= '0';
	WAIT FOR 1825 ps;
	CE_IN <= '1';
	WAIT FOR 3411 ps;
	CE_IN <= '0';
	WAIT FOR 6000 ps;
	CE_IN <= '1';
	WAIT FOR 4000 ps;
	CE_IN <= '0';
	WAIT FOR 6000 ps;
	CE_IN <= '1';
	WAIT FOR 7293 ps;
	CE_IN <= '0';
	WAIT FOR 11000 ps;
	CE_IN <= '1';
	WAIT FOR 2735 ps;
	CE_IN <= '0';
	WAIT FOR 2900 ps;
	CE_IN <= '1';
	WAIT FOR 2100 ps;
	CE_IN <= '0';
	WAIT FOR 2900 ps;
	CE_IN <= '1';
	WAIT FOR 2303 ps;
	CE_IN <= '0';
	WAIT FOR 1900 ps;
	CE_IN <= '1';
	WAIT FOR 1433 ps;
	CE_IN <= '0';
	WAIT FOR 1900 ps;
	CE_IN <= '1';
	WAIT FOR 1433 ps;
	CE_IN <= '0';
	WAIT FOR 1900 ps;
	CE_IN <= '1';
	WAIT FOR 5109 ps;
	CE_IN <= '0';
	WAIT FOR 4900 ps;
	CE_IN <= '1';
	WAIT FOR 5100 ps;
	CE_IN <= '0';
	WAIT FOR 4900 ps;
	CE_IN <= '1';
	WAIT FOR 783 ps;
	CE_IN <= '0';
	WAIT FOR 700 ps;
	CE_IN <= '1';
	WAIT FOR 3100 ps;
	CE_IN <= '0';
	WAIT FOR 6900 ps;
	CE_IN <= '1';
	WAIT FOR 3100 ps;
	CE_IN <= '0';
	WAIT FOR 8702 ps;
	CE_IN <= '1';
	WAIT FOR 2400 ps;
	CE_IN <= '0';
	WAIT FOR 2600 ps;
	CE_IN <= '1';
	WAIT FOR 2400 ps;
	CE_IN <= '0';
	WAIT FOR 98 ps;
	CE_IN <= '1';
	WAIT FOR 409 ps;
	CE_IN <= '0';
	WAIT FOR 3300 ps;
	CE_IN <= '1';
	WAIT FOR 1700 ps;
	CE_IN <= '0';
	WAIT FOR 3300 ps;
	CE_IN <= '1';
	WAIT FOR 2770 ps;
	CE_IN <= '0';
	WAIT FOR 4700 ps;
	CE_IN <= '1';
	WAIT FOR 5300 ps;
	CE_IN <= '0';
	WAIT FOR 4700 ps;
	CE_IN <= '1';
	WAIT FOR 3821 ps;
	CE_IN <= '0';
	WAIT FOR 8976 ps;
	CE_IN <= '1';
	WAIT FOR 8800 ps;
	CE_IN <= '0';
	WAIT FOR 2224 ps;
	CE_IN <= '1';
	WAIT FOR 1177 ps;
	CE_IN <= '0';
	WAIT FOR 4800 ps;
	CE_IN <= '1';
	WAIT FOR 4023 ps;
	CE_IN <= '0';
	WAIT FOR 2505 ps;
	CE_IN <= '1';
	WAIT FOR 6400 ps;
	CE_IN <= '0';
	WAIT FOR 15073 ps;
	CE_IN <= '1';
	WAIT FOR 9600 ps;
	CE_IN <= '0';
	WAIT FOR 8132 ps;
	CE_IN <= '1';
	WAIT FOR 4500 ps;
	CE_IN <= '0';
	WAIT FOR 6480 ps;
	CE_IN <= '1';
	WAIT FOR 3532 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 3134 ps;
		CE_IN <= '1';
		WAIT FOR 3532 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 2245 ps;
	CE_IN <= '1';
	WAIT FOR 1033 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 2300 ps;
		CE_IN <= '1';
		WAIT FOR 1033 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 502 ps;
	CE_IN <= '1';
	WAIT FOR 2405 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 4133 ps;
		CE_IN <= '1';
		WAIT FOR 2533 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 4133 ps;
	CE_IN <= '1';
	WAIT FOR 130 ps;
	CE_IN <= '0';
	WAIT FOR 672 ps;
	CE_IN <= '1';
	WAIT FOR 1666 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 1667 ps;
		CE_IN <= '1';
		WAIT FOR 1666 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 1578 ps;
	CE_IN <= '1';
	WAIT FOR 2100 ps;
	CE_IN <= '0';
	WAIT FOR 2900 ps;
	CE_IN <= '1';
	WAIT FOR 2100 ps;
	CE_IN <= '0';
	WAIT FOR 9713 ps;
	CE_IN <= '1';
	WAIT FOR 9200 ps;
	CE_IN <= '0';
	WAIT FOR 3405 ps;
	CE_IN <= '1';
	WAIT FOR 290 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 2300 ps;
		CE_IN <= '1';
		WAIT FOR 1033 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 2300 ps;
	CE_IN <= '1';
	WAIT FOR 744 ps;
	CE_IN <= '0';
	WAIT FOR 2110 ps;
	CE_IN <= '1';
	WAIT FOR 5400 ps;
	CE_IN <= '0';
	WAIT FOR 4600 ps;
	CE_IN <= '1';
	WAIT FOR 5400 ps;
	CE_IN <= '0';
	WAIT FOR 2490 ps;
	CE_IN <= '1';
	WAIT FOR 826 ps;
	CE_IN <= '0';
	WAIT FOR 2700 ps;
	CE_IN <= '1';
	WAIT FOR 2300 ps;
	CE_IN <= '0';
	WAIT FOR 2700 ps;
	CE_IN <= '1';
	WAIT FOR 1474 ps;
	CE_IN <= '0';
	WAIT FOR 4640 ps;
	CE_IN <= '1';
	WAIT FOR 6800 ps;
	CE_IN <= '0';
	WAIT FOR 8560 ps;
	CE_IN <= '1';
	WAIT FOR 1988 ps;
	CE_IN <= '0';
	WAIT FOR 4700 ps;
	CE_IN <= '1';
	WAIT FOR 3312 ps;
	CE_IN <= '0';
	WAIT FOR 1202 ps;
	CE_IN <= '1';
	WAIT FOR 1833 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 1500 ps;
		CE_IN <= '1';
		WAIT FOR 1833 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 2615 ps;
	CE_IN <= '1';
	WAIT FOR 1950 ps;
	CE_IN <= '0';
	WAIT FOR 3050 ps;
	CE_IN <= '1';
	WAIT FOR 1950 ps;
	CE_IN <= '0';
	WAIT FOR 734 ps;
	CE_IN <= '1';
	WAIT FOR 1172 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 4467 ps;
		CE_IN <= '1';
		WAIT FOR 2199 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 4467 ps;
	CE_IN <= '1';
	WAIT FOR 1029 ps;
	CE_IN <= '0';
	WAIT FOR 3230 ps;
	CE_IN <= '1';
	WAIT FOR 5000 ps;
	CE_IN <= '0';
	WAIT FOR 3794 ps;
	CE_IN <= '1';
	WAIT FOR 4500 ps;
	CE_IN <= '0';
	WAIT FOR 7872 ps;
	CE_IN <= '1';
	WAIT FOR 3000 ps;
	CE_IN <= '0';
	WAIT FOR 2604 ps;
	CE_IN <= '1';
	WAIT FOR 158 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 3067 ps;
		CE_IN <= '1';
		WAIT FOR 3599 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 3067 ps;
	CE_IN <= '1';
	WAIT FOR 3443 ps;
	CE_IN <= '0';
	WAIT FOR 5731 ps;
	CE_IN <= '1';
	WAIT FOR 3500 ps;
	CE_IN <= '0';
	WAIT FOR 6500 ps;
	CE_IN <= '1';
	WAIT FOR 3500 ps;
	CE_IN <= '0';
	WAIT FOR 1705 ps;
	CE_IN <= '1';
	WAIT FOR 1700 ps;
	CE_IN <= '0';
	WAIT FOR 3300 ps;
	CE_IN <= '1';
	WAIT FOR 1700 ps;
	CE_IN <= '0';
	WAIT FOR 2364 ps;
	CE_IN <= '1';
	WAIT FOR 6744 ps;
	CE_IN <= '0';
	WAIT FOR 11600 ps;
	CE_IN <= '1';
	WAIT FOR 1656 ps;
	CE_IN <= '0';
	WAIT FOR 2376 ps;
	CE_IN <= '1';
	WAIT FOR 3400 ps;
	CE_IN <= '0';
	WAIT FOR 6600 ps;
	CE_IN <= '1';
	WAIT FOR 3400 ps;
	CE_IN <= '0';
	WAIT FOR 10550 ps;
	CE_IN <= '1';
	WAIT FOR 3600 ps;
	CE_IN <= '0';
	WAIT FOR 6400 ps;
	CE_IN <= '1';
	WAIT FOR 3600 ps;
	CE_IN <= '0';
	WAIT FOR 11637 ps;
	CE_IN <= '1';
	WAIT FOR 8400 ps;
	CE_IN <= '0';
	WAIT FOR 37 ps;
	CE_IN <= '1';
	WAIT FOR 1681 ps;
	CE_IN <= '0';
	WAIT FOR 5600 ps;
	CE_IN <= '1';
	WAIT FOR 4400 ps;
	CE_IN <= '0';
	WAIT FOR 5600 ps;
	CE_IN <= '1';
	WAIT FOR 4630 ps;
	CE_IN <= '0';
	WAIT FOR 6900 ps;
	CE_IN <= '1';
	WAIT FOR 5258 ps;
	CE_IN <= '0';
	WAIT FOR 5500 ps;
	CE_IN <= '1';
	WAIT FOR 2794 ps;
	CE_IN <= '0';
	WAIT FOR 4133 ps;
	CE_IN <= '1';
	WAIT FOR 2533 ps;
	CE_IN <= '0';
	WAIT FOR 4133 ps;
	CE_IN <= '1';
	WAIT FOR 2533 ps;
	CE_IN <= '0';
	WAIT FOR 4133 ps;
	CE_IN <= '1';
	WAIT FOR 172 ps;
	CE_IN <= '0';
	WAIT FOR 2320 ps;
	CE_IN <= '1';
	WAIT FOR 2350 ps;
	CE_IN <= '0';
	WAIT FOR 2650 ps;
	CE_IN <= '1';
	WAIT FOR 2350 ps;
	CE_IN <= '0';
	WAIT FOR 4405 ps;
	CE_IN <= '1';
	WAIT FOR 4600 ps;
	CE_IN <= '0';
	WAIT FOR 1755 ps;
	CE_IN <= '1';
	WAIT FOR 6200 ps;
	CE_IN <= '0';
	WAIT FOR 13895 ps;
	CE_IN <= '1';
	WAIT FOR 3600 ps;
	CE_IN <= '0';
	WAIT FOR 7061 ps;
	CE_IN <= '1';
	WAIT FOR 1950 ps;
	CE_IN <= '0';
	WAIT FOR 3050 ps;
	CE_IN <= '1';
	WAIT FOR 1950 ps;
	CE_IN <= '0';
	WAIT FOR 4362 ps;
	CE_IN <= '1';
	WAIT FOR 2266 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 4400 ps;
		CE_IN <= '1';
		WAIT FOR 2266 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 1904 ps;
	CE_IN <= '1';
	WAIT FOR 4049 ps;
	CE_IN <= '0';
	WAIT FOR 5900 ps;
	CE_IN <= '1';
	WAIT FOR 4100 ps;
	CE_IN <= '0';
	WAIT FOR 5900 ps;
	CE_IN <= '1';
	WAIT FOR 5276 ps;
	CE_IN <= '0';
	WAIT FOR 13400 ps;
	CE_IN <= '1';
	WAIT FOR 1375 ps;
	CE_IN <= '0';
	WAIT FOR 6930 ps;
	CE_IN <= '1';
	WAIT FOR 9400 ps;
	CE_IN <= '0';
	WAIT FOR 3819 ps;
	CE_IN <= '1';
	WAIT FOR 2000 ps;
	CE_IN <= '0';
	WAIT FOR 3000 ps;
	CE_IN <= '1';
	WAIT FOR 2000 ps;
	CE_IN <= '0';
	WAIT FOR 5093 ps;
	CE_IN <= '1';
	WAIT FOR 1066 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 2267 ps;
		CE_IN <= '1';
		WAIT FOR 1066 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 6954 ps;
	CE_IN <= '1';
	WAIT FOR 11800 ps;
	CE_IN <= '0';
	WAIT FOR 1272 ps;
	CE_IN <= '1';
	WAIT FOR 1651 ps;
	CE_IN <= '0';
	WAIT FOR 3300 ps;
	CE_IN <= '1';
	WAIT FOR 1700 ps;
	CE_IN <= '0';
	WAIT FOR 3300 ps;
	CE_IN <= '1';
	WAIT FOR 246 ps;
	CE_IN <= '0';
	WAIT FOR 3400 ps;
	CE_IN <= '1';
	WAIT FOR 3266 ps;
	CE_IN <= '0';
	WAIT FOR 3400 ps;
	CE_IN <= '1';
	WAIT FOR 3266 ps;
	CE_IN <= '0';
	WAIT FOR 3400 ps;
	CE_IN <= '1';
	WAIT FOR 3071 ps;
	CE_IN <= '0';
	WAIT FOR 1546 ps;
	CE_IN <= '1';
	WAIT FOR 5600 ps;
	CE_IN <= '0';
	WAIT FOR 4400 ps;
	CE_IN <= '1';
	WAIT FOR 5600 ps;
	CE_IN <= '0';
	WAIT FOR 3272 ps;
	CE_IN <= '1';
	WAIT FOR 2266 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 4400 ps;
		CE_IN <= '1';
		WAIT FOR 2266 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 3984 ps;
	CE_IN <= '1';
	WAIT FOR 2083 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 3800 ps;
		CE_IN <= '1';
		WAIT FOR 2866 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 3800 ps;
	CE_IN <= '1';
	WAIT FOR 2720 ps;
	CE_IN <= '0';
	WAIT FOR 2950 ps;
	CE_IN <= '1';
	WAIT FOR 2050 ps;
	CE_IN <= '0';
	WAIT FOR 2950 ps;
	CE_IN <= '1';
	WAIT FOR 115 ps;
	CE_IN <= '0';
	WAIT FOR 615 ps;
	CE_IN <= '1';
	WAIT FOR 1966 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 1367 ps;
		CE_IN <= '1';
		WAIT FOR 1966 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 932 ps;
	CE_IN <= '1';
	WAIT FOR 3466 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 3200 ps;
		CE_IN <= '1';
		WAIT FOR 3466 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 3023 ps;
	CE_IN <= '1';
	WAIT FOR 1386 ps;
	FOR i IN 1 TO 2
	LOOP
		CE_IN <= '0';
		WAIT FOR 2667 ps;
		CE_IN <= '1';
		WAIT FOR 3999 ps;
	END LOOP;
	CE_IN <= '0';
	WAIT FOR 2667 ps;
	CE_IN <= '1';
WAIT;
END PROCESS t_prcs_CE_IN;

-- CLK
t_prcs_CLK: PROCESS
BEGIN
	FOR i IN 1 TO 48
	LOOP
		CLK <= '0';
		WAIT FOR 10417 ps;
		CLK <= '1';
		WAIT FOR 10416 ps;
	END LOOP;
	CLK <= '0';
WAIT;
END PROCESS t_prcs_CLK;

-- RST
t_prcs_RST: PROCESS
BEGIN
	RST <= '0';
WAIT;
END PROCESS t_prcs_RST;
END dualnand_arch;
