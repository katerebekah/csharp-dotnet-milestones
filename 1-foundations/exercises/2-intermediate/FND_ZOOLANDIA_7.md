# Zoolandia - Habitats

## Setup

```bash
cd ~/workspace/zoolandia
git checkout -b version-7
```

## Instructions

For this last Zoolandia exercises for the Foundations Milestone, you need to define all of the Habitats in which all of the animals live. You'll use the [aggregation](../resources/FND_INHERIT_COMPOSE_AGGREGATE.md#aggregation) pattern to assign animals to each Habitat.

In this example code, I create the parent `Habitat` class that all others will derive from, and since every habitat in my Zoo will have animals in it, each specific habitat class will inherit that `inhabitant` property.

In the derived class, I inherit from `Habitat`, and implement the `IAquaticHabitat` interface. There's a private property that defines if the aquarium is freshwater or saltwater, another private property that will hold a list of employees who are responsible for being in the tank with the animals.

##### Example Habitat Class

```cs
using System.Collections.Generic;

namespace Zoolandia.Habitats
{
  public class Habitat
  {
      // Instantiated a new list, which will contain animals.
      // You will add animals at run time (i.e. in `static void Main()
      // `)
      public List<Animal> inhabitants = new List<Animal>();
      public string public_name { get; set; }
  }

  public interface IAquaticHabitat
  {
    void empty();
    void fill();

    double volume { get; set; }
  }

  public class Aquarium : Habitat, IAquaticHabitat
  {
      private bool _saltwater = false;
      public double volume { get; set; }
      public void empty()
      {
        throw new System.NotImplementedException();
      }
      public void fill()
      {
        throw new System.NotImplementedException();
      }
      private List<Employee> scubaCrew = new List<Employee>();

      // `public_name`, and `saltwater` properties can only be set when habitat is created
      public Aquarium (string name, bool isSaltwater)
      {
          _saltwater = isSaltwater;
          this.public_name = name;
      }
  }
}
```

Once you have defined all of your habitats, write logic to output the name of each habitat, and the name of each animal it contains to the command line.

##### Example CLI Output

```bash
Habitat: Aquarium
   Dolphin
   Yellow Shark
   Octopus

Habitat: Savannah
   Giraffe
   Zebra
   Hippopotamus
```