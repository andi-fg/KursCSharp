using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "+";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void berechneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Zahl1 = Convert.ToInt32(textBox1.Text);
                int Zahl2 = Convert.ToInt32(textBox2.Text);
                double resultat = 0;
                string operation = comboBox1.Text;
                bool ok = true;
                switch (operation)
                {
                    case "+":
                        resultat = Zahl1 + Zahl2;
                        break;
                    case "-":
                        resultat = Zahl1 - Zahl2;
                        break;
                    case "*":
                        resultat = Zahl1 * Zahl2;
                        break;
                    case "/":
                        if(Zahl2 == 0)
                        {
                            MessageBox.Show("Man darf nicht / null Teilen");
                            ok = false;

                        }
                        else
                        {
                            resultat = Zahl1 / Zahl2;
                        }
                        
                        break;
                }
                if (ok)
                {
                    resultatLbl.Text = Convert.ToString(resultat);
                }
                
            }
            catch
            {

            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            resultatLbl.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           // MessageBox.Show("Hallo");
        }
    }
}
