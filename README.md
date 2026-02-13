# FreeRunner
The FreeRunner Project aims to replace Xilinx CoolRunner/CoolRunner II based chips with a more modern Altera MAXV CPLD replacement
<img width="1724" height="930" alt="Image 2" src="https://github.com/user-attachments/assets/9801cd3e-1c2e-4fed-be09-7360d1594040" />
<img width="1724" height="930" alt="Image 1" src="https://github.com/user-attachments/assets/c770987f-cb94-438f-b1ea-2c8a5dadad64" />
<img width="1724" height="930" alt="Image 4" src="https://github.com/user-attachments/assets/cc59b285-4188-48e8-a497-b718ecacf9c9" />
<img width="1724" height="930" alt="Image 3" src="https://github.com/user-attachments/assets/ae253be8-ab1b-4d97-8e48-e27319123287" />

## FreeRunner CPLD Pinout:
<ins>**Main GPIO Pins:**</ins>  
A - Pin 31 (PLL) - PLL/EXT_CLK Point for Phat consoles  
B - Pin 32 (CLK)  
C - Pin 34 (POST)  
D - Pin 35 (RST) - RST point for Phat consoles  
E - Pin 36 & 37 (RST0 & RST1) - RST point for Slim consoles **Note:** <ins>Slim RST will have 2 GPIO pins dedicated in order to sink enough current</ins>   
F - Pin 30 (PLL) - PLL point for Slim consoles/GPIO Point for MUFAS  
    

**Note:** <ins>The oscillator for Corona/Waitsburg/Stingray slim consoles is on Pin 27.</ins>     

<ins>**Debug LED Pins:**</ins>  
DBG0 - Pin 64  
DBG1 - Pin 2  
DBG2 - Pin 1  

<ins>**Multinand GPIO Pins:**</ins>  
TP10 - Pin 3  
TP9 - Pin 4  
TP8 - Pin 5  
TP7 - Pin 7  
TP6 - Pin 9  
TP5 - Pin 10  
TP4 - Pin 11  
TP3 - Pin 12  
TP2 - Pin 13  
TP1 - Pin 18  


**Note:** <ins>The total number of available CE pads may change for final release PCB.</ins>     


SMC_RST - Pin 29  
BUTTON - Pin 28  

**NOTE:** For SMC RST and BTN used for NAND switching, <ins>3.3V GPIO pins are required</ins>  
**ALSO NOTE:** <ins>Multinand GPIO pins are not yet finalized and may be subject to change in the future</ins>    

For more info on pinouts click [here](https://www.intel.com/content/www/us/en/content-details/656843/pin-information-for-the-max-v-5m160z-device-pdf-format.html?wapkw=5m160z) and [here](https://www.intel.com/content/www/us/en/content-details/654129/max-v-device-family-pin-connection-guidelines.html)
