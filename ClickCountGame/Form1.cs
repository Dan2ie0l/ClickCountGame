using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCountGame
{
    partial class Form1 : Form
    {
        static Form1 _obj;
        int count ;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;

            }


        }
        public Panel PnlContainer
        {
            get
            {
                return panelContainer;
            }
            set
            {
                panelContainer = value;
            }
        }




        public Form1()
        {
            InitializeComponent();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelContainer.Controls["UCstart"].BringToFront();


        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCchangeUsername uc1 = new UCchangeUsername();
            uc1.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc1);
            panelContainer.Controls["UCchangeUsername"].BringToFront();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Player pl1 = new Player();
            pl1.FirstName = "Daniel";
            pl1.LastName = "Harutyunyan";
            pl1.Age = 18;
            pl1.Score = 100;
            pl1.Time = 5;
            Program.players.Add(pl1);

            count = Program.players.Count;
            _obj = this;
            UCstart uc = new UCstart();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            lblName.Text = Convert.ToString( Program.players[count-1].FirstName + " " + Program.players[count - 1].LastName);
            lblAge.Text = Convert.ToString(Program.players[count - 1].Age );
            lblScore.Text = Convert.ToString(Program.players[count - 1].Score + " clicks in " + Program.players[count - 1].Time + " seconds  ");
            
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCaddPlayer uc1 = new UCaddPlayer();
            uc1.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc1);
            panelContainer.Controls["UCaddPlayer"].BringToFront();
        }

        private void showPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List objUI = new List();
            objUI.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
