using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolko_i_krzyzyk_6x6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int gracz = 2;
        public int tura = 0;


        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NOWA_Click(object sender, EventArgs e)
        {
           
        }

        private void przycisk(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (gracz % 2 == 0)
                {
                    button.Text = "X";
                    gracz++;

                }
                else
                {
                    button.Text = "O";
                    gracz++;
                }
            }
        }
    }
}
