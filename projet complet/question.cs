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
    public partial class question_f : Form
    {
        public question_f()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        
        public static List<string> questions = new List<string>() ;
        private void button1_Click(object sender, EventArgs e)
        {

            questions.Add(tb_question.Text);
            tb_question.Clear();

            PB_wait.Visible = true;
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void question_f_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PB_attt.Value += 5;
            if (PB_attt.Value >= 95)
            {
                timer1.Stop();


                PB_wait.Visible = false;

                P_okk.Visible = true; ;
            }
        }
    }
}
