# Accessibility Levels

In C#, there are five accessibility levels that can be applied to Classes, Methods, Properties and Data Members:

- public
- private
- protected
- internal
- protected internal

## Public

Classes and Methods that have tagged with the `public` keyword are accessibile without restriction. `public` methods are usable from derived classes (i.e. children) and from outside the inheritance heirarchy (i.e. family).

In some `Animal.cs`:

```c#
// Base class
class Animal {

    public string walk() {
        return "walk-walk-walking";
    }
}

// Derived class
class Lizard : Animal {
}
```

In some `Program.cs`:

```c#
Animal generic_animal = new Animal();
Lizard larry = new Lizard();

Console.WriteLine("A lizard is {0}", larry.walk());
```

## Private

Classes and Methods that have tagged with the `private` keyword are only accessible from within the containing class.


```c#
// Base class
class Animal {
    // Simple properties
    public double speed { get; set; }
    public string species { get; set; }
    public int legs { get; set; }


    // Public method that can be redefined by derived classes
    public virtual void walk () {
        Console.WriteLine("Animal class walk method");
        speed = speed + (0.1 * legs);
    }
}

// Derived class
class Lizard : Animal {
    // Adding additional properties to what is inherited from Animal
    public string scaleColor { get; set; }
    public bool camouflage { get; set; }

    // Redefining the base class implementation
    public override void walk () {
        Console.WriteLine("Lizard class walk method");
        speed = speed + (0.2 * legs);
    }
}

// Create a Lizard
Lizard larry = new Lizard();
larry.legs = 4;
larry.scaleColor = "Brown";
larry.camouflage = false;
larry.walk();

Console.WriteLine("A {0} lizard moving at {1} m/s", larry.scaleColor, larry.speed);

// Create an Animal
Animal andy = new Animal();
andy.legs = 4;
andy.walk();

Console.WriteLine("An animal moving at {0} m/s", andy.speed);

```

## Protected

The encapsulation concept is all about defining what data needs to be manipulated, defining the methods that need to be exposed to manipulate the data, and then hiding the internal representation of that data. Our current code encapsulates all of the functionality needed to create a basic animal and make it walk.

However, we hide the implementation of setting the speed of the animal since we want to control how it is set based on the simple algorithm in the `walk()` method.  That's called Information Hiding because no external actor (i.e. code) can access, or set, the walking speed of the animal. It can only specify the number of legs that the animal has.


## Internal

As your code becomes more complex, Abstraction is the process that you, the developer, will go through to provide the most general, and hopefully simplest, way possible. This is done via multiple refactors of your code as complexity slowly works its way in.

With our current code, the `Animal` class is an abstraction of more specific animals that we create later, such as the Lizard.


## Protected Internal

## Resources
* https://en.wikipedia.org/wiki/Object-oriented_programming
* https://msdn.microsoft.com/en-us/library/dd460654.aspx
* http://people.cs.aau.dk/~normark/oop-csharp/pdf/all.pdf
* http://people.cs.aau.dk/~normark/oop-csharp/html/notes/theme-index.html
