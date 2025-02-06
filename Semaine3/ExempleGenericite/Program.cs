namespace ExempleGenericite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations<string> op = new Operations<string>("un","deux");
            Console.WriteLine(op.Somme());
     
            /*List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            Console.WriteLine(list[0]);*/
        }
    }
}
