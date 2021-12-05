using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ants
{
    public partial class NewGame : Form
    {
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }
        public bool Singleplayer { get; set; }

        public NewGame()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (player1NameBox.Text == "" && player2NameBox.Text == "")
            {
                DialogResult = DialogResult.None;
                return;
            }
            Player1Name = player1NameBox.Text;
            Player2Name = player2NameBox.Text;
            Singleplayer = singlePlayerButton.Checked ? true : false;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
