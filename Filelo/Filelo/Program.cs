namespace Filelo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        
        static void Run()
        {
            Console.WriteLine("Hello, World!");
            string[] lines = File.ReadAllLines("quiz.txt");
             Console.WriteLine(Environment.CurrentDirectory);
        }  
        
    }
}
