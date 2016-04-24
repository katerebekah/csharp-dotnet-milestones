# Bag o' Loot

This exercises will help with your comprehension of [command line parameters](https://msdn.microsoft.com/en-us/library/aa288457(v=vs.71).aspx).

## Setup

1. Create a new Visual Studio console solution named *BagOLoot*.
1. Create a matching project in your solution for unit tests (i.e. *BagOLootTests*).

## Instructions

You have an acquaintance whose job is to, once a year, delivery presents to the best kids around the world. They have a problem, though. There are so many good boys and girls in the world now, that their old paper accounting systems just don't cut it anymore. They want you to write a program that will let them do the following tasks.

1. Add a toy to the bag o' loot, and label it with the child's name who will receive it. 

    ```bash
    BagOLoot.exe add kite suzy
    BagOLoot.exe add baseball michael
    ```

1. Remove a toy from the bag o' loot in case a child's status changes before delivery starts.

    ```bash
    BagOLoot.exe remove suzy kite
    BagOLoot.exe remove michael baseball
    ```

1. Produce a list of children currently receiving presents.

    ```bash
    BagOLoot.exe ls
    ```

1. Produce a list of toys in the bag o' loot for a specific child.

    ```bash
    BagOLoot.exe ls suzy
    ```

## Requirements

**Write a test before you write implementation code**

```cs
/*
  This is only an example. If I find this code in your project
  I will make you go back and delete it and write your own test.
 */
[TestMethod]
public void ToysForChildCanBeAddedToBag ()
{
    Bag lootBag = new Bag();
    lootBag.Add("kite", "suzy");
    Assert.AreEqual("kite", lootBag.ChildItems("suzy").First());
}
```

1. Items can be added to bag.
1. Items can be removed from bag, per child only. Removing `ball` from the bag should not be allowed. A child's name must be specified.
1. Must be able to list all children who are getting a toy.
1. Must be able to list all toys for a given child's name.

## Bonus Requirements

1. Create a returnList Method on your class
1. Create a non-letter "Easter egg" character that will display the current list of successfully input letters (but will not add itself to the list!)
