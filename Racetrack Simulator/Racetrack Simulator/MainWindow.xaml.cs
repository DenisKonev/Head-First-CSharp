using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Racetrack_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer;
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Random MyRandomizer;
        public MainWindow()
        {
            InitializeComponent();
            MyRandomizer = new Random();
            minimumBetLabel.Content = "Minimum bet: " + bucksUpDownControl.Minimum + " bucks";

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);

            GreyhoundArray[0] = new Greyhound()
            {
                MyImage = imageDog1,
                StartingPosition = (int)imageDog1.Margin.Left,
                RacetrackLenght = (int)imageRacetrack.Width - (int)imageDog1.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyImage = imageDog2,
                StartingPosition = (int)imageDog2.Margin.Left,
                RacetrackLenght = (int)imageRacetrack.Width - (int)imageDog2.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyImage = imageDog3,
                StartingPosition = (int)imageDog3.Margin.Left,
                RacetrackLenght = (int)imageRacetrack.Width - (int)imageDog3.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyImage = imageDog4,
                StartingPosition = (int)imageDog4.Margin.Left,
                RacetrackLenght = (int)imageRacetrack.Width - (int)imageDog4.Width,
                Randomizer = MyRandomizer
            };

            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel,
            };

            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel,
            };

            GuyArray[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel,
            };

            foreach(Guy guy in GuyArray)
                guy.UpdateLabels();
        }


        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            int winnerDog;

            for(int i = 0; i < 4; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    winnerDog = i + 1;
                    MessageBox.Show("Dog number " + winnerDog + " won the race!");
                    dispatcherTimer.Stop();
                    
                    foreach (Greyhound greyhound in GreyhoundArray)
                        greyhound.TakeStartingPosition();

                    foreach (Guy guy in GuyArray)
                        if (guy.MyBet != null)
                        {
                            guy.Collect(winnerDog);
                            guy.MyBet = null;
                        }
                }
                    
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
        }

        private void joeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            nameLabel.Content = GuyArray[0].Name;
        }

        private void bobRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            nameLabel.Content = GuyArray[1].Name;
        }

        private void alRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            nameLabel.Content = GuyArray[2].Name;
        }

        private void betsButton_Click(object sender, RoutedEventArgs e)
        {
            int guyIndex = 0;

            if ((bool)joeRadioButton.IsChecked)
                guyIndex = 0;
            if ((bool)bobRadioButton.IsChecked)
                guyIndex = 1;
            if ((bool)alRadioButton.IsChecked)
                guyIndex = 2;

            if ((((bool)joeRadioButton.IsChecked) || ((bool)bobRadioButton.IsChecked) || ((bool)alRadioButton.IsChecked)) 
                        && GuyArray[guyIndex].PlaceBet((int)bucksUpDownControl.Value, (int)dogUpDownControl.Value))
                GuyArray[guyIndex].UpdateLabels();

        }
    }
}
