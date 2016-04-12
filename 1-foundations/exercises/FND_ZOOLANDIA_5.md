# Zoolandia - Relationships, Multiple Files, and Namespaces

## Setup

```bash
cd ~/workspace/zoolandia
git checkout -b version-5
```

## Instructions

You are going to start using Visual Studio to break up your code into different files, directories, and namspaces.

## One Class, One File

1. Create a new solution in Visual Studio.
1. Open up your `Zoolandia.cs` file where you've been saving all of your classes so far, and paste all of them into the `namespace` object in `Program.cs`.
1. Each class in C# should live in its own file. Your job is to create a new file for each class that you have defined so far. You can either:
  1. Right click the Zoolandia project, select *Add* and then choose *Class*. In the dialog box that appears, choose *Class* and give the file the same name as the class it will contain. For example, if the class' name is `Squirrel`, then name the file *Squirrel.cs*.
  1. Use the ctrl+shift+c keyboard shortcut.

## Sub-directories

Creating sub-directories in your project is a way to accomplish code management at the physical file system, so that you don't end up with dozens of classes all in same level in your Solution Explorer.

1. Right click your project in the Solution Explorer and add a folder named *Animals*.
1. Now you can just click and drag all of your animal species classes into that new folder in Solution Explorer.
1. Create some instances of your species in the `Main()` method, add some `Console.WriteLine()` statements to output some properties, and compile your project.
1. Run your project and verify that it works as expected.

## Namespaces

Using namespaces is another way to organize your classes at the code level. Think of them as simple buckets in which related classes exist.

1. Open each of the class files in the *Animals* directory and change the namespace to `Zoolandia.Animals`.
1. Once that's done, look in the `Main()` method again you'll see that Visual Studio has red squiggles beneath the class names that you created instances of. This is because all of those classes now exist in a different namespace.
1. To use that new namespace in this namespace (just Zoolandia), you use the `using` keyword. Add `using Zoolandia.Animals` at the top of *Program.cs*.
1. Compile and run your program.

## Refactoring

Is a species a genus?

Is a genus an animal?

Isn't species a *property* of an animal instead?

What if the genus was a property of the species?

Read the [inheritance, composition, and aggregation](../resources/FND_INHERIT_COMPOSE_AGGREGATE.md) file again and refactor your code to have appropriate `is-a`, `part-of`, and `has-a` relationships.