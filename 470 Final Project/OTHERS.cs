using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _370_Final_Project
{
    public partial class OTHERS : Form
    {
        public OTHERS()
        {
            InitializeComponent();
        }

        private void SELL_BUTTON_Click(object sender, EventArgs e)
        {
            SELL s = new SELL();
            s.Show();
        }

        private void SEARCH_BUTTON_Click(object sender, EventArgs e)
        {
            SEARCH s = new SEARCH();
            s.Show();
        }
    }
}
