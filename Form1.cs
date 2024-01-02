using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFch4_DayAtTheRaces
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();       // generator losowości
        Greyhound[] dogs = new Greyhound[4];     // tablica psów
        Guy[] guys = new Guy[3];              //tablica facetów

        public Form1()
        {
            InitializeComponent();
            
            dogs[0] = new Greyhound()           //deklaracje psów
            {              
                MyPictureBox = hound1,
                StartingPosition = hound1.Left,
                RacetrackLength = raceTrack.Width - hound1.Width,
                MyRandom = randomizer
            };
            dogs[1] = new Greyhound()
            { 
                MyPictureBox = hound2,
                StartingPosition = hound1.Left,
                RacetrackLength = raceTrack.Width - hound1.Width,
                MyRandom = randomizer
            };
            dogs[2] = new Greyhound()
            { 
                MyPictureBox = hound3,
                StartingPosition = hound1.Left,
                RacetrackLength = raceTrack.Width - hound1.Width,
                MyRandom = randomizer
            };
            dogs[3] = new Greyhound()
            {  
                MyPictureBox = hound4,
                StartingPosition = hound1.Left,
                RacetrackLength = raceTrack.Width - hound1.Width,
                MyRandom = randomizer
            };

            guys[0] = new Guy()             //deklaracje facetów
            {
                Name = "Joe",
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel,
                MyBet = null,
            };
            guys[1] = new Guy()            
            {
                Name = "Bob",
                Cash = 75,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel,
                MyBet = null,
            };
            guys[2] = new Guy()
            {
                Name = "Al",
                Cash = 45,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel,
                MyBet = null,
            };
            for(int i = 0; i<guys.Length; i++)          //aktualizujemy etykiety
            {
                guys[i].ClearBet();
            } 

        }

        private void hound3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winner;
            for(int i = 0; i<dogs.Length; i++)
            {
                if(dogs[i].Run()) 
                {
                    timer1.Stop();
                    winner = i + 1;
                    MessageBox.Show("Round won by the dog #" + winner, "We have a winner!");
                    for (int f = 0; f < guys.Length; f++)
                    {
                        if(guys[f].MyBet!=null)
                        {
                            guys[f].Collect(winner);
                        }
                    }
                    startButton.Enabled = true;
                    break;
                }
            } 
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].TakeStartingPosition();
            }
            //System.Threading.Thread.Sleep(1500); <---psy nie znikają z mety. są w 2 miejscach na raz.
            timer1.Start();
            startButton.Enabled = false;
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guys[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guys[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = guys[2].Name;
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                guys[0].PlaceBet((int)amountNumericUpDown.Value, (int)houndNumericUpDown.Value);
            }
            else if (bobRadioButton.Checked)
            {
                guys[1].PlaceBet((int)amountNumericUpDown.Value, (int)houndNumericUpDown.Value);
            }
            else 
            {
                guys[2].PlaceBet((int)amountNumericUpDown.Value, (int)houndNumericUpDown.Value);
            }
        }
    }
}
