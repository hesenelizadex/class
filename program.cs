using ConsoleApp4;

namespace HelloWorld
{
    internal class Program : Location
    {
        public Program(string locatedContinent, string name) : base(locatedContinent, name)
        {
        }
        static void Main(string[] args)
        {
           City city = new City("Europe","Baku");
           Street street = new Street("Asia","Semed Vurgun Street");
           Country country = new Country("Africa","Azerbaycan");
           Console.WriteLine(street.LocatedContinent);
           Console.WriteLine(city.Name);
           Console.WriteLine(country.Name);
           Console.WriteLine(city.Burning());
           Console.WriteLine(street.Developing());
           Console.WriteLine(country.Changed());
           Console.WriteLine(street.GetName());
        }
    }
}
