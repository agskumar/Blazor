namespace ServerManagement.Models
{
    public static class CitiesRepository
    {
        public static List<City> cities = new()
        {
            new City { Name = "Tokyo" },
            new City { Name = "Mumbai" },
            new() { Name = "Paris" },
            new() { Name = "Sydney" },
            new City { Name = "London" },
        };

        //public static List<string> city = new List<string>()
        //{
        //    "Tokyo",
        //    "Mumbai",
        //    "Paris",
        //    "Sydney",
        //    "London"
        //};

        public static List<City> GetCities() => cities;
    }
}
