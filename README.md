# Seven Segment Indicator Tool

Utility for quickly creating tables symbols for dynamic display on a seven-segment indicator

![screen](https://github.com/user-attachments/assets/ecbcbe19-ccfe-4485-932b-a15204fc0033)

## Usage

* Assign the correspondence of indicator segments (`A`,`B`,`C`,`D`,`E`,`F`,`G`,`dp`) to the pins of a certain microcontroller port

  ![mapping](https://github.com/user-attachments/assets/728b5754-e0e2-4337-b5a5-60b6d9c417ac)

* Select the type of segment indicator (common anode or common cathode)

* Select the number system in which you want to display the result

* If there is no need to connect any indicator segments, then such unused bits of the microcontroller port can be filled with zeros or ones

* The output field displays the value of the microcontroller port corresponding to the current image on the indicator

* The Array button generates a symbol table for the numbers `0..9` or `0..F` as an array
