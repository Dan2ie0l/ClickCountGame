﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCountGame
{
    public partial class UCaddPlayer : UserControl
    {
        public UCaddPlayer()
        {
            InitializeComponent();
        }
        static UCaddPlayer _obj;
        public static UCaddPlayer Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCaddPlayer();
                }
                return _obj;

            }


        }
        public string name;
        public string sname;
        public int age;

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            _obj = this;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCaddPlayer"))
            {
                UCaddPlayer uc = new UCaddPlayer();
                uc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(uc);

            }
            Form1.Instance.PnlContainer.Controls["UCaddPlayer"].BringToFront();
            name = txtName.Text;
            sname = txtSname.Text;
            age = int.Parse(txtAge.Text);
            Player pl1 = new Player() { FirstName = name, LastName = sname, Age =age};
            Program.players.Add(pl1);
        }
    }
}
