# unity-controller-test
unity test project to debug xbox 360 and xbox one usb controller joystick inputs



xbox one:

| human input     | math axis | unity mapped axis | values
| --------------- | :-------: | ----------------- | -----
| left stick x    | X         | axis 3            | -1 .. 0 .. 1
| left sitck y    | Y         | axis 4            | -1 .. 0 .. 1 (inverted)
| right stick x   | X         | axis 5            | -1 .. 0 .. 1
| right stick y   | Y         | axis 6            | -1 .. 0 .. 1
| left trigger x  | X         | axis 1            | -1 or 1 
| right trigger y | Y         | axis 2            | -1 or 1 


driver for osx

https://github.com/FranticRain/Xone-OSX
