using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Hareketi
{
    public partial class frmEkran : Form
    {
        public frmEkran()
        {
            InitializeComponent();
        }

        private void frmEkran_Load(object sender, EventArgs e)
        {
            tmrYukariDogru.Start();
        }

        private void tmrYukariDogru_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 40)
            {
                tmrYukariDogru.Stop();
                tmrSagDogru.Start();
            }
        }

        private void tmrSagDogru_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left>=515)
            {
                tmrSagDogru.Stop();
                tmrAsagıDogru.Start();
            }
        }

        private void tmrAsagıDogru_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top>=390)
            {
                tmrAsagıDogru.Stop();
                tmrSolaDogru.Start();
            }
        }

        private void tmrSolaDogru_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left<=35)
            {
                tmrSolaDogru.Stop();
                tmrYukariDogru.Start();
            }
        }
    }
}
