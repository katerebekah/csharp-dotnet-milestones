# Zoolandia - Method Overloading

## Setup

```bash
cd ~/workspace/zoolandia
git checkout -b version-3
```

## Instructions

1. Add a new, overloaded constructor method to your animal that takes a single string as an argument.
1. Inside the new constructor, using `this`, assign the value of the `name` property with the argument value.
1. Create an instance of your animal like before, but pass in the name of the animal as an argument.

	```
	Squirrel superman = new Squirrel("Sammy");
	Console.Write(superman.name);
	```

1. Add **another** overloaded constructor method that will set the value of one of the `int` typed properties of your animal. Define an integer as an argument and then create another instance of your animal and pass it an integer.
1. Add **ONE MORE** constructor method! This method will accept both an integer and a string as arguments. Set the appropriate property values with the argument values.
