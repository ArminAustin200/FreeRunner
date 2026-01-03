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
-- Generated on "01/02/2026 21:30:23"
                                                             
-- Vhdl Test Bench(with test vectors) for design  :          mux2
-- 
-- Simulation tool : 3rd Party
-- 

LIBRARY ieee;                                               
USE ieee.std_logic_1164.all;                                

ENTITY mux2_vhd_vec_tst IS
END mux2_vhd_vec_tst;
ARCHITECTURE mux2_arch OF mux2_vhd_vec_tst IS
-- constants                                                 
-- signals                                                   
SIGNAL CE_IN : STD_LOGIC;
SIGNAL CED : STD_LOGIC;
SIGNAL CES : STD_LOGIC;
SIGNAL SEL : STD_LOGIC;
COMPONENT mux2
	PORT (
	CE_IN : IN STD_LOGIC;
	CED : OUT STD_LOGIC;
	CES : OUT STD_LOGIC;
	SEL : IN STD_LOGIC
	);
END COMPONENT;
BEGIN
	i1 : mux2
	PORT MAP (
-- list connections between master ports and signals
	CE_IN => CE_IN,
	CED => CED,
	CES => CES,
	SEL => SEL
	);

-- CE_IN
t_prcs_CE_IN: PROCESS
BEGIN
	CE_IN <= '1';
	WAIT FOR 110000 ps;
	CE_IN <= '0';
	WAIT FOR 40000 ps;
	CE_IN <= '1';
	WAIT FOR 50000 ps;
	CE_IN <= '0';
	WAIT FOR 30000 ps;
	CE_IN <= '1';
	WAIT FOR 210000 ps;
	CE_IN <= '0';
	WAIT FOR 70000 ps;
	CE_IN <= '1';
	WAIT FOR 100000 ps;
	CE_IN <= '0';
	WAIT FOR 70000 ps;
	CE_IN <= '1';
	WAIT FOR 80000 ps;
	CE_IN <= '0';
	WAIT FOR 50000 ps;
	CE_IN <= '1';
	WAIT FOR 40000 ps;
	CE_IN <= '0';
	WAIT FOR 80000 ps;
	CE_IN <= '1';
	WAIT FOR 50000 ps;
	CE_IN <= '0';
WAIT;
END PROCESS t_prcs_CE_IN;

-- SEL
t_prcs_SEL: PROCESS
BEGIN
	SEL <= '0';
WAIT;
END PROCESS t_prcs_SEL;
END mux2_arch;
