using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {

            Quiz quiz = new Quiz(10);


            quiz.VoegVraagToeOpIndex(0, new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam"));
            quiz.VoegVraagToeOpIndex(1, "Wat is 2 + 2?", "4");
            quiz.VoegVraagToeOpIndex(2, "Wat is de kleur van de zon?", "Geel");
            quiz.VoegVraagToeOpIndex(3, "Hoeveel dagen heeft een week?", "7");
            quiz.VoegVraagToeOpIndex(4, "Hoeveel uur heeft een dag?", "24");
            quiz.VoegVraagToeOpIndex(5, new QuizVraag("Wat is de hoofdstad van België?", "Brussel"));
            quiz.VoegVraagToeOpIndex(6, "Wat is het grootste land ter wereld?", "Rusland");
            quiz.VoegVraagToeOpIndex(7, "Hoeveel continenten zijn er?", "7");
            quiz.VoegVraagToeOpIndex(8, new QuizVraag("Wat is de hoofdstad van Frankrijk?", "Parijs"));
            quiz.VoegVraagToeOpIndex(9, "Hoeveel seconden heeft een minuut?", "60");


            for (int i = 0; i < quiz.vragen.Length; i++)
            {
                if (quiz.vragen[i] != null)
                {
                    Console.WriteLine($"Vraag {i + 1}: {quiz.vragen[i].vraag} (Antwoord: {quiz.vragen[i].antwoord})");
                }
            }
        }
    }
}
