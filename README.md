# Word Matches Webpage

#### Behavior-driven Development with C# Independent Project for Epicodus, 07/08/2016

#### By Shradha Pulla

## Description

This program will tell the user how many times a word appears in a phrase or sentence. The user can input a specific word along with a phrase/sentence to evaluate, and the resulting number is displayed on a separate page.

## Setup/Installation Requirements

This program can only be accessed on a PC with Windows 10, and with git and atom installed.

* Clone this repository
* Type following command into the Windows PowerShell > dnu restore
* Type following command into PowerShell > dnx kestrel
* Open Chrome and type in the following address: "localhost:5004"

## Known Bugs

No known bugs.

## Specifications

The program should ... | Example Input | Example Output | Ex Input Reasoning
----- | ----- | ----- | -----
Input the word and sentence/phrase as separate strings | Word: dog, Sentence: I love dogs | string wordInput = "dog", string phraseInput = "I love dogs" | Reasoning 1
Split phrase string into elements for words in between spaces | String Input: "I love dogs" | String Array: "I", "love", "dogs" | Reasoning 2
Loop through each element in the string array to search for elements that exactly match the word input, and add the number into an int variable | String: "I", "love", "dogs" and search for "dogs" | wordRepeatedNumber = 1 | Reasoning 3
Display number of times word is repeated in phrase on the result page | Index Page: I love dogs search for dogs | Result Page: 1 | Reasoning 4
Input and display word and sentence/phrase from index page on to result page along with number of repeats | Index Page: I love dogs search for dogs | Result Page: dogs is repeated 1 time in the phrase- I love dogs | Reasoning 5

## Future Features

HTML | CSS | C#
----- | ----- | -----
----- | ----- | Underline all instances of the word repeated in the sentence on the Results page for easy viewing

## Support and Contact Details

Contact Epicodus for support in running this program.

## Technologies Used

* HTML
* CSS
* Bootstrap
* C#

## Links

Git Hub Repository: https://github.com/pullashradha/Word-Matches

## License

*This software is licensed under the Microsoft ASP.NET license.*

Copyright (c) 2016 Shradha Pulla
