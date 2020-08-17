using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racetrack_Simulator
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public Bet(int Amount, int Dog, Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }
        public string GetDescription()
        {
            string description = "";

            if(Amount != 0)
            {
                description = String.Format("{0} bets {1} on dog #{2}", Bettor.Name, this.Amount, this.Dog);
                return description;
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets", Bettor.Name);
                return description;
            }
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
