using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFch4_DayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public string GetDescription() /*Zwraca string, który określa, kto obstawił wyścig, jak duyżo pieniędzy 
                                       postawił i na którego psa. Jeżeli wartość równa 0, zakład nie został zawarty*/
        {
            if (Amount >= 5) 
            {
                return Bettor.Name + " bets " + Amount + " bucks on dog #" + Dog;}
            else
            {
                return Bettor.Name + " hasn't placed a bet";
            }
          
        }
        public int PayOut(int Winner)
        {                               /*Wypłać lub odbierz kasę za zakład. Parametrem jest pies który zwyciężył wyścig*/
            if (Dog == Winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
