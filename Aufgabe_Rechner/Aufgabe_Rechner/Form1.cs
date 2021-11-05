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
                            resultat = (double)Zahl1 / (double)Zahl2;
                        }
                        
                        break;
                }
                if (ok)
                {
                    resultatLbl.Text = Convert.ToString(resultat);
                    ListViewItem item = new ListViewItem(Zahl1+ "");
                    item.SubItems.Add(Zahl2 + "");
                    item.SubItems.Add(operation);
                    item.SubItems.Add(resultat + "");
                    listView1.Items.Add(item);
                }
                
            }
            catch
            {
                resultatLbl.Text = "Geben Sie richtige Zahlen ein";
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           // MessageBox.Show("Hallo");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            var list = listView1.Items;
            string[] export = new string[list.Count];
            int i = 0;
            foreach(ListViewItem item in list)
            {
                
                var subitems = item.SubItems;
                string output = "";
                foreach(ListViewItem.ListViewSubItem sub in subitems)
                {
                    output += sub.Text + ";";
                }
                export[i] = output;
                i++;
                //C:\Users\lucaa\OneDrive\Desktop\Mischa\UnterrichtC#\KursC#
            }
            System.IO.File.WriteAllLines(@"C:\Users\lucaa\OneDrive\Desktop\Mischa\UnterrichtC#\KursC#\rechner.txt", export);
        }
    }
}
