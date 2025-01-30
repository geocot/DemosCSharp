namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointGeographique Qc = new PointGeographique(46, -71);
            PointGeographique Mtl = new PointGeographique(45, -73);
            Console.WriteLine(Qc + Mtl);
            Console.WriteLine(Qc.Equals(Mtl));
        }
    }
}
