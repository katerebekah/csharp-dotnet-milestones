#Zoolandia- Version 2
## Method Overriding

* Using csharppad.com, create an "Squirrel" Class. Your Squirrel class should include a method for "NumberOfLegs." Include the word "virtual" between the word "public" and the return type.

```
Example:

public class Squirrel {
  public string Noise {get; set;}
  public virtual int NumberOfLegs(int legs) {
    return legs;
  }
}

```

* Create a "CrippledSquirrel" Class. This class will inherit from "Squirrel". This time, create an override method for "NumberOfLegs" by replacing the word "virtual" with the word "override"

```
public class CrippledSquirrel : Squirrel {
  public bool FearOfCars {get; set;}
  public override int NumberOfLegs(int legs) {
    return legs - 1;
  }
}

```
* Create an instance of Squirrel and an instance of CrippedSquirrel

```
Squirrel nutsy = new Squirrel();
CrippledSquirrel pegleg = new CrippledSquirrel();
```

* Try out the NumberOfLegs method on each of  your squirrels.
```
Console.WriteLine(nutsy.NumberOfLegs(2));
Console.WriteLine(pegleg.NumberOfLegs(2));
```

* Checkout what happens when you try something like:
```
Squirrel mystery = new CrippledSquirrel();
or
CrippledSquirrel superMystery = new Squirrel();
```
* What is allowed? How many legs does your squirrel have?
