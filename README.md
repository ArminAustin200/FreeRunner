# FreeRunner
The FreeRunner Project aims to replace old glitch Xilinx based glitch chips with a more modern Altera MAXV based CPLD

## CPLD Pinout: (**This pinout applies to the "PROTOTYPE 1.0 PCB" as well as all future revisions**)
A - Pin 31 (PLL)  
B - Pin 32 (CLK)  
C - Pin 34 (POST)  
D - Pin 35 (RST0) - RST point for Phat consoles  
E - Pin 36 (RST1) - RST point for Slim consoles  
F - Pin 37 (PLL) - PLL point for Slim consoles  

DBG0 - Pin 64  
DBG1 - Pin 2  
DBG2 - Pin 1  
**NOTE:** For SMC RST and BTN used for NAND switching, <ins>3.3V GPIO pins are required</ins>

##Dual NAND Pinout (**Will be present on final board revision**)
CES - Pin 42  
CED - Pin 43  
**For further multinand logic, pins 44-48 can be used**

SMC_RST - Pin 29
BUTTON - Pin 30  

For more info on pinouts click [here](https://www.intel.com/content/www/us/en/content-details/656843/pin-information-for-the-max-v-5m160z-device-pdf-format.html?wapkw=5m160z)
