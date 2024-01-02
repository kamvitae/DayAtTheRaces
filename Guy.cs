using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFch4_DayAtTheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;   //instancja klasy bet przechowuyjąca dane o zakładzie
        public int Cash;

        //GUI references
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels() // ustaw moje pole tekstowe na opis zakładu, a napis obok
        {                           // pola wyboru tak, abu pokazywał ilość pieniędzy ("Joe have 43 bucks")
            MyRadioButton.Text = (Name + " has " + Cash + " bucks.");
            MyLabel.Text = MyBet.GetDescription();
        }
        public void ClearBet()              //wyczyść zakład by był równy 0
        {
            PlaceBet(0, 0);
        }
        public bool PlaceBet(int BetAmount, int DogToWin)  // ustal nowy zakład i przechowaj go w polu MyBet
        {                                               // zwróć true jeżeli facet ma wystarczającą ilość pieniędzy by obstawić
           
            if (BetAmount <= Cash)                          
            {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
                UpdateLabels();
                return true; }
            else
                return false;
        }
        public void Collect(int Winner)     // poproś o wypłatę i zaktualizuj etykiety. Użyj obiektu Bet
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
