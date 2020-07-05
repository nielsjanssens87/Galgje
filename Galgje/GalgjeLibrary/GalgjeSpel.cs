using System;
using System.Text;

namespace GalgjeLibrary
{
    public class GalgjeSpel
    {
        private string teRadenWoord = "test"; //
        public string SpelerWoord { get; set; }
        public string GebruikteLetters { get; private set; }
        public int PogingX { get; private set; }
        public bool EindeSpel { get; private set; }
        public bool? Gewonnen { get; private set; }

        public GalgjeSpel()
        {
            //eventueel: selecteer moeilijkheidsgraad 
            //eventueel: selecteer woord categorie
            //haal random woord op (dat voldoet aan moeilijkheidsgraag / categorie) en steek in teRadenWoord
            PogingX = 0;
            EindeSpel = false;
            Gewonnen = null;
            InitialiseerSpelerWoord();
        }

        public void RaadLetter(char letter)
        {
            PogingX++;
            GebruikteLetters += letter;
            VergelijkLetter(letter);
        }

        private void VergelijkLetter(char spelerletter)
        {
            StringBuilder sb = new StringBuilder(SpelerWoord);
            int index = 0;
            foreach (var letter in teRadenWoord)
            {
                if (letter == spelerletter)
                {
                    sb[index] = spelerletter;
                }
                index++;
            }
            SpelerWoord = sb.ToString();
        }
        private void InitialiseerSpelerWoord()
        {
            SpelerWoord = teRadenWoord;
            foreach (var item in teRadenWoord)
            {
                SpelerWoord = SpelerWoord.Replace(item, '.');
            }
        }
    }
}
