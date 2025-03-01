using System.Collections.ObjectModel;

namespace classeDerivee
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection<Animal> animaux = new Collection<Animal>();
            animaux.Add(new Chat());
            animaux.Add(new Chien());

            foreach (Animal animal in animaux)
            {
                 Console.WriteLine(animal.Crie());
            }
        }
    }
}
