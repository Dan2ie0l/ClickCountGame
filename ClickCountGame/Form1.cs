using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        public Label LblName
        {
            get
            {
                return lblName;
            }
            set
            {
                lblName = value;
            }
        }
        public Label LblAge
        {
            get
            {
                return lblAge;
            }
            set
            {
                lblAge = value;
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


            string line;
            string dirPath = @"c:\Data";

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            if (!File.Exists(@"c:\Data\players.txt"))
            {
                File.Create(@"c:\Data\players.txt");
            }
            if (!File.Exists(@"c:\Data\results.txt"))
            {
                File.Create(@"c:\Data\results.txt");
            }
            if (File.Exists(@"c:\Data\results.txt"))
                {
                     
                    StreamReader sr = new StreamReader(@"c:\Data\results.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] items = line.Split(',');
                        Player pl = new Player();
                        pl.FirstName = items[0];
                        pl.LastName = items[1];
                        pl.Age = int.Parse(items[2]);
                        pl.results.Add(int.Parse(items[3]), int.Parse(items[4]));
                        Program.results.Add(pl);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    Console.ReadLine();
                }
            if (File.Exists(@"c:\Data\players.txt"))
            {

                StreamReader sr = new StreamReader(@"c:\Data\players.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] items = line.Split(',');
                    Player pl = new Player();
                    pl.FirstName = items[0];
                    pl.LastName = items[1];
                    pl.Age = int.Parse(items[2]);
                    Program.players.Add(pl);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }




            _obj = this;
            UCstart uc = new UCstart();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);



        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCaddPlayer uc1 = new UCaddPlayer();
            uc1.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc1);
            panelContainer.Controls["UCaddPlayer"].BringToFront();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string dirPath = @"c:\Data";

            if (Directory.Exists(dirPath))
            {
              
                if (File.Exists(@"c:\Data\players.txt"))
                {
                    using (TextWriter tw = new StreamWriter(@"c:\Data\players.txt"))
                    {
                        foreach (var item in Program.players)
                        {
                            tw.Write(item.ToString());

                            foreach (var i in item.results)
                            {
                                tw.Write("," +i.Key + "," + i.Value);
                            }
                        }
                        tw.Close();
                    }
                }

               


            }
            MessageBox.Show("Everything is saved successfully on C://Date", "Saving", MessageBoxButtons.OK);
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List objUI = new List();
            objUI.Show();
        }


    }
}

