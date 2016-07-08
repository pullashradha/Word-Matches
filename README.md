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
Input the word and sentence/phrase as separate strings | Word: dog, Sentence: We love dogs | string wordInput = "dog", string sentenceInput = "We love dogs" | Simple input values that only show one instance of repetition for the inputted word
Split sentence string into elements for words in between spaces | Sentence Input: "We love dogs" | Sentence Array: "We", "love", "dogs" | Simple three word sentence that doesn't have any punctuation or chars
Loop through each element in the sentenceArray to count the number of elements it has | Sentence: "We love dogs" | arrayElementNumbers = 3 | Word only appears once in the sentence, very short sentence
Loop through sentenceArray and count the number of times the wordInput appears | Sentence: "We love dogs, and dogs love us, because dogs are cool!", Word: "dogs" | wordRepeatedNumber = 3 | Longer full sentence (with punctuation) with more instances of word, ensures that the method is counting the actual words and instances of the word, and not irrelevant characters

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
