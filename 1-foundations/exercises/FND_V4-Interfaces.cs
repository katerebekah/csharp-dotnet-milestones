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
                return "mainly in house holds though there feral dog populations North America";
            }
            else if(country=="Australia")
            {
               return "all habitat types ranging from alpine, woodland, grassland, desert and tropical regions."; 
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
          var country="United States";
          var dogPopulation=dog.GetPopulationBasedOnCountry(country);
          var dogHabitat=dog.GetHabitatBasedOnCountry(country);
          Console.Write("Population for dogs is " + dogPopulation + " in " + country + "\n");
          Console.Write("Habitat for dogs is " + dogHabitat + " in " + country + "\n");
          Console.Write("The scientific name for a dog is " + dog.SpeciesName + "\n");
          Console.Write("Dogs like to eat " + dog.Diet );
          Console.ReadLine();