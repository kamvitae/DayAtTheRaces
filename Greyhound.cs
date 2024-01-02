using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFch4_DayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;            // punkt gdzie rozpoczyna się picture box
        public int RacetrackLength;             // długość toru
        public PictureBox MyPictureBox = null;  // Mój (psa) obiekt PictureBox
        public int Location = 0;                // położenie na torze
        public Random MyRandom;                 // Instancja klasy Random. Tylko jeden obiekt!

        public bool Run()
        // Przesuń się losowo o 1,2,3,4 punkty
        // Zaktualizuj ppołożenie PicBox na form1
        // Zwróć true jeśli wygrałem wyścig
        {
            if (MyPictureBox!=null)
            {
                MyPictureBox.Left += MyRandom.Next(1, 7);
                
                if (MyPictureBox.Left >= RacetrackLength) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public void TakeStartingPosition()
        {           //wyzeruj położenie i ustaw na linii startowej
            MyPictureBox.Left = Location;
        }
    }
}
