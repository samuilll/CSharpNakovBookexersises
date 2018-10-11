using System;

namespace Chapter_11_CreatingAndUsingObjects.Problem11
{
    class AdvertisementMessagesGenerator
    {
        private Random randomizer;

        private string[] laudatoryPhrases;
        private string[] laudatoryStories;
        private string[] cities;
        private string[] lastNames;
        private string[] firstNames;

        public AdvertisementMessagesGenerator()
        {
            this.randomizer = new Random();
            this.laudatoryPhrases = GetPhrases();
            this.laudatoryStories = GetStories();
            this.cities = GetCities();
            this.firstNames = GetFirstNames();
            this.lastNames = GetLastNames();
        }

        private string[] GetLastNames()
        {
            return new string[]
            {
                "Johnson",
                "Peterson",
                "Charls"
            };

        }

        private string[] GetFirstNames()
        {
            return new string[]
            {
                "Dayan",
                "Stella",
                "Hellen",
                "Kate"
            };
        }

        private string[] GetCities()
        {
            return new string[]
            {
                "London",
                "Paris", "Berlin",
                "New York",
                "Madrid"
            };
        }

        private string[] GetStories()
        {
            return new string[]
            {
                "Now I feel better.",
                "I managed to change.", "It made some miracle.",
                "I can’t believe it, but now I am feeling great.",
                "You should try it, too. I am very satisfied."
            };
        }

        private string[] GetPhrases()
        {
            return new string[]
            {
                "The product is excellent.",
                "This is a great product.",
                "I use this product constantly.",
                "This is the best product from this category."
            };
        }

        public string Generate()
        {
            string phraze = this.laudatoryPhrases[randomizer.Next(this.laudatoryPhrases.Length)];
            string story = this.laudatoryStories[randomizer.Next(this.laudatoryStories.Length)];
            string firstName = this.firstNames[randomizer.Next(this.firstNames.Length)];
            string lastName = this.lastNames[randomizer.Next(this.lastNames.Length)];
            string ciy = this.cities[randomizer.Next(this.cities.Length)];

            string message = $"{phraze} {story} - {firstName} {lastName}, {ciy}";

            return message;
        }
    }
}
