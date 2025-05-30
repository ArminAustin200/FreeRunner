# FreeRunner
The FreeRunner Project aims to replace old glitch Xilinx based glitch chips with a more modern Altera MAXV based CPLD

## CPLD Pinout: (**This pinout applies to the "PROTOTYPE 1.0 PCB" as well as all future revisions**)
<ins>**Main GPIO Pins:**</ins>  
A - Pin 31 (PLL)  
B - Pin 32 (CLK)  
C - Pin 34 (POST)  
D - Pin 35 (RST) - RST point for Phat consoles  
E - Pin 36 & 37 (RST0 & RST1) - RST point for Slim consoles **Note:** <ins>Slim RST will have 2 GPIO pins dedicated in order to be able to sink enough current</ins>   
F - Pin 30 (PLL) - PLL point for Slim consoles  

**Note:** <ins>The oscillator for Corona/Waitsburg/Stingray slim consoles is on Pin 27.</ins>     

~~<ins>**Also Note:** For FreeRunner PROTOTYPE 1.0 board, When using on a Slim use A, B, C, D instead of A, B, E, F for RGH1.2. Use pins 35 and 33 instead.</ins>~~     

<ins>**Debug LED Pins:**</ins>  
DBG0 - Pin 64  
DBG1 - Pin 2  
DBG2 - Pin 1  

<ins>**Multinand GPIO Pins:**</ins>  
CES - Pin 42  
CED - Pin 43 - **For further multinand logic:** <ins>pins 44-51 can be used</ins>  
SMC_RST - Pin 29  
BUTTON - Pin 28  

**NOTE:** For SMC RST and BTN used for NAND switching, <ins>3.3V GPIO pins are required</ins>  
**ALSO NOTE:** <ins>Multinand GPIO pins are not yet finalized and may be subject to change in the future</ins>    

For more info on pinouts click [here](https://www.intel.com/content/www/us/en/content-details/656843/pin-information-for-the-max-v-5m160z-device-pdf-format.html?wapkw=5m160z) and [here](https://www.intel.com/content/www/us/en/content-details/654129/max-v-device-family-pin-connection-guidelines.html)
