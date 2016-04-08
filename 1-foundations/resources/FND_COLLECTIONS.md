# Collections and Iteration

In JavaScript, you stored a collection objects in one of two constructs:

1. Array
1. Object

In C#, you can store a collection of objects in a larger variety of constructs which are in the `System.Collections.Generic` assembly. I'm only showing code examples for the first two types, since they are the most commonly used. You can read the MSDN docs to learn about the rest.

You can use the `foreach` keyword to iterate over most collections, but collections that are Queues or Stacks are different.

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