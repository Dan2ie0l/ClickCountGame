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
        public Button BackButton
        {
            get
            {
                return btnBack;
            }
            set
            {
                btnBack = value;
            }
        }
        private int gameDuration;
        private int gamePassedTime;
        private int clickCount;
        
        public Form1()
        {
            InitializeComponent();
        }

      
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            _obj = this;

            UCstart uc = new UCstart();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void tmrInterval_Tick(object sender, EventArgs e)
        {
            gameDuration++;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCstart"].BringToFront();
            btnBack.Visible = false;
        }
    }
}
