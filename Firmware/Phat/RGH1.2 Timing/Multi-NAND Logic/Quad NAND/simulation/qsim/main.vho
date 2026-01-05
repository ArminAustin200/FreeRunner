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

-- DATE "01/04/2026 18:52:40"

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

ENTITY 	quadnand IS
    PORT (
	RST : IN std_logic;
	BUT : IN std_logic;
	CLK : IN std_logic;
	CE_IN : IN std_logic;
	CES : BUFFER std_logic;
	CED : BUFFER std_logic;
	CET : BUFFER std_logic;
	CEQ : BUFFER std_logic;
	SMC : BUFFER std_logic;
	DBG : BUFFER std_logic
	);
END quadnand;

-- Design Ports Information


ARCHITECTURE structure OF quadnand IS
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
SIGNAL ww_CET : std_logic;
SIGNAL ww_CEQ : std_logic;
SIGNAL ww_SMC : std_logic;
SIGNAL ww_DBG : std_logic;
SIGNAL \CLK~combout\ : std_logic;
SIGNAL \BUT~combout\ : std_logic;
SIGNAL \RST~combout\ : std_logic;
SIGNAL \counter_dbg~11\ : std_logic;
SIGNAL \Equal2~0\ : std_logic;
SIGNAL \counter_dbg[0]~3\ : std_logic;
SIGNAL \counter_dbg[0]~3COUT1_13\ : std_logic;
SIGNAL \counter_dbg[1]~5\ : std_logic;
SIGNAL \counter_dbg[1]~5COUT1_14\ : std_logic;
SIGNAL \counter_dbg[2]~1\ : std_logic;
SIGNAL \counter_dbg[2]~1COUT1_15\ : std_logic;
SIGNAL \counter_dbg~10_combout\ : std_logic;
SIGNAL \counter_dbg[3]~9\ : std_logic;
SIGNAL \counter_dbg[3]~9COUT1_16\ : std_logic;
SIGNAL \Equal6~0_combout\ : std_logic;
SIGNAL \Equal6~1_combout\ : std_logic;
SIGNAL \counter[0]~1_combout\ : std_logic;
SIGNAL \counter[0]~0_combout\ : std_logic;
SIGNAL \Equal1~1_combout\ : std_logic;
SIGNAL \Equal1~2_combout\ : std_logic;
SIGNAL \process_1~0_combout\ : std_logic;
SIGNAL \Equal1~0_combout\ : std_logic;
SIGNAL \switch[0]~0_combout\ : std_logic;
SIGNAL \m_CES~regout\ : std_logic;
SIGNAL \CE_IN~combout\ : std_logic;
SIGNAL \CES~0_combout\ : std_logic;
SIGNAL \m_CED~regout\ : std_logic;
SIGNAL \CED~0_combout\ : std_logic;
SIGNAL \m_CET~regout\ : std_logic;
SIGNAL \CET~0_combout\ : std_logic;
SIGNAL \m_CEQ~regout\ : std_logic;
SIGNAL \CEQ~0_combout\ : std_logic;
SIGNAL \counter_smc~regout\ : std_logic;
SIGNAL \SMC~en_regout\ : std_logic;
SIGNAL counter_dbg : std_logic_vector(4 DOWNTO 0);
SIGNAL switch : std_logic_vector(1 DOWNTO 0);
SIGNAL pre_sw : std_logic_vector(1 DOWNTO 0);
SIGNAL counter : std_logic_vector(3 DOWNTO 0);
SIGNAL \ALT_INV_SMC~en_regout\ : std_logic;

BEGIN

ww_RST <= RST;
ww_BUT <= BUT;
ww_CLK <= CLK;
ww_CE_IN <= CE_IN;
CES <= ww_CES;
CED <= ww_CED;
CET <= ww_CET;
CEQ <= ww_CEQ;
SMC <= ww_SMC;
DBG <= ww_DBG;
ww_devoe <= devoe;
ww_devclrn <= devclrn;
ww_devpor <= devpor;
\ALT_INV_SMC~en_regout\ <= NOT \SMC~en_regout\;

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

-- Location: PIN_27,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: Default
\BUT~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "input")
-- pragma translate_on
PORT MAP (
	oe => GND,
	padio => ww_BUT,
	combout => \BUT~combout\);

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

-- Location: LC_X4_Y3_N4
\switch[1]\ : maxv_lcell
-- Equation(s):
-- switch(1) = DFFEAS((switch(0) $ ((switch(1)))), GLOBAL(\CLK~combout\), VCC, , \switch[0]~0_combout\, , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "3c3c",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datab => switch(0),
	datac => switch(1),
	aclr => GND,
	ena => \switch[0]~0_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => switch(1));

-- Location: LC_X3_Y3_N6
\pre_sw[1]\ : maxv_lcell
-- Equation(s):
-- \counter_dbg~11\ = (switch(0) & ((switch(1) $ (pre_sw[1])) # (!pre_sw(0))))
-- pre_sw(1) = DFFEAS(\counter_dbg~11\, GLOBAL(\CLK~combout\), VCC, , , switch(1), , , VCC)

-- pragma translate_off
GENERIC MAP (
	lut_mask => "7d00",
	operation_mode => "normal",
	output_mode => "reg_and_comb",
	register_cascade_mode => "off",
	sum_lutc_input => "qfbk",
	synch_mode => "on")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => pre_sw(0),
	datab => switch(1),
	datac => switch(1),
	datad => switch(0),
	aclr => GND,
	sload => VCC,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \counter_dbg~11\,
	regout => pre_sw(1));

-- Location: LC_X3_Y3_N8
\pre_sw[0]\ : maxv_lcell
-- Equation(s):
-- \Equal2~0\ = (pre_sw(1) & ((pre_sw[0] $ (switch(0))) # (!switch(1)))) # (!pre_sw(1) & ((switch(1)) # (pre_sw[0] $ (switch(0)))))
-- pre_sw(0) = DFFEAS(\Equal2~0\, GLOBAL(\CLK~combout\), VCC, , , switch(0), , , VCC)

-- pragma translate_off
GENERIC MAP (
	lut_mask => "6ff6",
	operation_mode => "normal",
	output_mode => "reg_and_comb",
	register_cascade_mode => "off",
	sum_lutc_input => "qfbk",
	synch_mode => "on")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => pre_sw(1),
	datab => switch(1),
	datac => switch(0),
	datad => switch(0),
	aclr => GND,
	sload => VCC,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Equal2~0\,
	regout => pre_sw(0));

-- Location: LC_X6_Y3_N0
\counter_dbg[0]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(0) = DFFEAS(((!counter_dbg(0))), GLOBAL(\CLK~combout\), VCC, , , \Equal2~0\, , , \Equal6~1_combout\)
-- \counter_dbg[0]~3\ = CARRY(((counter_dbg(0))))
-- \counter_dbg[0]~3COUT1_13\ = CARRY(((counter_dbg(0))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "33cc",
	operation_mode => "arithmetic",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "on")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datab => counter_dbg(0),
	datac => \Equal2~0\,
	aclr => GND,
	sload => \Equal6~1_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(0),
	cout0 => \counter_dbg[0]~3\,
	cout1 => \counter_dbg[0]~3COUT1_13\);

-- Location: LC_X6_Y3_N1
\counter_dbg[1]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(1) = DFFEAS((counter_dbg(1) $ ((!\counter_dbg[0]~3\))), GLOBAL(\CLK~combout\), VCC, , , \Equal2~0\, , , \Equal6~1_combout\)
-- \counter_dbg[1]~5\ = CARRY(((!counter_dbg(1) & !\counter_dbg[0]~3\)))
-- \counter_dbg[1]~5COUT1_14\ = CARRY(((!counter_dbg(1) & !\counter_dbg[0]~3COUT1_13\)))

-- pragma translate_off
GENERIC MAP (
	cin0_used => "true",
	cin1_used => "true",
	lut_mask => "c303",
	operation_mode => "arithmetic",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "cin",
	synch_mode => "on")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datab => counter_dbg(1),
	datac => \Equal2~0\,
	aclr => GND,
	sload => \Equal6~1_combout\,
	cin0 => \counter_dbg[0]~3\,
	cin1 => \counter_dbg[0]~3COUT1_13\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(1),
	cout0 => \counter_dbg[1]~5\,
	cout1 => \counter_dbg[1]~5COUT1_14\);

-- Location: LC_X6_Y3_N2
\counter_dbg[2]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(2) = DFFEAS((counter_dbg(2) $ ((\counter_dbg[1]~5\))), GLOBAL(\CLK~combout\), VCC, , , \Equal2~0\, , , \Equal6~1_combout\)
-- \counter_dbg[2]~1\ = CARRY(((counter_dbg(2)) # (!\counter_dbg[1]~5\)))
-- \counter_dbg[2]~1COUT1_15\ = CARRY(((counter_dbg(2)) # (!\counter_dbg[1]~5COUT1_14\)))

-- pragma translate_off
GENERIC MAP (
	cin0_used => "true",
	cin1_used => "true",
	lut_mask => "3ccf",
	operation_mode => "arithmetic",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "cin",
	synch_mode => "on")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datab => counter_dbg(2),
	datac => \Equal2~0\,
	aclr => GND,
	sload => \Equal6~1_combout\,
	cin0 => \counter_dbg[1]~5\,
	cin1 => \counter_dbg[1]~5COUT1_14\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(2),
	cout0 => \counter_dbg[2]~1\,
	cout1 => \counter_dbg[2]~1COUT1_15\);

-- Location: LC_X6_Y3_N3
\counter_dbg[3]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(3) = DFFEAS(counter_dbg(3) $ ((((!\counter_dbg[2]~1\)))), GLOBAL(\CLK~combout\), VCC, , , \counter_dbg~11\, , , \Equal6~1_combout\)
-- \counter_dbg[3]~9\ = CARRY((!counter_dbg(3) & ((!\counter_dbg[2]~1\))))
-- \counter_dbg[3]~9COUT1_16\ = CARRY((!counter_dbg(3) & ((!\counter_dbg[2]~1COUT1_15\))))

-- pragma translate_off
GENERIC MAP (
	cin0_used => "true",
	cin1_used => "true",
	lut_mask => "a505",
	operation_mode => "arithmetic",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "cin",
	synch_mode => "on")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter_dbg(3),
	datac => \counter_dbg~11\,
	aclr => GND,
	sload => \Equal6~1_combout\,
	cin0 => \counter_dbg[2]~1\,
	cin1 => \counter_dbg[2]~1COUT1_15\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(3),
	cout0 => \counter_dbg[3]~9\,
	cout1 => \counter_dbg[3]~9COUT1_16\);

-- Location: LC_X3_Y3_N9
\counter_dbg~10\ : maxv_lcell
-- Equation(s):
-- \counter_dbg~10_combout\ = (switch(1) & ((pre_sw(0) $ (switch(0))) # (!pre_sw(1))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "70b0",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	dataa => pre_sw(0),
	datab => pre_sw(1),
	datac => switch(1),
	datad => switch(0),
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \counter_dbg~10_combout\);

-- Location: LC_X6_Y3_N4
\counter_dbg[4]\ : maxv_lcell
-- Equation(s):
-- counter_dbg(4) = DFFEAS(counter_dbg(4) $ ((((\counter_dbg[3]~9\)))), GLOBAL(\CLK~combout\), VCC, , , \counter_dbg~10_combout\, , , \Equal6~1_combout\)

-- pragma translate_off
GENERIC MAP (
	cin0_used => "true",
	cin1_used => "true",
	lut_mask => "5a5a",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "cin",
	synch_mode => "on")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter_dbg(4),
	datac => \counter_dbg~10_combout\,
	aclr => GND,
	sload => \Equal6~1_combout\,
	cin0 => \counter_dbg[3]~9\,
	cin1 => \counter_dbg[3]~9COUT1_16\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter_dbg(4));

-- Location: LC_X6_Y3_N6
\Equal6~0\ : maxv_lcell
-- Equation(s):
-- \Equal6~0_combout\ = (((!counter_dbg(0) & !counter_dbg(1))))

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
	combout => \Equal6~0_combout\);

-- Location: LC_X6_Y3_N7
\Equal6~1\ : maxv_lcell
-- Equation(s):
-- \Equal6~1_combout\ = (!counter_dbg(3) & (!counter_dbg(2) & (!counter_dbg(4) & \Equal6~0_combout\)))

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
	dataa => counter_dbg(3),
	datab => counter_dbg(2),
	datac => counter_dbg(4),
	datad => \Equal6~0_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Equal6~1_combout\);

-- Location: LC_X5_Y3_N5
\counter[0]~1\ : maxv_lcell
-- Equation(s):
-- \counter[0]~1_combout\ = (!\RST~combout\ & (!\BUT~combout\ & (!\Equal1~0_combout\ & \Equal6~1_combout\)))

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
	datad => \Equal6~1_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \counter[0]~1_combout\);

-- Location: LC_X5_Y3_N8
\counter[0]~0\ : maxv_lcell
-- Equation(s):
-- \counter[0]~0_combout\ = (!\BUT~combout\ & ((\RST~combout\) # ((!\Equal1~0_combout\ & !\Equal6~1_combout\))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "2223",
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
	datad => \Equal6~1_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \counter[0]~0_combout\);

-- Location: LC_X5_Y3_N6
\counter[0]\ : maxv_lcell
-- Equation(s):
-- counter(0) = DFFEAS(((counter(0) & ((\counter[0]~0_combout\))) # (!counter(0) & (\counter[0]~1_combout\))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "fc30",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datab => counter(0),
	datac => \counter[0]~1_combout\,
	datad => \counter[0]~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter(0));

-- Location: LC_X5_Y3_N7
\counter[1]\ : maxv_lcell
-- Equation(s):
-- counter(1) = DFFEAS((counter(1) & ((\counter[0]~0_combout\) # ((!counter(0) & \counter[0]~1_combout\)))) # (!counter(1) & (counter(0) & (\counter[0]~1_combout\))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "ea60",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter(1),
	datab => counter(0),
	datac => \counter[0]~1_combout\,
	datad => \counter[0]~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter(1));

-- Location: LC_X4_Y3_N8
\Equal1~1\ : maxv_lcell
-- Equation(s):
-- \Equal1~1_combout\ = (((counter(0) & counter(1))))

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
	combout => \Equal1~1_combout\);

-- Location: LC_X5_Y3_N9
\counter[2]\ : maxv_lcell
-- Equation(s):
-- counter(2) = DFFEAS((counter(2) & ((\counter[0]~0_combout\) # ((!\Equal1~1_combout\ & \counter[0]~1_combout\)))) # (!counter(2) & (\Equal1~1_combout\ & (\counter[0]~1_combout\))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "ec60",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => \Equal1~1_combout\,
	datab => counter(2),
	datac => \counter[0]~1_combout\,
	datad => \counter[0]~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter(2));

-- Location: LC_X5_Y3_N0
\Equal1~2\ : maxv_lcell
-- Equation(s):
-- \Equal1~2_combout\ = ((counter(2) & (counter(0) & counter(1))))

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
	datab => counter(2),
	datac => counter(0),
	datad => counter(1),
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Equal1~2_combout\);

-- Location: LC_X5_Y3_N3
\process_1~0\ : maxv_lcell
-- Equation(s):
-- \process_1~0_combout\ = (!\RST~combout\ & (((!\Equal1~0_combout\ & \Equal6~1_combout\))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "0500",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	dataa => \RST~combout\,
	datac => \Equal1~0_combout\,
	datad => \Equal6~1_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \process_1~0_combout\);

-- Location: LC_X5_Y3_N4
\counter[3]\ : maxv_lcell
-- Equation(s):
-- counter(3) = DFFEAS((!\BUT~combout\ & (counter(3) $ (((\Equal1~2_combout\ & \process_1~0_combout\))))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "1222",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => counter(3),
	datab => \BUT~combout\,
	datac => \Equal1~2_combout\,
	datad => \process_1~0_combout\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => counter(3));

-- Location: LC_X5_Y3_N2
\Equal1~0\ : maxv_lcell
-- Equation(s):
-- \Equal1~0_combout\ = (!counter(3) & (counter(1) & (counter(0) & counter(2))))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "4000",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	dataa => counter(3),
	datab => counter(1),
	datac => counter(0),
	datad => counter(2),
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \Equal1~0_combout\);

-- Location: LC_X5_Y3_N1
\switch[0]~0\ : maxv_lcell
-- Equation(s):
-- \switch[0]~0_combout\ = ((!\BUT~combout\ & (!\RST~combout\ & \Equal1~0_combout\)))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "0300",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datab => \BUT~combout\,
	datac => \RST~combout\,
	datad => \Equal1~0_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \switch[0]~0_combout\);

-- Location: LC_X4_Y3_N9
\switch[0]\ : maxv_lcell
-- Equation(s):
-- switch(0) = DFFEAS((((!switch(0)))), GLOBAL(\CLK~combout\), VCC, , \switch[0]~0_combout\, , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "00ff",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datad => switch(0),
	aclr => GND,
	ena => \switch[0]~0_combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => switch(0));

-- Location: LC_X3_Y3_N7
m_CES : maxv_lcell
-- Equation(s):
-- \m_CES~regout\ = DFFEAS((((switch(0)) # (switch(1)))), GLOBAL(\CLK~combout\), VCC, , \Equal2~0\, , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "fff0",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datac => switch(0),
	datad => switch(1),
	aclr => GND,
	ena => \Equal2~0\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \m_CES~regout\);

-- Location: PIN_9,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: Default
\CE_IN~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "input")
-- pragma translate_on
PORT MAP (
	oe => GND,
	padio => ww_CE_IN,
	combout => \CE_IN~combout\);

-- Location: LC_X3_Y3_N2
\CES~0\ : maxv_lcell
-- Equation(s):
-- \CES~0_combout\ = ((\m_CES~regout\) # ((\CE_IN~combout\)))

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
	datab => \m_CES~regout\,
	datac => \CE_IN~combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \CES~0_combout\);

-- Location: LC_X3_Y3_N1
m_CED : maxv_lcell
-- Equation(s):
-- \m_CED~regout\ = DFFEAS((((!switch(1) & switch(0)))), GLOBAL(\CLK~combout\), VCC, , \Equal2~0\, , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "0f00",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datac => switch(1),
	datad => switch(0),
	aclr => GND,
	ena => \Equal2~0\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \m_CED~regout\);

-- Location: LC_X2_Y3_N3
\CED~0\ : maxv_lcell
-- Equation(s):
-- \CED~0_combout\ = (((\CE_IN~combout\) # (!\m_CED~regout\)))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "f0ff",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datac => \CE_IN~combout\,
	datad => \m_CED~regout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \CED~0_combout\);

-- Location: LC_X3_Y3_N0
m_CET : maxv_lcell
-- Equation(s):
-- \m_CET~regout\ = DFFEAS((((!switch(0) & switch(1)))), GLOBAL(\CLK~combout\), VCC, , \Equal2~0\, , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "0f00",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datac => switch(0),
	datad => switch(1),
	aclr => GND,
	ena => \Equal2~0\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \m_CET~regout\);

-- Location: LC_X3_Y3_N3
\CET~0\ : maxv_lcell
-- Equation(s):
-- \CET~0_combout\ = (((\CE_IN~combout\)) # (!\m_CET~regout\))

-- pragma translate_off
GENERIC MAP (
	lut_mask => "f3f3",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	datab => \m_CET~regout\,
	datac => \CE_IN~combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \CET~0_combout\);

-- Location: LC_X3_Y3_N5
m_CEQ : maxv_lcell
-- Equation(s):
-- \m_CEQ~regout\ = DFFEAS((((switch(0) & switch(1)))), GLOBAL(\CLK~combout\), VCC, , \Equal2~0\, , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "f000",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	datac => switch(0),
	datad => switch(1),
	aclr => GND,
	ena => \Equal2~0\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \m_CEQ~regout\);

-- Location: LC_X3_Y3_N4
\CEQ~0\ : maxv_lcell
-- Equation(s):
-- \CEQ~0_combout\ = (((\CE_IN~combout\))) # (!\m_CEQ~regout\)

-- pragma translate_off
GENERIC MAP (
	lut_mask => "f5f5",
	operation_mode => "normal",
	output_mode => "comb_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	dataa => \m_CEQ~regout\,
	datac => \CE_IN~combout\,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	combout => \CEQ~0_combout\);

-- Location: LC_X6_Y3_N8
counter_smc : maxv_lcell
-- Equation(s):
-- \counter_smc~regout\ = DFFEAS((!\counter_smc~regout\ & (((\Equal2~0\)))), GLOBAL(\CLK~combout\), VCC, , , , , , )

-- pragma translate_off
GENERIC MAP (
	lut_mask => "5500",
	operation_mode => "normal",
	output_mode => "reg_only",
	register_cascade_mode => "off",
	sum_lutc_input => "datac",
	synch_mode => "off")
-- pragma translate_on
PORT MAP (
	clk => \CLK~combout\,
	dataa => \counter_smc~regout\,
	datad => \Equal2~0\,
	aclr => GND,
	devclrn => ww_devclrn,
	devpor => ww_devpor,
	regout => \counter_smc~regout\);

-- Location: LC_X6_Y3_N9
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

-- Location: PIN_5,	 I/O Standard: 3.3-V LVCMOS,	 Current Strength: 8mA
\CET~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "output")
-- pragma translate_on
PORT MAP (
	datain => \CET~0_combout\,
	oe => VCC,
	padio => ww_CET);

-- Location: PIN_7,	 I/O Standard: 3.3-V LVCMOS,	 Current Strength: 8mA
\CEQ~I\ : maxv_io
-- pragma translate_off
GENERIC MAP (
	operation_mode => "output")
-- pragma translate_on
PORT MAP (
	datain => \CEQ~0_combout\,
	oe => VCC,
	padio => ww_CEQ);

-- Location: PIN_29,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: 16mA
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

-- Location: PIN_28,	 I/O Standard: 3.3-V LVTTL,	 Current Strength: 16mA
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


