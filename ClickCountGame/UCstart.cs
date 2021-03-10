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
        static UCstart _obj;
        public static UCstart Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCstart();
                }
                return _obj;

            }


        }
        public int gameDuration;
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            _obj = this;
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("Uc1"))
            {
                Uc1 uc = new Uc1();
                uc.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(uc);

            }
            Form1.Instance.PnlContainer.Controls["Uc1"].BringToFront();
            gameDuration = Convert.ToInt32(txtGameDuration.Text);
            txtGameDuration.Clear();
        }
    }
}
