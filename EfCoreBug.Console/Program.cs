namespace EfCoreBug.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(BugFactory.GetLongDebugView(true));

            System.Console.ReadLine();
        }
    }
}
