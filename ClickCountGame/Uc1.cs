using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClickCountGame;


namespace ClickCountGame
{
    public partial class Uc1 : UserControl
    {
        public Uc1()
        {
            InitializeComponent();
        }
        public int gamePassedTime;
        public int clickCount;
        public int gameDuration;

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            gameDuration = UCstart.Instance.gameDuration;
            if (!tmrInterval.Enabled)
            {
                tmrInterval.Start();
                lblTime.Text = Convert.ToString(gameDuration);
            }
            clickCount++;
            lblClickCount.Text = Convert.ToString(clickCount);


        }
        Player currentPlayer;
        public int index = UCchangeUsername.Instance.index;
        private void tmrInterval_Tick(object sender, EventArgs e)
        {

            gamePassedTime += 1;
            lblTime.Text = Convert.ToString(gameDuration - gamePassedTime);
            if (gamePassedTime == gameDuration)
            {

                tmrInterval.Stop();
                btnClickMe.Enabled = false;
                currentPlayer = (Player)Program.currentPlayer.Clone();
                try
                {
                    currentPlayer.results.Add(clickCount, gameDuration);
                    Program.players[index] = (Player)currentPlayer.Clone();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK);
                }



                MessageBox.Show("Time is up", "Game", MessageBoxButtons.OK);


            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            gameDuration = UCstart.Instance.gameDuration;
            lblTime.Text = Convert.ToString(gameDuration);
            btnClickMe.Enabled = true;
            gamePassedTime = 0;
            clickCount = 0;
            lblClickCount.Text = "0";
        }
    }
}
