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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstPlayers.Items.Clear();
            foreach (var item in Program.players)
            {
                lstPlayers.Items.Add(item.ToString());

                foreach (var i in item.results)
                {
                    lstPlayers.Items.Add(i.Key + " " + i.Value);
                }
            }
        }

        private void btnShowPlayers_Click(object sender, EventArgs e)
        {
            lstPlayers.Items.Clear();
            foreach (var item in Program.players)
            {

                lstPlayers.Items.Add(item.ToString());

            }
        }
    }
}
