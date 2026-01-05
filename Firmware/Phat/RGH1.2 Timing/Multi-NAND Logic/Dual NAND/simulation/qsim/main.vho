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

-- DATE "01/05/2026 18:13:57"

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

ENTITY 	dualnand IS
    PORT (
	RST : IN std_logic;
	BUT : IN std_logic;
	CLK : IN std_logic;
	CE_IN : IN std_logic;
	CES : OUT std_logic;
	CED : OUT std_logic;
	SMC : OUT std_logic;
	DBG : OUT std_logic
	);
END dualnand;

-- Design Ports Information


ARCHITECTURE structure OF dualnand IS
SIGNAL gnd : std_logic := '0';
SIGNAL vcc : std_logic := '1';
SIGNAL unknown : std_logic := 'X';
SIGNAL devoe : std_logic := '1';
SIGNAL devclrn : std_logic := '1';
SIGNAL devpor : std_logic := '1';
SIGNAL ww_devoe : std_logic;
SIGNAL ww_devclrn : std_logic;
SIGNAL ww_devpor : std_logic;
SIGNAL ww_RST : std_logic;
SIGNAL ww_BUT : std_logic;
SIGNAL ww_CLK : std_logic;
SIGNAL ww_CE_IN : std_logic;
SIGNAL ww_CES : std_logic;
SIGNAL ww_CED : std_logic;
SIGNAL ww_SMC : std_logic;
SIGNAL ww_DBG : std_logic;
SIGNAL \CE_IN~combout\ : std_logic;
SIGNAL \CLK~combout\ : std_logic;
SIGNAL \RST~combout\ : std_logic;
SIGNAL \BUT~combout\ : std_logic;
SIGNAL \process_1~0\ : std_logic;
SIGNAL \Equal2~0_combout\ : std_logic;
SIGNAL \Add2~0_combout\ : std_logic;
SIGNAL \Equal2~1_combout\ : std_logic;
SIGNAL \counter[0]~1_combout\ : std_logic;
SIGNAL \counter[2]~0_combout\ : std_logic;
SIGNAL \Add0~0_combout\ : std_logic;
SIGNAL \Equal1~0_combout\ : std_logic;
SIGNAL \switch~regout\ : std_logic;
SIGNAL \pre_sw~regout\ : std_logic;
SIGNAL \m_CES~regout\ : std_logic;
SIGNAL \CES~0_combout\ : std_logic;
SIGNAL \CED~0_combout\ : std_logic;
SIGNAL \counter_smc~regout\ : std_logic;
SIGNAL \SMC~en_regout\ : std_logic;
SIGNAL counter_dbg : std_logic_vector(3 DOWNTO 0);
SIGNAL counter : std_logic_vector(2 DOWNTO 0);
SIGNAL \ALT_INV_SMC~en_regout\ : std_logic;

BEGIN

ww_RST <= RST;
ww_BUT <= BUT;
ww_CLK <= CLK;
ww_CE_IN <= CE_IN;
CES <= ww_CES;
CED <= ww_CED;
SMC <= ww_SMC;
DBG <= ww_DBG;
ww_devoe <= devoe;
ww_devclrn <= devclrn;
ww_devpor <= devpor;
\ALT_INV_SMC~en_regout\ <= NOT \SMC~en_regout\;

-- Location: PIN_7,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: Default
\CE_IN~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "input")
-- pragma translate_on
PORT MAP (
	oe => GND,
	padio => ww_CE_IN,
	combout => \CE_IN~combout\);

-- Location: PIN_32,	 I/O Standard: 3.3-V LVCMOS,	 Current Strength: Default
\CLK~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "input")
-- pragma translate_on
PORT MAP (
	oe => GND,
	padio => ww_CLK,
	combout => \CLK~combout\);

-- Location: PIN_35,	 I/O Standard: 1.5 V,	 Current Strength: Default
\RST~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "input")
-- pragma translate_on
PORT MAP (
	oe => GND,
	padio => ww_RST,
	combout => \RST~combout\);

-- Location: PIN_2,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: Default
\BUT~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "input")
-- pragma translate_on
PORT MAP (
	oe => GND,
	padio => ww_BUT,
	combout => \BUT~combout\);

-- Location: LC_X3_Y4_N2
\counter_dbg[0]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(0) = DFFEAS((\Equal2~1_combout\ & (\pre_sw~regout\ $ ((\switch~regout\)))) # (!\Equal2~1_combout\ & (((!counter_dbg(0))))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "606f",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => \pre_sw~regout\,
	datab => \switch~regout\,
	datac => \Equal2~1_combout\,
	datad => counter_dbg(0),
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(0));

-- Location: LC_X3_Y4_N8
pre_sw : maxv_lcell
-- Equation(s):
-- \process_1~0\ = ((pre_sw $ (\switch~regout\)))
-- \pre_sw~regout\ = DFFEAS(\process_1~0\, GLOBAL(\CLK~combout\), VCC, , , \switch~regout\, , , VCC)

-- pragma translate_off
GENERIC MAP (
	lut_mask => "0ff0",
	operation_mode => "normal",
	output_mode => "reg_and_comb",
	register_cascade_mode => "off",
	sum_lutc_input => "qfbk",
	synch_mode => "on")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datac => \switch~regout\,
	datad => \switch~regout\,
	aclr => GND,
	sload => VCC,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \process_1~0\,
	regout => \pre_sw~regout\);

-- Location: LC_X3_Y4_N5
\counter_dbg[1]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(1) = DFFEAS((\Equal2~1_combout\ & (((\process_1~0\)))) # (!\Equal2~1_combout\ & (counter_dbg(0) $ ((!counter_dbg(1))))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "f909",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter_dbg(0),
	datab => counter_dbg(1),
	datac => \Equal2~1_combout\,
	datad => \process_1~0\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(1));

-- Location: LC_X3_Y4_N9
\Equal2~0\ : maxv_lcell
-- Equation(s):
-- \Equal2~0_combout\ = ((!counter_dbg(0) & (!counter_dbg(1) & !counter_dbg(2))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "0003",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datab => counter_dbg(0),
	datac => counter_dbg(1),
	datad => counter_dbg(2),
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Equal2~0_combout\);

-- Location: LC_X3_Y4_N3
\counter_dbg[3]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(3) = DFFEAS((counter_dbg(3) & (((!\Equal2~0_combout\)))) # (!counter_dbg(3) & (!\pre_sw~regout\ & (\switch~regout\ & \Equal2~0_combout\))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "04f0",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => \pre_sw~regout\,
	datab => \switch~regout\,
	datac => counter_dbg(3),
	datad => \Equal2~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(3));

-- Location: LC_X3_Y4_N0
\Add2~0\ : maxv_lcell
-- Equation(s):
-- \Add2~0_combout\ = (((!counter_dbg(0) & !counter_dbg(1))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "000f",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datac => counter_dbg(0),
	datad => counter_dbg(1),
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Add2~0_combout\);

-- Location: LC_X3_Y4_N6
\counter_dbg[2]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(2) = DFFEAS((counter_dbg(2) & (((!\Add2~0_combout\)))) # (!counter_dbg(2) & (\Add2~0_combout\ & ((counter_dbg(3)) # (\process_1~0\)))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "3c2c",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter_dbg(3),
	datab => counter_dbg(2),
	datac => \Add2~0_combout\,
	datad => \process_1~0\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(2));

-- Location: LC_X3_Y4_N7
\Equal2~1\ : maxv_lcell
-- Equation(s):
-- \Equal2~1_combout\ = (!counter_dbg(2) & (!counter_dbg(0) & (!counter_dbg(1) & !counter_dbg(3))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "0001",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	dataa => counter_dbg(2),
	datab => counter_dbg(0),
	datac => counter_dbg(1),
	datad => counter_dbg(3),
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Equal2~1_combout\);

-- Location: LC_X2_Y4_N5
\counter[0]~1\ : maxv_lcell
-- Equation(s):
-- \counter[0]~1_combout\ = (\BUT~combout\) # ((!\RST~combout\ & ((\Equal1~0_combout\) # (\Equal2~1_combout\))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "dddc",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	dataa => \RST~combout\,
	datab => \BUT~combout\,
	datac => \Equal1~0_combout\,
	datad => \Equal2~1_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \counter[0]~1_combout\);

-- Location: LC_X2_Y4_N3
\counter[2]~0\ : maxv_lcell
-- Equation(s):
-- \counter[2]~0_combout\ = (!\RST~combout\ & (!\BUT~combout\ & (!\Equal1~0_combout\ & \Equal2~1_combout\)))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "0100",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	dataa => \RST~combout\,
	datab => \BUT~combout\,
	datac => \Equal1~0_combout\,
	datad => \Equal2~1_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \counter[2]~0_combout\);

-- Location: LC_X2_Y4_N4
\counter[0]\ : maxv_lcell
-- Equation(s):
-- counter(0) = DFFEAS((counter(0) & (((!\counter[0]~1_combout\)))) # (!counter(0) & (((\counter[2]~0_combout\)))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "5f0a",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter(0),
	datac => \counter[0]~1_combout\,
	datad => \counter[2]~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter(0));

-- Location: LC_X2_Y4_N2
\counter[1]\ : maxv_lcell
-- Equation(s):
-- counter(1) = DFFEAS((counter(1) & (((!counter(0) & \counter[2]~0_combout\)) # (!\counter[0]~1_combout\))) # (!counter(1) & (counter(0) & ((\counter[2]~0_combout\)))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "6e0c",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter(0),
	datab => counter(1),
	datac => \counter[0]~1_combout\,
	datad => \counter[2]~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter(1));

-- Location: LC_X2_Y4_N9
\Add0~0\ : maxv_lcell
-- Equation(s):
-- \Add0~0_combout\ = (((counter(0) & counter(1))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "f000",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datac => counter(0),
	datad => counter(1),
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Add0~0_combout\);

-- Location: LC_X2_Y4_N6
\counter[2]\ : maxv_lcell
-- Equation(s):
-- counter(2) = DFFEAS((counter(2) & (((!\Add0~0_combout\ & \counter[2]~0_combout\)) # (!\counter[0]~1_combout\))) # (!counter(2) & (\Add0~0_combout\ & ((\counter[2]~0_combout\)))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "6e0a",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter(2),
	datab => \Add0~0_combout\,
	datac => \counter[0]~1_combout\,
	datad => \counter[2]~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter(2));

-- Location: LC_X2_Y4_N7
\Equal1~0\ : maxv_lcell
-- Equation(s):
-- \Equal1~0_combout\ = ((counter(1) & (counter(2) & counter(0))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "c000",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datab => counter(1),
	datac => counter(2),
	datad => counter(0),
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Equal1~0_combout\);

-- Location: LC_X2_Y4_N8
switch : maxv_lcell
-- Equation(s):
-- \switch~regout\ = DFFEAS(\switch~regout\ $ (((!\RST~combout\ & (!\BUT~combout\ & \Equal1~0_combout\)))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "e1f0",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => \RST~combout\,
	datab => \BUT~combout\,
	datac => \switch~regout\,
	datad => \Equal1~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \switch~regout\);

-- Location: LC_X3_Y4_N4
m_CES : maxv_lcell
-- Equation(s):
-- \m_CES~regout\ = DFFEAS(((\pre_sw~regout\ & (\m_CES~regout\ & \switch~regout\)) # (!\pre_sw~regout\ & ((\m_CES~regout\) # (\switch~regout\)))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "f330",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datab => \pre_sw~regout\,
	datac => \m_CES~regout\,
	datad => \switch~regout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \m_CES~regout\);

-- Location: LC_X2_Y3_N2
\CES~0\ : maxv_lcell
-- Equation(s):
-- \CES~0_combout\ = ((\CE_IN~combout\) # ((\m_CES~regout\)))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "fcfc",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datab => \CE_IN~combout\,
	datac => \m_CES~regout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \CES~0_combout\);

-- Location: LC_X2_Y3_N3
\CED~0\ : maxv_lcell
-- Equation(s):
-- \CED~0_combout\ = ((\CE_IN~combout\) # ((!\m_CES~regout\)))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "cfcf",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datab => \CE_IN~combout\,
	datac => \m_CES~regout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \CED~0_combout\);

-- Location: LC_X2_Y4_N1
counter_smc : maxv_lcell
-- Equation(s):
-- \counter_smc~regout\ = DFFEAS(((!\counter_smc~regout\ & (\pre_sw~regout\ $ (\switch~regout\)))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "003c",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datab => \pre_sw~regout\,
	datac => \switch~regout\,
	datad => \counter_smc~regout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \counter_smc~regout\);

-- Location: LC_X2_Y4_N0
\SMC~en\ : maxv_lcell
-- Equation(s):
-- \SMC~en_regout\ = DFFEAS((((\counter_smc~regout\))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "ff00",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datad => \counter_smc~regout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \SMC~en_regout\);

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

-- Location: PIN_1,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: 16mA
\SMC~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	open_drain_output => "true",
	operation_mode => "output")
-- pragma translate_on
PORT MAP (
	datain => \ALT_INV_SMC~en_regout\,
	oe => VCC,
	padio => ww_SMC);

-- Location: PIN_64,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: 16mA
\DBG~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "output")
-- pragma translate_on
PORT MAP (
	datain => counter_dbg(2),
	oe => VCC,
	padio => ww_DBG);
END structure;


