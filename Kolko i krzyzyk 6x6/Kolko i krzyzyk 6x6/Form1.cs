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

            A1.BackColor = A2.BackColor = A3.BackColor = A4.BackColor = A5.BackColor = A6.BackColor = default(Color);
            B1.BackColor = B2.BackColor = B3.BackColor = B4.BackColor = B5.BackColor = B6.BackColor = default(Color);
            C1.BackColor = C2.BackColor = C3.BackColor = C4.BackColor = C5.BackColor = C6.BackColor = default(Color);
            D1.BackColor = D2.BackColor = D3.BackColor = D4.BackColor = D5.BackColor = D6.BackColor = default(Color);
            E1.BackColor = E2.BackColor = E3.BackColor = E4.BackColor = E5.BackColor = E6.BackColor = default(Color);
            F1.BackColor = F2.BackColor = F3.BackColor = F4.BackColor = F5.BackColor = F6.BackColor = default(Color);

            gracz = 0;
            tura = 0;
            

        }

        private void przycisk(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (tura % 2 == 0)
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                 }
                else
                {
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White;
                }

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
                if ((remis() == true)&&zwyciezca()==false)
                {
                    MessageBox.Show("Remis!");
                }
                if (zwyciezca() == true)
                {
                    if (button.Text == "X") {
                        MessageBox.Show("Zwyciężył X");
                            }
                    else
                    {
                        MessageBox.Show("Zwyciężył O");
                    }
                }

            }

        }
       
        private bool zwyciezca()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A3.Text == A4.Text) && A1.Text != "")
                                return true;
            else if ((A2.Text == A3.Text) && (A3.Text == A4.Text) && (A4.Text == A5.Text) && A2.Text != "")
                                return true;
            else if ((A3.Text == A4.Text) && (A4.Text == A5.Text) && (A5.Text == A6.Text) && A3.Text != "")
                                return true;
            
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B3.Text == B4.Text) && B1.Text != "")
                               return true;
            else if ((B2.Text == B3.Text) && (B3.Text == B4.Text) && (B4.Text == B5.Text) && B2.Text != "")
                               return true;
            else if ((B3.Text == B4.Text) && (B4.Text == B5.Text) && (B5.Text == B6.Text) && B3.Text != "")
                                return true;
            
            
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C3.Text == C4.Text) && C1.Text != "")
                                return true;
            else if ((C2.Text == C3.Text) && (C3.Text == C4.Text) && (C4.Text == C5.Text) && C2.Text != "")
                                return true;
            else if ((C3.Text == C4.Text) && (C4.Text == C5.Text) && (C5.Text == C6.Text) && C3.Text != "")
                               return true;
            
            else if ((D1.Text == D2.Text) && (D2.Text == D3.Text) && (D3.Text == D4.Text) && D1.Text != "")
                                return true;
            else if ((D2.Text == D3.Text) && (D3.Text == D4.Text) && (D4.Text == D5.Text) && D2.Text != "")
                                return true;
            else if ((D3.Text == D4.Text) && (D4.Text == D5.Text) && (D5.Text == D6.Text) && D3.Text != "")
                                return true;
           
            else if ((E1.Text == E2.Text) && (E2.Text == E3.Text) && (E3.Text == E4.Text) && E1.Text != "")
                                return true;
            else if ((E2.Text == E3.Text) && (E3.Text == E4.Text) && (E4.Text == E5.Text) && E2.Text != "")
                                return true;
            else if ((E3.Text == E4.Text) && (E4.Text == E5.Text) && (E5.Text == E6.Text) && E3.Text != "")
                                return true;
            
            else if ((F1.Text == F2.Text) && (F2.Text == F3.Text) && (F3.Text == F4.Text) && F1.Text != "")
                                return true;
            else if ((F2.Text == F3.Text) && (F3.Text == F4.Text) && (F4.Text == F5.Text) && F2.Text != "")
                                return true;
            else if ((F3.Text == F4.Text) && (F4.Text == F5.Text) && (F5.Text == F6.Text) && F3.Text != "")
                               return true;
                      

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (C1.Text == D1.Text) && A1.Text != "")
                return true;
            else if ((B1.Text == C1.Text) && (C1.Text == D1.Text) && (D1.Text == E1.Text) && B1.Text != "")
                return true;
            else if ((C1.Text == D1.Text) && (D1.Text == E1.Text) && (E1.Text == F1.Text) && C1.Text != "")
                return true;

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (C2.Text == D2.Text) && A2.Text != "")
                return true;
            else if ((B2.Text == C2.Text) && (C2.Text == D2.Text) && (D2.Text == E2.Text) && B2.Text != "")
                return true;
            else if ((C2.Text == D2.Text) && (D2.Text == E2.Text) && (E2.Text == F2.Text) && C2.Text != "")
                return true;


            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (C3.Text == D3.Text) && A3.Text != "")
                return true;
            else if ((B3.Text == C3.Text) && (C3.Text == D3.Text) && (D3.Text == E3.Text) && B3.Text != "")
                return true;
            else if ((C3.Text == D3.Text) && (D3.Text == E3.Text) && (E3.Text == F3.Text) && C3.Text != "")
                return true;

            else if ((A4.Text == B4.Text) && (B4.Text == C4.Text) && (C4.Text == D4.Text) && A4.Text != "")
                return true;
            else if ((B4.Text == C4.Text) && (C4.Text == D4.Text) && (D4.Text == E4.Text) && B4.Text != "")
                return true;
            else if ((C4.Text == D4.Text) && (D4.Text == E4.Text) && (E4.Text == F4.Text) && C4.Text != "")
                return true;

            else if ((A5.Text == B5.Text) && (B5.Text == C5.Text) && (C5.Text == D5.Text) && A5.Text != "")
                return true;
            else if ((B5.Text == C5.Text) && (C5.Text == D5.Text) && (D5.Text == E5.Text) && B5.Text != "")
                return true;
            else if ((C5.Text == D5.Text) && (D5.Text == E5.Text) && (E5.Text == F5.Text) && C5.Text != "")
                return true;

            else if ((A6.Text == B6.Text) && (B6.Text == C6.Text) && (C6.Text == D6.Text) && A6.Text != "")
                return true;
            else if ((B6.Text == C6.Text) && (C6.Text == D6.Text) && (D6.Text == E6.Text) && B6.Text != "")
                return true;
            else if ((C6.Text == D6.Text) && (D6.Text == E6.Text) && (E6.Text == F6.Text) && C6.Text != "")
                return true;



            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (C3.Text == D4.Text) && A1.Text != "")
                return true;
            else if ((B2.Text == C3.Text) && (C3.Text == D4.Text) && (D4.Text == E5.Text) && B2.Text != "")
                return true;
            else if ((C3.Text == D4.Text) && (D4.Text == E5.Text) && (E5.Text == F6.Text) && C3.Text != "")
                return true;

            else if ((A2.Text == B3.Text) && (B3.Text == C4.Text) && (C4.Text == D5.Text) && A2.Text != "")
                return true;
            else if ((B3.Text == C4.Text) && (C4.Text == D5.Text) && (D5.Text == E6.Text) && B3.Text != "")
                return true;

            else if ((A3.Text == B4.Text) && (B4.Text == C5.Text) && (C5.Text == D6.Text) && A3.Text != "")
                return true;

            else if ((B1.Text == C2.Text) && (C2.Text == D3.Text) && (D3.Text == E4.Text) && B1.Text != "")
                return true;
            else if ((C2.Text == D3.Text) && (D3.Text == E4.Text) && (E4.Text == F5.Text) && C2.Text != "")
                return true;

            else if ((C1.Text == D2.Text) && (D2.Text == E3.Text) && (E3.Text == F4.Text) && C1.Text != "")
                return true;



            else if ((A6.Text == B5.Text) && (B5.Text == C4.Text) && (C4.Text == D3.Text) && A6.Text != "")
                return true;
            else if ((B5.Text == C4.Text) && (C4.Text == D3.Text) && (D3.Text == E2.Text) && B5.Text != "")
                return true;
            else if ((C4.Text == D3.Text) && (D3.Text == E2.Text) && (E2.Text == F2.Text) && C4.Text != "")
                return true;

            else if ((B6.Text == C5.Text) && (C5.Text == D4.Text) && (D4.Text == E3.Text) && B6.Text != "")
                return true;
            else if ((C5.Text == D4.Text) && (D4.Text == E3.Text) && (E3.Text == F2.Text) && C5.Text != "")
                return true;

            else if ((C6.Text == D5.Text) && (D5.Text == E4.Text) && (E4.Text == F3.Text) && C6.Text != "")
                return true;

            else if ((A5.Text == B4.Text) && (B4.Text == C3.Text) && (C3.Text == D2.Text) && A5.Text != "")
                return true;
            else if ((B4.Text == C3.Text) && (C3.Text == D2.Text) && (D2.Text == E1.Text) &&  B4.Text != "")
                return true;

            else if ((A4.Text == B3.Text) && (B3.Text == C2.Text) && (C2.Text == D1.Text) && A4.Text != "")
                return true;
            
                else
                return false;

            
          

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
