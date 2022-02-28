using System;
using System.IO;
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
    public partial class send_CV : Form
    {

        public send_CV(string em)
        {
            InitializeComponent();
            tb_to.Text = em;

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // parcorir.Text = openFileDialog1.FileName;

            pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*tbb_email.Text = tb_email.Text;
            tbb_to.Text = tb_to.Text;
            tbb_object.Text = tb_object.Text;
            tbb_lettre.Text = tb_lettre.Text;
            pictureBox2.Image = pictureBox3.Image;*/


        }

        private void developpementInformatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new DG_tdi();
            this.Hide();
            f.Show();
        }

        private void reseaunnformatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new DG_tri();
            this.Hide();
            f.Show();
        }

        private void electromécaniqueDesSystèmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new DG_esa();
            this.Hide();
            f.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new question_f();
            f.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new contact();
            f.Show();
        }

        private void proposAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new infoApp();
            f.Show();

        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new propos_equipe();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*tbb_email.Text = tb_email.Text;
            tbb_lettre.Text = tb_lettre.Text;
            tbb_object.Text = tb_object.Text;
            tbb_to.Text = tb_to.Text;*/


           
        }

        private void tb_to_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            conneect_admin_user s = new conneect_admin_user();
            this.Hide();
            s.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PB_att.Value += 4;
            if (PB_att.Value > 95)
            {
                timer1.Stop();
                PB_att1.Visible = false;
                P_demande.Visible = true;
                panel3.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            L_email.Text = tb_email.Text;
            L_a.Text = tb_to.Text;
            L_lettre.Text = tb_lettre.Text;
            L_object.Text = tb_object.Text;
            pictureBox2.Image = pictureBox3.Image;

            timer1.Start();
            PB_att1.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            string dplm = conneect_admin_user.deplom;
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
            }
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "choisez votre CV";
            openFileDialog1.InitialDirectory = @"C:/";
            openFileDialog1.FileName = "choisez votre CV";
            openFileDialog1.Filter = "*.jpg|*.jpg| *.png|*.png";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            P_demande.Visible = false;
        }
    }
}
