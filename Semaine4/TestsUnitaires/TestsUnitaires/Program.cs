namespace TestsUnitaires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculs calculs = new Calculs();
            Console.WriteLine($"Aire du cercle est {calculs.AireCercle(10)}");
        }
    }
}
