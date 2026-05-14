# Character Counter & String Analysis Tool

A beginner-friendly VB.NET console application that analyzes an entered string and counts:

- Alphabets
- Digits
- Other special characters

This project demonstrates string traversal, character classification, and conditional logic using VB.NET.

---

## Features

- Reads user input from the console
- Counts alphabetic characters (case-neutral)
- Counts numeric digits
- Counts symbols, spaces, and special characters
- Uses reusable functions for clean structure
- Displays formatted output

---

## Tech Stack

- VB.NET
- .NET 8
- Console Application

---

## How It Works

The program:

1. Accepts a string from the user
2. Loops through every character
3. Uses built-in `Char` methods:
   - `Char.IsLetter()`
   - `Char.IsDigit()`
4. Categorizes characters into:
   - Alphabets
   - Digits
   - Other characters
5. Displays the totals

---

## Example Output

```text
Enter a string: Hello123!

Alphabets: 5 | Digits: 3 | Other Characters: 1
