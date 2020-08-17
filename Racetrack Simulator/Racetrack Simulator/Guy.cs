using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Xceed.Wpf.Toolkit;

namespace Racetrack_Simulator
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            if(MyBet == null)
                MyLabel.Content = String.Format("{0} hasn't placed any bets", Name);
            else
                MyLabel.Content = MyBet.GetDescription();
            MyRadioButton.Content = this.Name + " has " + this.Cash + " bucks";
        }

        public void ClearBet ()
        {
            MyBet = null;
            this.UpdateLabels();
        }

        public bool PlaceBet (int BetAmount, int DogToWin)
        {
            if (Cash >= BetAmount)
            {
                MyBet = new Bet(BetAmount, DogToWin, this);
                this.UpdateLabels();
                return true;
            }
            else
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(this.Name + " doesn't have enough money to place a bet");
                return false;
            }
        }

        public void Collect (int Winner)
        {
            this.Cash += MyBet.PayOut(Winner);
            MyBet = null;
            this.UpdateLabels();
        }
    }
}
