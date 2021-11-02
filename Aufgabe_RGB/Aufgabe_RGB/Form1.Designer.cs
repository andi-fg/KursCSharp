
namespace Aufgabe_RGB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rotTb = new System.Windows.Forms.TrackBar();
            this.gruenTb = new System.Windows.Forms.TrackBar();
            this.blauTb = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rotLbl = new System.Windows.Forms.Label();
            this.grünLbl = new System.Windows.Forms.Label();
            this.blauLbl = new System.Windows.Forms.Label();
            this.outputPb = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.rotTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruenTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blauTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rotTb
            // 
            this.rotTb.Location = new System.Drawing.Point(8, 81);
            this.rotTb.Maximum = 255;
            this.rotTb.Name = "rotTb";
            this.rotTb.Size = new System.Drawing.Size(260, 56);
            this.rotTb.TabIndex = 0;
            this.rotTb.Scroll += new System.EventHandler(this.rotTb_Scroll);
            // 
            // gruenTb
            // 
            this.gruenTb.Location = new System.Drawing.Point(8, 143);
            this.gruenTb.Maximum = 255;
            this.gruenTb.Name = "gruenTb";
            this.gruenTb.Size = new System.Drawing.Size(260, 56);
            this.gruenTb.TabIndex = 1;
            this.gruenTb.Scroll += new System.EventHandler(this.gruenTb_Scroll);
            // 
            // blauTb
            // 
            this.blauTb.Location = new System.Drawing.Point(8, 206);
            this.blauTb.Maximum = 255;
            this.blauTb.Name = "blauTb";
            this.blauTb.Size = new System.Drawing.Size(260, 56);
            this.blauTb.TabIndex = 2;
            this.blauTb.Scroll += new System.EventHandler(this.blauTb_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blau";
            // 
            // rotLbl
            // 
            this.rotLbl.AutoSize = true;
            this.rotLbl.Location = new System.Drawing.Point(275, 91);
            this.rotLbl.Name = "rotLbl";
            this.rotLbl.Size = new System.Drawing.Size(0, 20);
            this.rotLbl.TabIndex = 6;
            // 
            // grünLbl
            // 
            this.grünLbl.AutoSize = true;
            this.grünLbl.Location = new System.Drawing.Point(275, 157);
            this.grünLbl.Name = "grünLbl";
            this.grünLbl.Size = new System.Drawing.Size(0, 20);
            this.grünLbl.TabIndex = 7;
            // 
            // blauLbl
            // 
            this.blauLbl.AutoSize = true;
            this.blauLbl.Location = new System.Drawing.Point(275, 217);
            this.blauLbl.Name = "blauLbl";
            this.blauLbl.Size = new System.Drawing.Size(0, 20);
            this.blauLbl.TabIndex = 8;
            // 
            // outputPb
            // 
            this.outputPb.BackColor = System.Drawing.SystemColors.Control;
            this.outputPb.Location = new System.Drawing.Point(490, 91);
            this.outputPb.Name = "outputPb";
            this.outputPb.Size = new System.Drawing.Size(205, 151);
            this.outputPb.TabIndex = 9;
            this.outputPb.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem1,
            this.hilfeToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // beendenToolStripMenuItem1
            // 
            this.beendenToolStripMenuItem1.Name = "beendenToolStripMenuItem1";
            this.beendenToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.beendenToolStripMenuItem1.Text = "Beenden";
            this.beendenToolStripMenuItem1.Click += new System.EventHandler(this.beendenToolStripMenuItem1_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 270);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.outputPb);
            this.Controls.Add(this.blauLbl);
            this.Controls.Add(this.grünLbl);
            this.Controls.Add(this.rotLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blauTb);
            this.Controls.Add(this.gruenTb);
            this.Controls.Add(this.rotTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rotTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruenTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blauTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputPb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar rotTb;
        private System.Windows.Forms.TrackBar gruenTb;
        private System.Windows.Forms.TrackBar blauTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rotLbl;
        private System.Windows.Forms.Label grünLbl;
        private System.Windows.Forms.Label blauLbl;
        private System.Windows.Forms.PictureBox outputPb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
    }
}

