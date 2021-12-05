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
    public partial class Winner : Form
    {
        public string WinnerName { get; set; }

        public Winner()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void Winner_Load(object sender, EventArgs e)
        {
            message.Text = WinnerName + " vítězí!";
        }
    }
}
