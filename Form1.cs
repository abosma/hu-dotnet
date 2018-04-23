using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum1DotNet
{
    public partial class Form1 : Form
    {
        private int beurt = 0;
        private string plaatje = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            Button clickedButton = (Button)sender;

            if(beurt % 2 == 1)
            {
                plaatje = "X";
            }
            else
            {
                plaatje = "O";
            }

            if(clickedButton.Text == "")
            {
                clickedButton.Text = plaatje;
                beurt++;
            }

            if (!(BepaalWinnaar(button1, button2, button3) ||
                BepaalWinnaar(button4, button5, button6) ||
                BepaalWinnaar(button7, button8, button9) ||
                BepaalWinnaar(button1, button5, button9) ||
                BepaalWinnaar(button3, button5, button7) ||
                BepaalWinnaar(button1, button4, button7) ||
                BepaalWinnaar(button2, button5, button8) ||
                BepaalWinnaar(button3, button6, button9)) &&
                beurt == 9){
                MessageBox.Show("Jammer! Niemand wint.");
                MaakLeeg();
            }
        }

        private bool BepaalWinnaar(Button a, Button b, Button c)
        {
            if(a.Text == b.Text && a.Text == c.Text && !a.Text.Equals(""))
            {
                MessageBox.Show("Gefeliciteerd! Speler " + plaatje + " wint.");
                MaakLeeg();
                return true;
            }

            return false;
        }

        private void MaakLeeg()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            beurt = 0;
        }
    }
}
