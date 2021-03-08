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
        Player result = new Player();
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
        Dictionary<int,int> res = new Dictionary<int,int>();
        private void tmrInterval_Tick(object sender, EventArgs e)
        {
            int count = Program.players.Count;
            gamePassedTime +=1;
            lblTime.Text = Convert.ToString(gameDuration-gamePassedTime);
            if (gamePassedTime == gameDuration)
            {
                
                tmrInterval.Stop();
                btnClickMe.Enabled = false;
                currentPlayer = (Player)Program.players[count-1].Clone();
                res.Add(clickCount, gameDuration);
                Program.results.Add(currentPlayer, res);
       
                MessageBox.Show("Time is up", "Game", MessageBoxButtons.OK);
                Program.players.Add(currentPlayer);
                
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
