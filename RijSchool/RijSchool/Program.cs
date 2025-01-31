
namespace RijSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 63739,
                merk = "volvo"
            };
            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };
            LesUur lesUur1 = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,

                tijd = 1130
            };
            LesPakket lesPakket = new LesPakket();
            TheorieTest theorieTest = new TheorieTest();
            RijTest rijTest = new RijTest();
            LesUur lesUur2 = new LesUur();
            Student student1 = new Student()
            {
                naam = "huseyin",
                leeftijd = 17,
                lesPakket = lesPakket,
                rijLeraar = rijLeraar,
                theorieTest = theorieTest,
                rijTest = rijTest,
            };
            Student student2 = new Student()
            {
                naam = "blabla",
                leeftijd = 16,
                lesPakket = lesPakket,
                rijLeraar = rijLeraar,
                theorieTest = theorieTest,
                rijTest = rijTest,
            };
            
            Dag dag = new Dag()
            {
                datum = DateTime,
                lesuren = lesUur1s,
                lesuren = lesUur2,

            };
        }
    }
}
