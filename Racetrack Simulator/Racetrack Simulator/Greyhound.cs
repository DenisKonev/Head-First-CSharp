using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Racetrack_Simulator
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLenght;
        public Image MyImage = null;
        public double Location = 0;
        public Random Randomizer;

        public bool Run ()
        {
            Location = this.GetLocation();
            Location += Randomizer.Next(1, 4);
            this.SetLocation(Location);

            if (Location >= RacetrackLenght)
                return true;
            else
                return false;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            this.SetLocation(Location);
        }

        public double GetLocation()
        {
            Thickness margin = MyImage.Margin;
            MyImage.Margin = margin;
            return margin.Left;
        }
        
        public void SetLocation(double location)
        {
            Thickness margin = MyImage.Margin;
            margin.Left = location;
            MyImage.Margin = margin;
        }
    }
}
