#Zoolandia- Version 3.5
## Creating your zoo

* Create a new repo in github. Initialize your repo with a README.md file DO NOT click "create repository" yet. Click on the "add .gitignore button" and search for "visual studio." Select "visual studio" and then create your repo. While working in csharppad, keep a copy of your code in sublime and push your code to github on a branch called "version 1." (if you've already done this, don't worry about doing it again)
* Lovingly let go of any zoolanda code you've written so far. It was very useful practice, but you don't need to keep it forever.
* Decide on 15+ species that you would like to include in your zoo and create a class for each species. 
* Each species should inherit from the appropriate genus (in a class that you create), and each genus should inherit from a class called "Animal."
```
public class Animal 
{
	// add properties and methods
}

public class Equus : Animal 
{
	//add properties and methods
}

public class Quagga : Equus
{
	string NormalName = "Zebra";
	// add more properties and methods
}
```
* Once you've created all of your species, give them some methods and properties. Include several methods on your Animal and/or genus classes that can be overridden and then override them in your species classes.
* Create some overloaded methods on some of your species (or genus) classes.