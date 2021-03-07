using System;
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
    public partial class UCstart : UserControl
    {
        public UCstart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Uc1"))
            {
                Uc1 uc = new Uc1();
                uc.Dock
            }
        }
    }
}
