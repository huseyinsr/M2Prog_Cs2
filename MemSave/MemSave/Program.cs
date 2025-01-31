namespace MemSave
{
    internal class Program
    { 
        string welkomsTekst = "Hello world";
        string saveFile = "welkomState.txt";
        static void Main(string[] args)
        {
            Run();

        }

        static void Run()
        {
            bool bestaatDeFile = File.Exists(saveFile);
            Console.WriteLine("Hello, World!");
            while (true) 
            {
                Console.WriteLine("Enter a text, then press enter");
                Console.ReadLine();
            }
        }
    }
}

