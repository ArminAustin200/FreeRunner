10/14/2023

Some horribly compiled software by Cheez
Proof of concept for flashing Xilink based glitch chips with a Pico

NOTE: I did not create any of the software you see in this pack. This is
simply a pack of pre-compiled software for testing glitch chip flashing with a Pico

NOTE: I suck as cross-compiling software so this build of UrJtag
only supports LibUSB 1.0. If you are looking to use this with other
cables/adapters that do not support LibUSB it will not work.
This has only been tested with DirtyJtag.

--v0.01--

- First release
- DirtyJtag UF2 compiled from Pico-DirtyJtag v1.04 : https://github.com/phdussud/pico-dirtyJtag
- UrJtag compiled from version 2021.03: https://sourceforge.net/projects/urjtag/files/
- Currently only has LibUSB 1.0 support

-- Uasge -- 

1. Flash pico-dirtyJtag.uf2 to your Pico
2. Launch Zadig and install libusb-win32
3. Connect your Pico to your glitch chip following the pinout in detailed-pinout.png
4. Launch jtagDirtyPico.exe
5. Type the following commands

- cable DirtyJtag
- detect
(Ensure device ID, manufacturer, part, and all other info is shown)
- svf c:\\PATH-TO-SVF-FILE
(Must use \\ in path)

6. Some TDO mismatch errors will appear. In my experience this can be ignored but I have only done limited testing
