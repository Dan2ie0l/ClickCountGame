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
            foreach (var item in Program.players) {
                lstPlayers.Items.Add(item.FirstName + " " + item.LastName + " " +item.Age + " " + item.Score + " "+ item.Time);
                    }
        }
    }
}
