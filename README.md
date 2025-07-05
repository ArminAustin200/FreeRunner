# FreeRunner
The FreeRunner Project aims to replace old glitch Xilinx based glitch chips with a more modern Altera MAXV based CPLD

## CPLD Pinout: (**This pinout applies to the "PROTOTYPE 1.0 PCB" as well as all future revisions**)
<ins>**Main GPIO Pins:**</ins>  
A - Pin 31 (PLL) - PLL Point for Phat consoles  
B - Pin 32 (CLK)  
C - Pin 34 (POST)  
D - Pin 35 (RST) - RST point for Phat consoles  
E - Pin 36 & 37 (RST0 & RST1) - RST point for Slim consoles **Note:** <ins>Slim RST will have 2 GPIO pins dedicated in order to be able to sink enough current</ins>   
F - Pin 30 (PLL) - PLL point for Slim consoles  
    

**Note:** <ins>The oscillator for Corona/Waitsburg/Stingray slim consoles is on Pin 27.</ins>     

<ins>**Debug LED Pins:**</ins>  
DBG0 - Pin 64  
DBG1 - Pin 2  
DBG2 - Pin 1  

<ins>**Multinand GPIO Pins:**</ins>  
CE1 - Pin 3  
CE2 - Pin 4  
CE3 - Pin 5  
CE4 - Pin 7  
CE5 - Pin 9  
CE6 - Pin 10  
CE7 - Pin 11  
CE8 - Pin 12  
CE9 - Pin 13  
CE10 - Pin 18  

SMC_RST - Pin 29  
BUTTON - Pin 28  

**NOTE:** For SMC RST and BTN used for NAND switching, <ins>3.3V GPIO pins are required</ins>  
**ALSO NOTE:** <ins>Multinand GPIO pins are not yet finalized and may be subject to change in the future</ins>    

For more info on pinouts click [here](https://www.intel.com/content/www/us/en/content-details/656843/pin-information-for-the-max-v-5m160z-device-pdf-format.html?wapkw=5m160z) and [here](https://www.intel.com/content/www/us/en/content-details/654129/max-v-device-family-pin-connection-guidelines.html)
