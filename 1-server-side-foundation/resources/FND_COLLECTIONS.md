# Collections and Iteration

C#, provides you with a variety of contructs that allow you to store and access data with respect to traditional Data Structures. Below are the main types of collections/ways to store data:

- Array
- List
- Stack
- Queue
- Dictionary

Each of the types in the bulleted list above are implemented as `generics`. Generic data structures, allow you to declare a container specifying what objects it will hold.

The `List` and `Array` classes implement the IEnumerable interface. IEnumerable defines a blueprint that allows a developer to use the `foreach` keyword to cycle through all the elements.

### List

```c#
using System.Collections.Generic // Namespace containing data structures


// Somewhere in a Program.cs

// Creates an instance of a List type that will only contain integers.
// Starts off as empty.
List<int> myListOfIntegers = new List<int>();

// You can add items to this list via the `Add` method.
myListOfIntegers.Add(77);
myListOfIntegers.Add(108);
```

### Array


### Dictionary

1. [Dictionary](https://msdn.microsoft.com/en-us/library/xfhwa508.aspx) - Which is a collection of key/value pairs, just like an object in JavaScript. The big difference is that the key can be any type. One thing to remember is that you can't add the same key to a Dictionary more than once.
    ```cs
    using System.Collections.Generic;

    Dictionary<int, string> numberTable = new Dictionary<int, string>();

    numberTable.Add(1, "One");
    numberTable.Add(2, "Two");
    numberTable.Add(3, "Three");
    numberTable.Add(4, "Four");
    numberTable.Add(5, "Five");

    foreach (KeyValuePair<int, string> number in numberTable)
    {
        Console.WriteLine("{0} equals {1}", number.Key, number.Value);
    }

    /*
    The following code generates the exception:
        An item with the same key has already been added.
     */
    numberTable.Add(5, "Cinco");
    ```
1. [List](https://msdn.microsoft.com/en-us/library/6sh2ey19.aspx) - A List contains *n* items of the same type.
    ```cs
    using System.Collections.Generic;

    List<double> decimals = new List<double>();
    decimals.Add(1.3);
    decimals.Add(8.2);
    decimals.Add(0.4);
    decimals.Add(12.1);

    foreach (double d in decimals)
    {
        Console.WriteLine(d);
    }
    ```
1. [Queue](https://msdn.microsoft.com/en-us/library/7977ey2c.aspx) - Just like a line at the post office. First in line is also the first one out.
1. [Stack](https://msdn.microsoft.com/en-us/library/3278tedw.aspx) - The reverse of a Queue. Like building up a big stack of Legos, the last one on also is going to be the first one taken off.
1. [SortedList](https://msdn.microsoft.com/en-us/library/ms132319.aspx) - Represents a collection of key/value pairs that are sorted by key.
