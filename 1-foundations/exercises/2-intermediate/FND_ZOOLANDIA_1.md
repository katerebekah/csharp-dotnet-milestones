# Zoolandia 1 - Defining Your Favorite Species

## Setup

Create a new workspace sub-directory in your Windows home directory, initialize it as a git repo and create a boilerplate README.

```bash
cd && mkdir -p workspace/zoolandia && cd $_
git init
echo `# Zoolandia` > README.md
```

Next, create a new repository on Github, copy the git URL and add it as a remote origin. Then commit and push your README. Lastly, create a branch for this first exercise.

```bash
git remote add origin {paste URL here}
git add .
git commit -m "Initial commit"
git push origin master
git checkout -b version-1
```

Next, initialize a new .NET Core project using the CLI or the ASP.NET Generator

```bash
dotnet new
touch .gitignore
```

Here is the .NET Core .gitignore: https://github.com/dotnet/core/blob/master/.gitignore

or

```
yo aspnet
```

and follow the instructions for a Console Application.

# Instructions

## Sub-directories

Creating sub-directories in your project is a way to accomplish code management at the physical file system, so that you don't end up with dozens of classes all in same level in your project.

1. Create an `Animals` subdirectory in your project. All of your animal-related classes will be created that directory.

## Namespaces

Using namespaces is another way to organize your classes at the code level. Think of them as simple buckets in which related classes exist.

1. Ensure that each of your animal classes belong to the `Zoolandia.Animals` namespace.

## Making Animals

1. Create your first C# class - the Animal class. Create some simple properties and methods on Animal. You are going to create some derived classes that inherit from Animal, so make sure that the properties/methods you add are general to **all** Animals (e.g. name, height, weight, etc).

    ##### Example property/method definition

    ```cs
    namespace Zoolandia.Animals
    {
        class Animal
        {
            public string name { get; set; }

            public void sleep ()
            {
                Console.WriteLine("ZZzzzzzzz...");
            }
        }
    }
    ```

1. After you are happy with your Animal class, create a derived class that defines a particular species of Animal. Create some properties that apply **only** to that species.

    ```cs
    namespace Zoolandia.Animals
    {
        // The species for a Red Pana
        class AilurusFulgens : Animal
        {
            // Define simple properties for a Red Panda
        }
    }
    ```

1. Create three more classes for species of animals of your choosing. Wikipedia is a great tool to discover species names. Make sure you use a mix of native C# types for your properties.
1. Create some instances of your species.
1. Assign values to the properties of each.
1. Use `Console.WriteLine();` to output the property values of your animals to the console.

    ```cs
    // Example
    Console.WriteLine($"I have a Squirrel named {squirrel.name} who makes a 
    noise that sounds like {squirrel.signatureNoise}. I'd rate its cuteness 
    at {squirrel.cutenessFactor}.");
    ```

## Submit to Github

Once you are happy with your code, make sure that you commit & push it.
