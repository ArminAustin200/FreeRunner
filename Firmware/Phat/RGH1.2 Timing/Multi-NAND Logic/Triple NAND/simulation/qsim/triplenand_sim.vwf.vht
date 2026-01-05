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
-- Generated on "01/05/2026 12:36:20"
                                                             
-- Vhdl Test Bench(with test vectors) for design  :          triplenand
-- 
-- Simulation tool : 3rd Party
-- 

LIBRARY ieee;                                               
USE ieee.std_logic_1164.all;                                

ENTITY triplenand_vhd_vec_tst IS
END triplenand_vhd_vec_tst;
ARCHITECTURE triplenand_arch OF triplenand_vhd_vec_tst IS
-- constants                                                 
-- signals                                                   
SIGNAL BUT : STD_LOGIC;
SIGNAL CE_IN : STD_LOGIC;
SIGNAL CED : STD_LOGIC;
SIGNAL CES : STD_LOGIC;
SIGNAL CET : STD_LOGIC;
SIGNAL CLK : STD_LOGIC;
SIGNAL DBG : STD_LOGIC;
SIGNAL RST : STD_LOGIC;
SIGNAL SMC : STD_LOGIC;
COMPONENT triplenand
	PORT (
	BUT : IN STD_LOGIC;
	CE_IN : IN STD_LOGIC;
	CED : OUT STD_LOGIC;
	CES : OUT STD_LOGIC;
	CET : OUT STD_LOGIC;
	CLK : IN STD_LOGIC;
	DBG : OUT STD_LOGIC;
	RST : IN STD_LOGIC;
	SMC : OUT STD_LOGIC
	);
END COMPONENT;
BEGIN
	i1 : triplenand
	PORT MAP (
-- list connections between master ports and signals
	BUT => BUT,
	CE_IN => CE_IN,
	CED => CED,
	CES => CES,
	CET => CET,
	CLK => CLK,
	DBG => DBG,
	RST => RST,
	SMC => SMC
	);

-- BUT
t_prcs_BUT: PROCESS
BEGIN
	BUT <= '1';
	WAIT FOR 40000 ps;
	BUT <= '0';
	WAIT FOR 90000 ps;
	BUT <= '1';
	WAIT FOR 140000 ps;
	BUT <= '0';
	WAIT FOR 100000 ps;
	BUT <= '1';
WAIT;
END PROCESS t_prcs_BUT;

-- CLK
t_prcs_CLK: PROCESS
BEGIN
LOOP
	CLK <= '0';
	WAIT FOR 5000 ps;
	CLK <= '1';
	WAIT FOR 5000 ps;
	IF (NOW >= 1000000 ps) THEN WAIT; END IF;
END LOOP;
END PROCESS t_prcs_CLK;

-- RST
t_prcs_RST: PROCESS
BEGIN
	RST <= '0';
WAIT;
END PROCESS t_prcs_RST;

-- CE_IN
t_prcs_CE_IN: PROCESS
BEGIN
	CE_IN <= '1';
	WAIT FOR 70000 ps;
	CE_IN <= '0';
	WAIT FOR 40000 ps;
	CE_IN <= '1';
	WAIT FOR 100000 ps;
	CE_IN <= '0';
	WAIT FOR 30000 ps;
	CE_IN <= '1';
	WAIT FOR 40000 ps;
	CE_IN <= '0';
	WAIT FOR 30000 ps;
	CE_IN <= '1';
	WAIT FOR 120000 ps;
	CE_IN <= '0';
	WAIT FOR 70000 ps;
	CE_IN <= '1';
	WAIT FOR 40000 ps;
	CE_IN <= '0';
	WAIT FOR 30000 ps;
	CE_IN <= '1';
	WAIT FOR 30000 ps;
	CE_IN <= '0';
	WAIT FOR 30000 ps;
	CE_IN <= '1';
	WAIT FOR 50000 ps;
	CE_IN <= '0';
	WAIT FOR 30000 ps;
	CE_IN <= '1';
	WAIT FOR 130000 ps;
	CE_IN <= '0';
	WAIT FOR 50000 ps;
	CE_IN <= '1';
	WAIT FOR 60000 ps;
	CE_IN <= '0';
WAIT;
END PROCESS t_prcs_CE_IN;
END triplenand_arch;
