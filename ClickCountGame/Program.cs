using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCountGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static List<Player> players = new List<Player>();
        public static Dictionary<Player, Dictionary<int,int>> results = new Dictionary<Player, Dictionary<int, int>>();
        public static Player currentPlayer = new Player();
            }

}
