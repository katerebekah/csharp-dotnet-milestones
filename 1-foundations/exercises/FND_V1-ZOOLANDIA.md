#Zoolandia- Version 1

* Create a new repo in github. Initialize your repo with a README.md file DO NOT click "create repository" yet. Click on the "add .gitignore button" and search for "visual studio." Select "visual studio" and then create your repo. While working in csharppad, keep a copy of your code in sublime and push your code to github on a branch called "version 1."
* Using csharppad.com, create an "Animal" Class. Your Animal class should include a Public string "AnimalName" that acts as a getter and a setter.
* Create a "Species" Class that inherits from the "Animal" Class. The Species class should include a public string "SpeciesName" that acts as a getter and a setter.
* Create three or more different classes for individual animals you want to include in your zoo. Each individual animal class should inherit from "species" and should include a public string with getter and setter for "Noise". You should also include 3-4 more getter/setters of your own choosing. Try and use at least one int (integer) type and one bool (boolean).
``` 
Example:

public class Squirrel: Species {
	public string Noise {get; set;}
	public bool Exotic {get; set;}
	public string FavoriteFood {get; set;}
	public bool FluffyTail {get; set;}
	public int CutenessLevel {get; set;}
}

```

* Create an instance of one of your animal classes.

```
Squirrel nutsy = new Squirrel();

```
* Set AnimalName, SpeciesName, Noise, and the other properties on the instance of  your animal.
```
nutsy.SpeciesName = "Sciuridae";
nutsy.FluffyTail = true;
nutsy.Noise = "tiktiktik";

```
* Use Console.write(); to display the properties of your animal to the console.
```
Console.Write("I have a Squirrel named Nutsy who makes a noise 
that sounds like {0}. I'd rate  his cuteness as a {1}.", nutsy
.Noise, nutsy.CutenessLevel);
```
*Please note, you will type all of the above code into csharppad.com even though it would typically go into different files when using Visual Studio.*

