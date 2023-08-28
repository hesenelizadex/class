namespace ConsoleApp4
{
    public class City : Location
    {
        public City(string locatedContinent, string name) : base(locatedContinent, name)
        {
        }
        public string Burning()
        {
            Console.WriteLine();
            return $"{Name} burning.";
        }
    }
}
