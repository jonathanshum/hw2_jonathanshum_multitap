# hw2_jonathanshum_multitap
CS 294-98 HW2 Text Entry Device

![alt tag](https://raw.githubusercontent.com/jonathanshum/hw2_jonathanshum_multitap/master/Media/TopDown.jpg)

![alt tag](https://raw.githubusercontent.com/jonathanshum/hw2_jonathanshum_multitap/master/Media/HelloWorld.PNG)

This repository contains designs for a text entry device with a corresponding graphical user interface in Unity to update a virtual keyboard and display entered text. The device and GUI can be easily used in projects designed with Unity.

The text entry technique used in this device is a variant of the direction pad with two additional buttons for entering and deleting entries. This method is commonly used for video games or simple remote control devices. This makes the technique a good candidate for integration with Unity.

The hardware consists of the RedBear Duo and 6 momentary tactile switches. Each switch is connected to a digital pin on the RedBear Duo.

![alt tag](https://raw.githubusercontent.com/jonathanshum/hw2_jonathanshum_multitap/master/Media/TextCircuit.png)

The code written for the RedBear Duo is very simple - each switch triggers a message through serial. These messages are mapped into an action in Unity. For example, the enter button triggers the microcontroller to send the line "Enter" through serial. The graphical interface receives the message and updates they keyboard and text entry field.

The physical device is made with stacked layers of 0.25'' acrylic laser cut to the appropriate dimensions. Different color materials were used to differentiate the buttons from the frame. Magnets were placed between the top and bottom plates for easy access.
