namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne hp = new Personne("Potter", "Harry");
            Personne hg = new Personne("Potter", "Harry");

            Console.WriteLine(hp.Equals(hg));
            Console.WriteLine(hp.GetHashCode());
            Console.WriteLine(hg.GetHashCode());
        }
    }
}
