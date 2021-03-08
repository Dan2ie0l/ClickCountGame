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
    public partial class UCchangeUsername : UserControl
    {
        public UCchangeUsername()
        {
            InitializeComponent();
        }
        static UCchangeUsername _obj;
        public static UCchangeUsername Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCchangeUsername();
                }
                return _obj;

            }


        }

        public ComboBox cmbPlayers
        {
            get
            {
                return cmbUserNames;
            }
            set
            {
                cmbUserNames = value;
            }
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {

        }

    }
}
