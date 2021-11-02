using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_RGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rot = rotTb.Value;
            var gruen = gruenTb.Value;
            var blau = blauTb.Value;

            rotLbl.Text = Convert.ToString(rot);
            grünLbl.Text = Convert.ToString(gruen);
            blauLbl.Text = Convert.ToString(blau);

            outputPb.BackColor = Color.FromArgb(rot, gruen, blau);
        }
        private void aendereColor()
        {
            var rot = rotTb.Value;
            var gruen = gruenTb.Value;
            var blau = blauTb.Value;
            outputPb.BackColor = Color.FromArgb(rot, gruen, blau);
        }

        private void rotTb_Scroll(object sender, EventArgs e)
        {
            rotLbl.Text = Convert.ToString(rotTb.Value);
            aendereColor();
        }

        private void gruenTb_Scroll(object sender, EventArgs e)
        {
            grünLbl.Text = Convert.ToString(gruenTb.Value); 
            aendereColor();
        }

        private void blauTb_Scroll(object sender, EventArgs e)
        {
            blauLbl.Text = Convert.ToString(blauTb.Value);
            aendereColor();
        }

        private void beendenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hilfe h = new Hilfe();
            h.ShowDialog();
        }
    }
}
