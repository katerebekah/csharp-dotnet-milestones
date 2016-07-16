# Accessibility Levels

In C#, there are five accessibility levels that can be applied to Classes, Methods, Properties and Data Members:

- public
- private
- protected
- internal
- protected internal

## Public

Classes and Methods that have tagged with the `public` keyword are accessibile without restriction. `public` methods are usable from derived classes (i.e. children) and from outside the inheritance heirarchy (i.e. family).

In some `Automobile.cs`:

```c#
// Base class
class Automobile {

    public string Accelerate() {
        return "zoom!";
    }

}

// Derived class
class Car : Automobile {
}
```

In some `Program.cs`:

```c#
Automobile generic_auto = new Automobile();
Car stella = new Car();

Console.WriteLine("Cars go {0}", stella.Accelerate());
```

## Private

Classes and Methods that have tagged with the `private` keyword are only accessible from within the class where it's defined. This means that private method can not be called from anywhere outside the class, including derived classes (children).

Private methods are intended to be internal functionality. Consider the classes below:


```c#
// Base class
class Automobile {

    public string Accelerate() {
        this.InjectFuel();
        return "zoom";
    }

    public string Break() {
        this.SqueezeBreakPads();
        return "skuuuuuur";
    }

    private string InjectFuel() {
        return "fueling";
    }

    private string SqueezeBreakPads() {
        return "exhale";
    }
}

// Usage Example in a Program.cs file somewhere

Automobile generic_auto = new Automobile();
Console.WriteLine("Automobiles go {0}", generic_auto.Accelerate());

// However, the following line of code does not compile
generic_auto.InjectFuel();
```


```c#
// Given a Derived class, the follow code does not compile
class Car : Automobile {

    public string CallAPrivateParentMethod {
        this.InjectFuel(); // Can not call InjectFuel b/c it's listed as private in the parent class, Automobile
    }
}

// Usage Example in a Program.cs file somewhere

Car stella = new Car();

// Again, the following line of code does not compile
stella.InjectFuel();
```

## Protected

The encapsulation concept is all about defining what data needs to be manipulated, defining the methods that need to be exposed to manipulate the data, and then hiding the internal representation of that data. Our current code encapsulates all of the functionality needed to create a basic animal and make it walk.

However, we hide the implementation of setting the speed of the animal since we want to control how it is set based on the simple algorithm in the `walk()` method.  That's called Information Hiding because no external actor (i.e. code) can access, or set, the walking speed of the animal. It can only specify the number of legs that the animal has.


## Internal

As your code becomes more complex, Abstraction is the process that you, the developer, will go through to provide the most general, and hopefully simplest, way possible. This is done via multiple refactors of your code as complexity slowly works its way in.

With our current code, the `Automobile` class is an abstraction of more specific animals that we create later, such as the Car.


## Protected Internal

## Resources
* https://en.wikipedia.org/wiki/Object-oriented_programming
* https://msdn.microsoft.com/en-us/library/dd460654.aspx
* http://people.cs.aau.dk/~normark/oop-csharp/pdf/all.pdf
* http://people.cs.aau.dk/~normark/oop-csharp/html/notes/theme-index.html
