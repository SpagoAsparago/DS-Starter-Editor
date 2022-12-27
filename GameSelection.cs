using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_Starter_Editor
{
    public partial class GameSelection : Form
    {
        public GameSelection(int Game)
        {
            InitializeComponent();
            BWButton.Enabled = false;
        }

        public int Game
        {
            get;
            set;
        }

        private void BW2Button_Click(object sender, EventArgs e)
        {
            Game = 4;
            Dispose();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PlatButton_Click(object sender, EventArgs e)
        {
            Game = 1;
            Dispose();
        }
        private void HGSSButton_Click(object sender, EventArgs e)
        {
            Game = 2;
            Dispose();
        }

        private void BWButton_Click(object sender, EventArgs e)
        {
            Game = 3;
            Dispose();  
        }
    }
}
