
namespace Nesne_Hareketi
{
    partial class frmEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrYukariDogru = new System.Windows.Forms.Timer(this.components);
            this.tmrSagDogru = new System.Windows.Forms.Timer(this.components);
            this.tmrAsagıDogru = new System.Windows.Forms.Timer(this.components);
            this.tmrSolaDogru = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 584);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(114, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 330);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(114, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 35);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(758, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 584);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(640, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(44, 361);
            this.panel5.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(150, 435);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(497, 35);
            this.panel7.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(36, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(729, 35);
            this.panel6.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(36, 547);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(729, 35);
            this.panel8.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nesne_Hareketi.Properties.Resources._600px_Rotating_earth__huge_;
            this.pictureBox1.Location = new System.Drawing.Point(46, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tmrYukariDogru
            // 
            this.tmrYukariDogru.Interval = 20;
            this.tmrYukariDogru.Tick += new System.EventHandler(this.tmrYukariDogru_Tick);
            // 
            // tmrSagDogru
            // 
            this.tmrSagDogru.Interval = 20;
            this.tmrSagDogru.Tick += new System.EventHandler(this.tmrSagDogru_Tick);
            // 
            // tmrAsagıDogru
            // 
            this.tmrAsagıDogru.Interval = 20;
            this.tmrAsagıDogru.Tick += new System.EventHandler(this.tmrAsagıDogru_Tick);
            // 
            // tmrSolaDogru
            // 
            this.tmrSolaDogru.Interval = 20;
            this.tmrSolaDogru.Tick += new System.EventHandler(this.tmrSolaDogru_Tick);
            // 
            // frmEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEkran";
            this.Text = "Ekran";
            this.Load += new System.EventHandler(this.frmEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrYukariDogru;
        private System.Windows.Forms.Timer tmrSagDogru;
        private System.Windows.Forms.Timer tmrAsagıDogru;
        private System.Windows.Forms.Timer tmrSolaDogru;
    }
}

