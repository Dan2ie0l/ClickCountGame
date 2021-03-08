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
        string selected;
        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            _obj = this;
            selected =cmbUserNames.SelectedItem.ToString();
            string[] arr = selected.Split(',');
            Program.currentPlayer.FirstName = arr[0];
            Program.currentPlayer.LastName = arr[1];
            Program.currentPlayer.Age = int.Parse(arr[2]);
            Form1.Instance.LblName.Text = Convert.ToString(Program.currentPlayer.FirstName + " " + Program.currentPlayer.LastName);
            Form1.Instance.LblAge.Text = Convert.ToString(Program.currentPlayer.Age);
            _obj.Refresh();

        }

        public void UCchangeUsername_Load(object sender, EventArgs e)
        {

            foreach (var item in Program.players)
            {
                cmbUserNames.Items.Add(item);
            }
        }


    }
}
