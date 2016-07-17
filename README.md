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

* The sentenceArray does not split words attached to characters if there is no space between them. Code cannot count instances of a word in the sentence if there is a character directly before and after the word.

## Specifications

The program should ... | Example Input | Example Output
----- | ----- | ----- | -----
Return a value of 0 when the word is not in the sentence | Word: dog, Sentence: We love dogs | "Your word appears 0 time(s) in your sentence!"
Return a value of 1 when the word appears in the sentence once | Word: "dogs", Sentence: "We love dogs" | "Your word appears 1 time(s) in your sentence!"
Be letter sensitive and only count the exact instance of the word, not similar words too | Word: "dogs", Sentence: "My dog is scared of other dogs" | "Your word appears 1 time(s) in your sentence!"
Disregard characters directly after the word in a sentence | Word: "dogs", Sentence: "Our dogs, Rusty and Willow, are dogs. We love dogs! Do you love dogs? We have two other dogs- Apple and Tango. Our dogs love to play with other dogs; the dogs: play fetch, and run around." | "Your word appears 8 time(s) in your sentence!"
Disregard the "-" character directly before the word in a sentence | Word: "dog", Sentence: "We love dogs -dog" | "Your word appears 8 time(s) in your sentence!"

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

Git Hub Repository: https://github.com/pullashradha/WordMatches

## License

*This software is licensed under the Microsoft ASP.NET license.*

Copyright (c) 2016 Shradha Pulla
