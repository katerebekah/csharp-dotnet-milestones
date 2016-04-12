#Zoolandia- Version 3
## Method Overloading

* Choose your favorite animal class from the previous zoolandia versions and create an instance of your animal.
```
public class Squirrel {
	public string Noise {get; set;}
	public bool Exotic {get; set;}
	public string FavoriteFood {get; set;}
	public bool FluffyTail {get; set;}
	public int CutenessLevel {get; set;}
}

Squirrel spiderman = new Squirrel();
```
* Now add a constructor method to your animal that takes a single string as an argument. (constructor methods go at the top of your class)
```
public class Squirrel {
	public string Noise {get; set;}
	public bool Exotic {get; set;}
	public string FavoriteFood {get; set;}
	public bool FluffyTail {get; set;}
	public int CutenessLevel {get; set;}
	public Squirrel (string sound) {
		Noise = sound;
	}
}
```
* Try to create an instance of your animal like so:
```
Squirrel superman = new Squirrel();
```
* Does it work? What does the error message say?
* Now try something like:
```
Squirrel superman = new Squirrel("tiktiktik");

Console.Write(superman.Noise);
```
*Now, add ANOTHER constructor method to your animal that accepts an integer as an argument and create an animal by passing it an integer.

```
public class Squirrel {
	public string Noise {get; set;}
	public bool Exotic {get; set;}
	public string FavoriteFood {get; set;}
	public bool FluffyTail {get; set;}
	public int CutenessLevel {get; set;}
	public Squirrel (string sound) {
		Noise = sound;
	}
	public Squirrel (int adorable) {
		CutenessLevel = adorable;
	}
}

Squirrel hulk = new Squirrel(2);

Console.Write(hulk.CutenessLevel);
```
* Add ONE MORE constructor method! This method will accept both an integer and a string as arguments.
```
public class Squirrel {
	public string Noise {get; set;}
	public bool Exotic {get; set;}
	public string FavoriteFood {get; set;}
	public bool FluffyTail {get; set;}
	public int CutenessLevel {get; set;}
	public Squirrel (string sound) {
		Noise = sound;
	}
	public Squirrel (int adorable) {
		CutenessLevel = adorable;
	}
	public Squirrel (int adorable, string sound) {
		CutenessLevel = adorable;
		Noise = sound;
	}
}

Squirrel strongBad = new Squirrel(5, "The Cheat!");

Console.Write("I have a Squirrel named strongBad who makes a noise 
that sounds like {0}. I'd rate  his cuteness as a {1}.", strongBad
.Noise, strongBad.CutenessLevel);
```
* You can use any of the constsructor functions you've created and C# magically figures out which one to use based on the number and type of arguments you pass to it.
```
public class Squirrel {
	public string Noise {get; set;}
	public bool Exotic {get; set;}
	public string FavoriteFood {get; set;}
	public bool FluffyTail {get; set;}
	public int CutenessLevel {get; set;}
	public Squirrel (string sound) {
		Noise = sound;
	}
	public Squirrel (int adorable) {
		CutenessLevel = adorable;
	}
	public Squirrel (int adorable, string sound) {
		CutenessLevel = adorable;
		Noise = sound;
	}
}

Squirrel adamWest = new Squirrel("bam!");
Squirrel powderPuff = new Squirrel(10);

Console.WriteLine("adamWest  makes a noise like {0}", adamWest.Noise);
Console.WriteLine("powderPuff  is a {0} out of 10 when it comes to cuteness!", powderPuff.CutenessLevel);
```
* You can also see what happens when you try to use variables that haven't been set
```
Console.WriteLine("powderPuff  makes a noise like {0}", powderPuff.Noise);
Console.WriteLine("adamWest  is a {0} out of 10 when it comes to cuteness!", adamWest.CutenessLevel);
```
* Once you've created overloaded constructor methods, you can explicitly go back and add the default constructor with zero methods.
```
public class Squirrel {
	public string Noise {get; set;}
	public bool Exotic {get; set;}
	public string FavoriteFood {get; set;}
	public bool FluffyTail {get; set;}
	public int CutenessLevel {get; set;}
	public Squirrel() {}
	public Squirrel (string sound) {
		Noise = sound;
	}
	public Squirrel (int adorable) {
		CutenessLevel = adorable;
	}
	public Squirrel (int adorable, string sound) {
		CutenessLevel = adorable;
		Noise = sound;
	}
}

Squirrel greenLantern = new Squirrel();
```