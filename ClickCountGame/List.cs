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
            foreach (KeyValuePair<Player, Dictionary<int, int>> kvp in Program.results)
            {
                lstPlayers.Items.Add(kvp.Key.ToString() + " ");

                foreach (KeyValuePair<int, int> kv in kvp.Value)
                {
                    lstPlayers.Items.Add(kv.Key + " " + kv.Value);
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
