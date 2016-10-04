# Zoolandia - Creating Your Zoo

## Setup

```bash
cd ~/workspace/zoolandia
git checkout -b version-4
```

## Instructions

1. Decide on at least 15 species that you would like to include in your zoo and create a class for each species. 
1. Each species should inherit from the appropriate genus (in a class that you create), and each genus should inherit from the `Animal` class.

    ```
    // Base animal class
    public class Animal 
    {
    	// add properties and methods
    }

    // Genus class, inherits from animal class
    public class Equus : Animal 
    {
    	//add properties and methods
    }

    // Species class, inherits from the corresponding genus class
    public class Quagga : Equus
    {
        string commonName = "Zebra";
    	string scientificName = "Equus quagga";
    	// add more properties and methods
    }
    ```
1. Once you've created all of your species, give them some methods and properties. Include several methods on your Animal and/or genus classes that can be overridden and then override them in your species classes.
1. Create some overloaded methods on some of your species (or genus) classes.
