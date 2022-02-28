using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_complet
{
    public partial class form_royal_air_maroc : Form
    {
        //private static extern IntPtr CreateRoundRectRgn
        //    (
        //        int nLeft,
        //        int nTop,
        //        int nRight,
        //        int nBottom,
        //        int nWidthEllipse,
        //        int nHeightEllipse

        //    );
        public form_royal_air_maroc()
        {
            InitializeComponent();
        }

        private void form_royal_air_maroc_Load(object sender, EventArgs e)
        {
            //button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            //button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        } 
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            send_CV f = new send_CV(email.Text);
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dplm = conneect_admin_user.deplom;
            if (dplm == "ri")
            {
                Form d = new DG_tri();
                this.Hide();
                d.Show();
            }
            else if (dplm == "di")
            {
                Form d = new DG_tdi();
                this.Hide();
                d.Show();

            }
            else if (dplm == "esa")
            {
                Form d = new DG_esa();
                this.Hide();

                d.Show();

            }
        }
    }
}
