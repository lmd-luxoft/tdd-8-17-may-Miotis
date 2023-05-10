[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/SDJT-yFW)

#Requirement

## Initial
Create a simple String calculator with a method int Add(string numbers)
The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0)
for example "" or "1" or "1,2"
Start with the simplest test case of an empty string and move to 1 and 2 numbers
Remember to solve things as simply as possible so that you force yourself
to write tests you did not think about
Remember to refactor after each passing test
## Extended
Allow the Add method to handle new lines between numbers (instead of commas)
- the following input is ok:  “1\n2,3”  (will equal 6)
- the following input is NOT ok:  “1,\n”
