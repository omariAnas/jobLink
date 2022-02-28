using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace projet_complet
{
    public partial class propos_equipe : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthRllipse,
            int nHrightEllipse
            );

        public propos_equipe()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            /*string dplm = inscription.deplom;
            if (dplm == "ri")
            {
                Form f = new DG_tri();
                this.Hide();
                f.Show();
            }
            if (dplm == "di")
            {
                Form f = new DG_tdi();
                this.Hide();
                f.Show();
            }
            if (dplm == "esa")
            {
                Form f = new DG_esa();
                this.Hide();
                f.Show();
            }*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
