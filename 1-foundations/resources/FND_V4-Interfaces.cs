C# Interactive Shell (6)
close
public interface ICanine
    {
        string SpeciesName { get; set; }  //example-the scientific name for dog is Canis lupus familiaris
        string CommonName { get; set; }//dog, coyote, wolf, dingo
        bool IsDomestic { get; set; }
        bool IsEndangered { get; set; }
        int GestationDays { get; set; }
        string CoatColor { get; set; }
        string Diet { get; set; }
        int AverageWeight { get; set; }
        int AverageLifeSpan { get; set; }
        string GetHabitatBasedOnCountry(string country);
        int? GetPopulationBasedOnCountry(string country);  //made nullable since code needs to be able to handle unfound country code, country codes frequently change.
    }
    
    
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
       
        public string GetHabitatBasedOnCountry(string country)
        {
            if (country == "United States"||country=="Canada")
            {
                return "mainly in households though there feral dog populations North America";
            }
           
            return "Habitat Unknown";
        }
        
        public int? GetPopulationBasedOnCountry(string country)
        {
           switch (country)
         {
            case "Australia":
              return 2323234;
               break;
            case "United States":
               return 6663234;
               break;
            case "Canada":
               return 6663234;
               break;
            default:
               return null;
               break;
         }
      
        }
    }
    
          
     class Wolf : ICanine
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
       
        public string GetHabitatBasedOnCountry(string country)
        {
            if (country.Contains("United States")||country.Contains("Canada"))
            {
                return "diverse range of environments, including tundra, mountain areas, woodlands, forests, grasslands and deserts.";
            }
          
            return "Habitat Unknown";
        }
        
        public int? GetPopulationBasedOnCountry(string country)
        {
           switch (country)
         {
            case "Australia":
              return 0;
               break;
            case "United States":
               return 6663234;
               break;
            case "Canada":
               return 6663234;
               break;
            default:
               return null;
               break;
         }
      
        }
    }
         
 //Create classes that implement ICanine
  Wolf wolf = new Wolf
            {
                GestationDays = 60,
                AverageLifeSpan = 13,
                AverageWeight = 60,
                CoatColor = "Varies",
                CommonName = "Wolf",
                Diet = "Other wildlife",
                IsDomestic = false,
                IsEndangered=false,
                SpeciesName= "Canis lupu"
          };
          
  
            Dog dog = new Dog
            {
                GestationDays = 60,
                AverageLifeSpan = 13,
                AverageWeight = 35,
                CoatColor = "Varies",
                CommonName = "Dog",
                Diet = "Dog food and purloined snacks",
                IsDomestic = true,
                IsEndangered=false,
                SpeciesName= "Canis lupus familiaris"
          };        
          
          
          //display wolf info
          var wolfCountry="United States, Canada";
          var wolfPopulation=wolf.GetPopulationBasedOnCountry(wolfCountry);
          var wolfHabitat=wolf.GetHabitatBasedOnCountry(wolfCountry);
          Console.Write("Population for wolves is " + wolfPopulation + " in " +wolfCountry + "\n");
          Console.Write("Habitat for wolves is " + wolfHabitat + " in " + wolfCountry + "\n");
          Console.Write("The scientific name for a wolf is " + wolf.SpeciesName + "\n");
          Console.Write("Wolves like to eat " + wolf.Diet );
          Console.ReadLine();
 
          
          
          //display dog info
          var dogCountry="United States";
          var dogPopulation=dog.GetPopulationBasedOnCountry(dogCountry);
          var dogHabitat=dog.GetHabitatBasedOnCountry(dogCountry);
          Console.Write("Population for dogs is " + dogPopulation + " in " + dogCountry + "\n");
          Console.Write("Habitat for dogs is " + dogHabitat + " in " + dogCountry + "\n");
          Console.Write("The scientific name for a dog is " + dog.SpeciesName + "\n");
          Console.Write("Dogs like to eat " + dog.Diet );
          Console.ReadLine();
