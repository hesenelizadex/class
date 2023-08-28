namespace ConsoleApp4
{
    public class Street : Location
    {
        public Street(string LocatedContinent,string Name) : base(LocatedContinent, Name)
        {
        }
        public int MyProperty { get; set; }
        public string Developing()
        {
            Console.WriteLine();
            return $"{Name} Developing.";
        }
    }
}
