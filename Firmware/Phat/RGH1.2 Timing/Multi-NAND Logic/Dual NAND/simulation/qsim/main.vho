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

-- VENDOR "Altera"
-- PROGRAM "Quartus Prime"
-- VERSION "Version 17.0.0 Build 595 04/25/2017 SJ Lite Edition"

-- DATE "01/02/2026 21:30:24"

-- 
-- Device: Altera 5M160ZE64C5 Package EQFP64
-- 

-- 
-- This VHDL file should be used for ModelSim-Altera (VHDL) only
-- 

LIBRARY IEEE;
LIBRARY MAXV;
USE IEEE.STD_LOGIC_1164.ALL;
USE MAXV.MAXV_COMPONENTS.ALL;

ENTITY 	mux2 IS
    PORT (
	CES : OUT std_logic;
	CED : OUT std_logic;
	CE_IN : IN std_logic;
	SEL : IN std_logic
	);
END mux2;

-- Design Ports Information


ARCHITECTURE structure OF mux2 IS
SIGNAL gnd : std_logic := '0';
SIGNAL vcc : std_logic := '1';
SIGNAL unknown : std_logic := 'X';
SIGNAL devoe : std_logic := '1';
SIGNAL devclrn : std_logic := '1';
SIGNAL devpor : std_logic := '1';
SIGNAL ww_devoe : std_logic;
SIGNAL ww_devclrn : std_logic;
SIGNAL ww_devpor : std_logic;
SIGNAL ww_CES : std_logic;
SIGNAL ww_CED : std_logic;
SIGNAL ww_CE_IN : std_logic;
SIGNAL ww_SEL : std_logic;
SIGNAL \SEL~combout\ : std_logic;
SIGNAL \CE_IN~combout\ : std_logic;
SIGNAL \CES~0_combout\ : std_logic;
SIGNAL \CED~0_combout\ : std_logic;

BEGIN

CES <= ww_CES;
CED <= ww_CED;
ww_CE_IN <= CE_IN;
ww_SEL <= SEL;
ww_devoe <= devoe;
ww_devclrn <= devclrn;
ww_devpor <= devpor;

-- Location: PIN_20,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: Default
\SEL~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "input")
-- pragma translate_on
PORT MAP (
	oe => GND,
	padio => ww_SEL,
	combout => \SEL~combout\);

-- Location: PIN_62,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: Default
\CE_IN~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "input")
-- pragma translate_on
PORT MAP (
	oe => GND,
	padio => ww_CE_IN,
	combout => \CE_IN~combout\);

-- Location: LC_X2_Y3_N2
\CES~0\ : maxv_lcell
-- Equation(s):
-- \CES~0_combout\ = (((\SEL~combout\) # (\CE_IN~combout\)))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "fff0",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datac => \SEL~combout\,
	datad => \CE_IN~combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \CES~0_combout\);

-- Location: LC_X2_Y3_N3
\CED~0\ : maxv_lcell
-- Equation(s):
-- \CED~0_combout\ = (((\CE_IN~combout\) # (!\SEL~combout\)))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "ff0f",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datac => \SEL~combout\,
	datad => \CE_IN~combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \CED~0_combout\);

-- Location: PIN_3,	 I/O Standard: 3.3-V LVCMOS,	 Current Strength: 8mA
\CES~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "output")
-- pragma translate_on
PORT MAP (
	datain => \CES~0_combout\,
	oe => VCC,
	padio => ww_CES);

-- Location: PIN_4,	 I/O Standard: 3.3-V LVCMOS,	 Current Strength: 8mA
\CED~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "output")
-- pragma translate_on
PORT MAP (
	datain => \CED~0_combout\,
	oe => VCC,
	padio => ww_CED);
END structure;


