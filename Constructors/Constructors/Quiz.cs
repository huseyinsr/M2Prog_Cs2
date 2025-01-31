namespace Constructors
{
    internal class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;


        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
            ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
        }


        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }


        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            VoegVraagToeOpIndex(index, new QuizVraag(vraag, antwoord));
        }
    }
}
