#Zoolandia- Version 2
## Method OverridingS

* Using csharppad.com, create an "Squirrel" Class. Your Squirrel class should include a method for "Transportation." Include the word "virtual" between the word "public" and the return type.

```
Example:

public class Squirrel {
  public string Noise {get; set;}
  public virtual string Transportation() {
    return "scurries";
  }
}

```

* Create a "FlyingSquirrel" Class. This class will inherit from "Squirrel". This time, create an override method for "Transportation" by replacing the word "virtual" with the word "override"

```
public class FlyingSquirrel : Squirrel {
  public bool FearOfCars {get; set;}
  public override string Transportation() {
    return "flies";
  }
}

```
* Create an instance of Squirrel and an instance of FlyingSquirrel

```
Squirrel nutsy = new Squirrel();
FlyingSquirrel batman = new FlyingSquirrel();
```

* Try out the Transportation method on each of  your squirrels.
```
Console.WriteLine(nutsy.Transportation());
Console.WriteLine(batman.Transportation());
```

* Checkout what happens when you try something like:
```
Squirrel mystery = new FlyingSquirrel();
or
FlyingSquirrel superMystery = new Squirrel();
```
* What is allowed? How does your squirrel get around?

*Create a "virtual" method on one of your classes and then create a new class that overrides that method. Remember that an override method need to accept the same number and type of arguments and must have the same name and return type as the method that it overrides.

-----

* Create a constructor function for one (or all!) of your animal(s). the constructor function should set the initial name of all animals of that type to a name of your choosing.

```
public class Panda {
  public string Name {get; set;}
  public Panda() {
    Name = "Po";
  }
}
```
* Check it out!
```
Panda goofy = new Panda();
Console.WriteLine(goofy.Name);

Panda mickey = new Panda();
Console.WriteLine(mickey.Name);
```
* Chanage it up.

```
Panda goofy = new Panda();
Console.WriteLine(goofy.Name);

goofy.Name = "Super Goof";
Console.WriteLine(goofy.Name);
```