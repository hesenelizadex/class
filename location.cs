namespace ConsoleApp4
{
    public class Location
    {
        public string LocatedContinent { get; set; }
        public string Name { get; set; }
        public string GetName()
        {
            return $"{Name} Located in the world.";
        }
        public Location(string locatedContinent,string name)
        {
            LocatedContinent = locatedContinent;
            Name = name;
        }
    }
}
   