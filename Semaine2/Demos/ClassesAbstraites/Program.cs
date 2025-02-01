namespace ClassesAbstraites
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat("Minou");
            Console.WriteLine(chat.Crier());
            Console.WriteLine(chat.Dormir());
        }
    }
}
