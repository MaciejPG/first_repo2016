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
            
            A1.Text = A2.Text = A3.Text = A4.Text = A5.Text = A6.Text = "";
            B1.Text = B2.Text = B3.Text = B4.Text = B5.Text = B6.Text = "";
            C1.Text = C2.Text = C3.Text = C4.Text = C5.Text = C6.Text = "";
            D1.Text = D2.Text = D3.Text = D4.Text = D5.Text = D6.Text = "";
            E1.Text = E2.Text = E3.Text = E4.Text = E5.Text = E6.Text = "";
            F1.Text = F2.Text = F3.Text = F4.Text = F5.Text = F6.Text = "";
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
                    tura++;
                }
                else
                {
                    button.Text = "O";
                    tura++;
                    gracz++;
                }
                if (remis() == true)
                {
                    MessageBox.Show("Remis!");
                }

            }
        }
       
        bool remis()
        {
            if (tura == 36)
                return true;
            else
                return false;
        }
      
    }
}
