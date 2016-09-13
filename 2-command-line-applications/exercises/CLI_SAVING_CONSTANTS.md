# Saving Constants

For this exercise you will create a CLI application that will Read, Delete and Create entries to a database. 

The goal of this project is to help students learn TDD with the Entity Framework and Moq. The students will be creating a trivial ERD and Command Line Application with this project.

This solution contains:

1. Console Project
2. Unit Test Project


## Rules

- Create a very simple ERD representing the Model for this exercise
- Create a model and matching migration for saving
- Implement the Repository Pattern
- There should be Unit Tests on all classes and methods you create.
- Your solution should have at least 2 total projects. Unit Tests should be in it's own project.
- This is an OOP focused class. Therefore, there will be classes. Your `Program` class and `Main` method should only be responsible for receiving user input and printing output.
- If a user submits an incomplete command or expression, the application should **not** attempt to evaluate it but print out a useful message.

## Overview of how it should work

Starting your console application should create a prompt that looks like:

```sh
>> 
```

The user will enter expressions or commands that do work on a backend database.

## Features

### Commands

Your application should accept the following commands:

- `quit` and `exit` - exits the program
- `lastq` - prints the last entered command or expression

### Constant Expressions

Constants have one character lenght names that holds a positive or negative integer. Your application should support the following expressions and commands:

- `a = 4` - creates an entry in the database where `a` is `4`
- `clear a`, `remove a` and `delete a` - removes the saved entry for `a` from the database
- `clear all`, `remove all` and `delete all` - removes all saved entries from the database


```sh
>> x = 3
   = saved 'x' as '3'
>> x
   = 3
>> x = 4
   = Error! 'x' is already defined!
>> clear x
   = 'x' is now free!
>> x = -4
   = saved 'x' as '-4'
```
