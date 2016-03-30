# Object-Oriented Programming Exercises

### V1 - Simple C# OOP example/exercise to run in CSharpPad and/or VS

=> Set up a couple of classes, one for basic Animal, and one that manages all the attributes associated with that original class.

The "answer" code should be something like this, adapted from:
http://zetcode.com/lang/csharp/oopi/

```
using System;

public class Animal
{
    public string name;
}

public class AnimalAttributes
{
    static void Main()
    {
        Animal a1 = new Animal();
        a1.name = "Aardvark";

        Animal a2 = new Animal();
        a2.name = "Zebra";

        Console.WriteLine(a1.name);
        Console.WriteLine(a2.name);
    }
}
```

This should be able to run in CSharpPad and/or Visual Studio, but I have not figured out how to make it work properly in either.  Would be nice to set this up as an initial exercise that then gets built on further in DBS exercise for EntityFramework.

Once the basic exercise is accomplished, it can be expanded upon in Exercises V3-Overrides and V4-Overloading.

### Another possibility: Eliza's Sharp Shapes
Eliza had a really good OOP exercise "Sharp Shapes" which was (unfortunately) oriented towards and implemented in WPF.  I'm not sure how easy/hard it would be to assign it without also requiring students to take on WPF also.  Perhaps someone (TA) could implement a WPF viewer that the students could just use w/out programming to it.  [Needs further investigation.]

https://github.com/elizabrock/SharpShapes

Basics included:
 - shapes w/ 3 or more # sides
 - shapes w/ 4 sides included rectangle, square, rhombus, trapezoid, parallelogram
 - shapes w/ different color fills
 - methods for calculating circumference, area of each shape

E.g.
* write tests for rhombus
* inherit from Shape
* to compile:
  * generate stubs
  * leave `throw new not implemented exception`
  * run tests => fail
  * then move other properties/fields from rectangle into rhombus
  * get test of sidesCount() to pass

Many of the key math/geometry details can be found @:  
http://mathworld.wolfram.com/

More details, including implementation notes from Sonda, are in "Orphaned-for-Now" section, EXERCISES folder.
