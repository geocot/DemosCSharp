namespace SurchargeOperateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(45, -73);
            Point p2 = new Point(46, -71);

            Point p3 = p1 - p2;
            Console.WriteLine(p3);
        
        }
    }
}
