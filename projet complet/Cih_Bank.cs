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
    public partial class Cih_Bank : Form
    {
        public Cih_Bank()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {

            send_CV f = new send_CV(email.Text);
            this.Hide();
            f.Show();
        }
    }
}
