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
    public partial class if_you_have_question : Form
    {
        public if_you_have_question()
        {
            InitializeComponent();
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                lb_v1.Visible = true;
                lb_v2.Visible = true;
            }
            else
            {
                lb_v1.Visible = false;
                lb_v2.Visible = false;
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
