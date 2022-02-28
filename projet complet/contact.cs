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
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
        }
        public static List<string> messages = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            // send messages to admin 
           
        

            messages.Add(tb_nom.Text +"\n       "+ tb_message.Text);
            tb_message.Clear();
            tb_email.Clear();
            tb_nom.Clear();


            timer1.Start();


            PB_att.Visible = true;
        }

        private void contact_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PB_envoyer.Value += 3;
            if (PB_envoyer.Value > 95)
            {
                timer1.Stop();


                PB_att.Visible = false;

                P_ok.Visible = true; ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
