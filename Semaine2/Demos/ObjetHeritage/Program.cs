namespace ObjetHeritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat("Minou");
            Chien chien = new Chien("Pitou");

            Animal[] animaux = { chien, chat };

            for (int i = 0; i < animaux.Length; i++)
            {
               Console.WriteLine(animaux[i].Crier());
            }

        }
    }
}
