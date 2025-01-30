namespace Demos
{
    internal class Program
    {
        readonly struct Point
        {
            private readonly double x;
            private readonly double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double X
            {
                get { return x; }
            }

            public double Y
            {
                get { return y; }
            }

            public override string ToString()
            {
                return $"La coord x est {x}  la coord y est {y} ";
            }
        }
        static void Main(string[] args)
        {
            PointGeographique Qc = new PointGeographique(46, -71);
            PointGeographique Mtl = new PointGeographique(45, -73);
            Console.WriteLine(Qc + Mtl);

            //Utilisation de la struct
            Point pStruct = new Point(45, -71);
            Console.WriteLine(pStruct);
            }
    }
}
