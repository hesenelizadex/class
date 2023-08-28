namespace ConsoleApp4
{
    public class Country : Location
    {
        public Country(string locatedContinent, string name) : base(locatedContinent, name)
        {

        }
        public int MyProperty { get; set; }
        public string Changed()
        {
            Console.WriteLine();
            return $"{Name} changed.";
        }
    }
}
