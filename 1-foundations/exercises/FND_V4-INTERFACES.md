# Milestone 1 - Exercise V4 - Interfaces

This lesson teaches C# Interfaces. Our objectives are as follows:

Understand the Purpose of Interfaces.
Define an Interface.
Implement Interface Inheritance in a class.
Create a collection of objects that implement the class.

An interface is defined a contract that all the classes implementing the interface should follow. A real world example would be a book interface, all books need pages, isbn number, pages, author, and many more properties. Typically interfaces are prefixed with "I", in this case we will work with an interface called "ICanine".

Interfaces define properties, methods, and events, which are the members of the interface. Interfaces contain only the declaration of the members. It is the responsibility of the deriving class to implement the members. It often helps in providing a standard structure that the deriving classes would follow.

In this exercise we will create an interface called ICanine. We will create three classes that implement ICanine. We will create three classes that implement ICanine, these classes will be Dog, Wolf, and Dingo.

STEPS:
* Using csharppad.com, create an Interface called ICanine.
* Add the following properties to ICanine.  Classes that implement ICanine must implement the following properties.

   ```   
  class Dog : ICanine
    {
        public int AverageLifeSpan { get; set; }
        public int AverageWeight { get; set; }
        public int GestationDays { get; set; }
        public string CoatColor { get; set; }
        public string CommonName { get; set; }
        public bool IsDomestic { get; set; }
        public string Diet { get; set; }
        public bool IsEndangered { get; set; }
        public string SpeciesName { get; set; }
     }
```
* ICanine needs to have two methods for obtaining the Habitat and Population of the canine based on country code. 
```
       string GetHabitatBasedOnCountry(string countryCode);
       int? GetPopulationBasedOnCountry(string countryCode);  
```
* Create the interface like this:
```                
public interface ICanine
    {
       string SpeciesName { get; set; }
        //Add the rest of the properties
        //Add the methods for gettng the Habitat and Population
    }
```
* Create a "Dog" Class that implements from the "ICanine" Interface. Create a public property for the Species Name
```
 class Dog : ICanine
    {
       public string SpeciesName { get; set; }
    
    }

```
* Run your code. You should get an error stating that he properties and methods have not been implemented. The ICanine interface is   enforcing the contract with Dog.
* Add the rest of the properties to the Dog class
* Add the method that returns a string description of their habitat: GetHabitatBasedOnCountry(string countryCode). It could be   something like this:
```
  public string GetHabitatBasedOnCountry(string countryCode)
        {
            if (countryCode == "United States"||countryCode=="Canada")
            {
                return "Dogs are found throughout North America, mainly in house holds.";
            }
            return "Habitat Unknown";
        }
```
* You will need to implement the method called "GetPopulationBasedOnCountry(string country) in the Dog class
* Run your code. If you have not implemented all of the properties and methods you will have errors. Fix the errors and once the code   compiles you are ready to create an instance of the Dog class.
* Underneath the Dog class create an instance of the Dog class. 
```
            Dog dog = new Dog
            {
                GestationDays = 60,
                //Set the rest of the properties
            };
```


* Use your dog class to display properties related to this implementation of ICanine. You coud do something like this. Try to display as many properties as you can. 
```
   Console.Write("The scientific name for a dog is " + dog.SpeciesName + "\n");
   Console.Write("Dogs like to eat " + dog.Diet );
   Console.ReadLine();
```
*Use the methods called GetHabitatBasedOnCountryCode and GetPopulationBasedOnCountry. Display the values returned from these methods on the console. You could do something like this:
```
  var country="United States";
  var dogPopulation=dog.GetPopulationBasedOnCountry(country);
  Console.Write("Population for dogs is " + dogPopulation + " in " + country + "\n");
```
* Display dog habitat in the console. 
* Create a wolf class that implements ICanine
* Create an instance of the wolf class
* Display the properties of wolf on the console
* Create a dingo class that implements ICanine
* Create an instance of the dingo class
* Display the properties of dingo on the console

*Please note, you will type all of the above code into csharppad.com even though it would typically go into different files when using Visual Studio.*
