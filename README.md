# VB.NET Algorithms and Data Structures

A collection of beginner-friendly VB.NET console programs covering algorithms, data structures, object-oriented programming, recursion, calculators, and string manipulation practice.

## Live Links

- GitHub Repository: https://github.com/fazal305/vbnet-algorithms-and-data-structures
- Live Demo: Not applicable. This repository contains console-based VB.NET learning projects.

## Overview

This repository collects small Visual Basic .NET exercises built while practicing programming fundamentals. Each folder focuses on one topic, making the repo useful as a revision archive, learning reference, and early programming portfolio project.

The code is intentionally simple and beginner-readable. The goal is to show core logic clearly rather than hide it behind advanced tooling.

## Features

- Linear search and binary search examples
- Bubble sort and insertion sort examples
- Stack, queue, linked list, hashtable, dictionary, and binary tree practice
- Recursion and recursive procedure examples
- Calculator and scientific calculator console programs
- String manipulation exercises
- Student and contact data model examples
- Small real-world practice tasks such as discounts, grades, meals count, sensor readings, and customer points

## Tech Stack

- Visual Basic .NET
- .NET 8
- Visual Studio
- Console applications

## Folder Structure

```text
vbnet-algorithms-and-data-structures/
  README.md
  LICENSE
  Queue.sln
  Queue.vbproj
  code in vs for number of jobs.vb
  binary-search/
  binary-tree/
  bubble-sort/
  calculator/
  classes-for-lessons/
  classes-for-library-renting-system/
  customer-point-card/
  dictionary/
  discount-on-goods-more-than-a-limit/
  grade-calculator/
  hashtable/
  linear-search/
  linked-list/
  loop-for-readings-in-sensor-and-warnings/
  procedure-mealscount/
  queue-implementation/
  recursion/
  recursive-procedure/
  scientific-calculator/
  stacks/
  string-manipulation/
  student-data-model/

Getting Started
Clone the repository.
Open the folder for the topic you want to run.
Open the .sln or .vbproj file in Visual Studio.
Build and run the console application.
You can also run a project from PowerShell if the .NET SDK is installed:
dotnet run --project "binary-search\binary search.vbproj"
Architecture Notes
This repository is organized as a learning collection rather than one large application. Most folders are independent console projects with their own .vbproj or .sln file.
The root Queue.vbproj is limited to the root job-priority example so it does not accidentally compile every nested practice file as one application.
Accessibility
These are console-based projects, so browser accessibility does not apply. The examples use simple console output and clear naming to make the logic easier to follow.
Performance
The programs are small educational examples. Performance is discussed through algorithm choice:
Binary search demonstrates faster lookup on sorted arrays.
Bubble sort and insertion sort are included for learning, not large datasets.
Queue and stack examples use fixed-size array storage for clear beginner-level logic.
Lessons Learned
How common algorithms work step by step
How arrays can model queues, stacks, and paired data
How recursion breaks a problem into smaller calls
How classes and user-defined types organize related data
How small console programs can build strong programming fundamentals
Future Improvements
Add a short explanation file for each major algorithm
Add screenshots of console output
Add a simple test plan for the main examples
Standardize folder names and project names further
Add time complexity notes for search and sorting examples
Convert selected examples into a larger revision guide
