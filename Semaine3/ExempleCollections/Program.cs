using System.Collections.ObjectModel;

namespace ExempleCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue
            /*Queue<string> villes = new Queue<string>();
            villes.Enqueue("Montréal");
            villes.Enqueue("Québec");
            villes.Enqueue("Trois-Rivières");

            Console.WriteLine($"Le nombre de ville est de {villes.Count()}");
            Console.WriteLine(villes.Peek());
            Console.WriteLine($"Le nombre de ville est de {villes.Count()}");
            Console.WriteLine(villes.Dequeue());
            Console.WriteLine($"Le nombre de ville est de {villes.Count()}");

            foreach (string ville in villes)
            {
                Console.WriteLine(ville);
            }*/

            //Dictionnaire
            Dictionary<string,int> villes = new Dictionary<string,int>();
            villes.Add("Montréal", 1200000);
            villes.Add("Québec", 600000);
            villes.Add("Trois-Rivières", 100000);

            foreach (KeyValuePair<string, int> ville in villes)
            {
                Console.WriteLine($"Le nom est {ville.Key} et la population est {ville.Value}");
            }
        }
    }
}
