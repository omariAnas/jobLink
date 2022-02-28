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
    public partial class conneect_admin_user : Form
    {
        public conneect_admin_user()
        {
            
            InitializeComponent();
        }
        // des informations de panel admin 
        public static string email_admin = "admin";
        public static string password_admin = "admin";
        public static bool admin;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changed combobox admin or user
            if(cb_choix.SelectedItem.ToString()=="ADMIN")
            {
                panel_admin.Visible = true;
                panel_user.Visible = false;
            }
            if(cb_choix.SelectedItem.ToString() == "USER")
            {
                panel_user.Visible = true;
                panel_admin.Visible = false;
            }
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_choix.SelectedIndex = cb_choix.FindStringExact("ADMIN");
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            //cb_choix.SelectedIndex = cb_choix.FindStringExact("USER");
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void connecter_Load(object sender, EventArgs e)
        {
            PB_chargement.Value = 0;
            tb_pswrd_admin.PasswordChar = '\u25CF';
            tb_password.PasswordChar = '\u25CF';

            //tb_password.PasswordChar = '\u25CF';
        }


        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ques = new question_f();
            ques.Show();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cont = new contact();
            cont.Show();
        }

        private void jobLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new infoApp();
            f.Show();
          
         
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new propos_equipe();
            f.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            //email and password = admin
            if (tb_usr_admin.Text == email_admin & tb_pswrd_admin.Text == password_admin)
            {
                

                Form dat = new DG_tdi();
                this.Hide();
                admin=true;
                //MessageBox.Show(user.ToString());
                dat.Show();
                

            }
            else
            {
                // MessageBox.Show( "Email ou le mot de pass est inncorrect", "erreur");
                messagebox_incorrect t = new messagebox_incorrect();
                t.Show();
                tb_usr_admin.Clear();
                tb_pswrd_admin.Clear();
            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_password.PasswordChar = '\0';
                pb_closeEyes.Visible = true;
                pb_openEye.Visible = false;
            }
            else
            {
                tb_password.PasswordChar = '\u25CF';
                pb_closeEyes.Visible = false;
                pb_openEye.Visible = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tb_pswrd_admin.PasswordChar = '\0';
                
            }
            else
            {
                tb_pswrd_admin.PasswordChar = '\u25CF';
             
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region null

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void panel_admin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_user_Paint(object sender, PaintEventArgs e)
        {

        }

        private void proposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void tb_usr_admin_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tb_usr_admin_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_usr_admin_Move(object sender, EventArgs e)
        {
        }

        private void tb_usr_admin_Leave(object sender, EventArgs e)
        {

        }

        private void tb_pswrd_admin_TextChanged(object sender, EventArgs e)
        { }

        private void tb_pswrd_admin_Leave(object sender, EventArgs e)
        { }

        private void tb_email_TextChanged(object sender, EventArgs e)
        { }

        private void tb_password_TextChanged(object sender, EventArgs e)
        { }
        #endregion
        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                tb_email.Text = "Email";
                tb_email.ForeColor = Color.Silver;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.PasswordChar = '\0';
                tb_password.Text = "mot de pass";
                tb_password.ForeColor = Color.Silver;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_connecter_Click(object sender, EventArgs e)
        {
            B_connecter.BackColor = Color.Blue;
            B_connecter.ForeColor = Color.White;
            B_creer.BackColor = Color.White;
            B_creer.ForeColor = Color.Blue;
            P_connecter.Visible = true;
            P_creer.Visible = false;
        }

        private void B_creer_Click(object sender, EventArgs e)
        {
            B_connecter.BackColor = Color.White;
            B_connecter.ForeColor = Color.Blue;
            B_creer.BackColor = Color.Blue;
            B_creer.ForeColor = Color.White;
            P_creer.Visible = true;
            P_connecter.Visible = false;

        }


        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "mot de pass")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;

                tb_password.PasswordChar = '\u25CF';
            }
        }

        private void P_connecter_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string email, password, deplom, nom_user;

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_prenom_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tb_prenom_Leave(object sender, EventArgs e)
        {
            if (tb_prenom.Text == "")
            {
                 tb_prenom.Text = "Prénom";
                 tb_prenom.ForeColor = Color.Silver;
            }
        }
        private void tb_prenom_Click(object sender, EventArgs e)
        {
            if (tb_prenom.Text == "Prénom")
            {
                tb_prenom.Text = "";
                tb_prenom.ForeColor = Color.Black;
            }
        }

        private void tb_nom_Click(object sender, EventArgs e)
        {
            if (tb_nom.Text == "Nom")
            {
                tb_nom.Text = "";
                tb_nom.ForeColor = Color.Black;
            }
        }

        private void tb_email_correct_Click(object sender, EventArgs e)
        {
            if (tb_email_correct.Text == "Exemple@gmail.com")
            {
                tb_email_correct.Text = "";
                tb_email_correct.ForeColor = Color.Black; ;
            }
        }

        private void tb_password_correct_Click(object sender, EventArgs e)
        {
            if (tb_password_correct.Text == "Password")
            {
                 tb_password_correct.Text = "";
                 tb_password_correct.ForeColor = Color.Black;
            }
        }

        private void tb_password_correct_Leave(object sender, EventArgs e)
        {
            if (tb_password_correct.Text ==  "" )
            {
                tb_password_correct.Text = "Password";
                tb_password_correct.ForeColor = Color.Silver;
            }
        }

        private void P_creer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PB_chargement.Value += 5;
            if (PB_chargement.Value >=100)
            {
                
                timer1.Stop();
                validation_anscription v = new validation_anscription();
                v.Show();
               // MessageBox.Show("Merci. Inscription est seccuss");
                PB_chargement.Visible = false;
                //Form c = new conneect_admin_user();
                //this.Hide();
                //c.Show();

                P_creer.Visible = false;
                P_connecter.Visible = true;


                PB_chargement.Value = 0;
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            bool err = false;
            email = tb_email_correct.Text;
            password = tb_password_correct.Text;
            nom_user = tb_nom.Text + " " + tb_prenom.Text;

            if (tb_nom.Text == "Nom")
            {
                errorProvider1.SetError(tb_nom, "format nom incorrect");
                err = false;
            }
            else { errorProvider1.Dispose(); err = true; }
            // text box prénom
            if (tb_prenom.Text == "Prénom")
            {
                errorProvider1.SetError(tb_prenom, "le prénom obligé");
                err = false;
            }
            else { errorProvider2.Dispose(); err = true; }
            // text box nom
            if (tb_email.Text == "Exemple@gmail.com")
            {
                errorProvider1.SetError(tb_email, "email obligé");
                err = false;
            }
            else { errorProvider3.Dispose(); err = true; }
            // text box nom
            if (tb_password.Text == "Password")
            {
                errorProvider1.SetError(tb_password, "le password obligé");
                err = false;
            }
            else { errorProvider4.Dispose(); err = true; }
            // text box nom
            if (cb_pays.Text == "Pays")
            {
                errorProvider1.SetError(cb_pays, "le pays obligé");
                err = false;
            }
            else { errorProvider5.Dispose(); err = true; }

            /*
             * Dveloppement informatique
                Réseaux informatique
                élèctromécanique*/

            //open form for login 
            if (err == true)
            {
                PB_chargement.Visible = true;
                timer1.Start();

            }

            if (deplome.Text == "Dveloppement informatique")
            { deplom = "di"; }
            if (deplome.Text == "Réseaux informatique")
            { deplom = "ri"; }
            if (deplome.Text == "élèctromécanique")
            { deplom = "esa"; }


         

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string em = conneect_admin_user.email;
            string pas = conneect_admin_user.password;


            if (tb_email.Text == em && tb_password.Text == pas)
            {

                string dplm = conneect_admin_user.deplom;
                admin = false;
                if (dplm == "ri")
                {
                    Form f = new DG_tri();
                    this.Hide();
                    f.Show();
                }
                else if (dplm == "di")
                {
                    Form f = new DG_tdi();
                    this.Hide();
                    f.Show();

                }
                else if (dplm == "esa")
                {
                    Form f = new DG_esa();
                    this.Hide();

                    f.Show();

                }


            }
            else
            {
                // DialogResult r = MessageBox.Show("password or email incorrect", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                messagebox_incorrect l = new messagebox_incorrect();
                l.Show();
                tb_email.Clear();
                tb_password.Clear();
            }
        }

        private void poserQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new if_you_have_question();
            f.Show();
        }

        private void PB_chargement_Click(object sender, EventArgs e)
        {

        }

        private void tb_nom_Leave(object sender, EventArgs e)
        {
            if (tb_nom.Text == "")
            {
                 tb_nom.Text = "Nom";
                 tb_nom.ForeColor = Color.Silver;
            }
        }

        private void tb_email_correct_Leave(object sender, EventArgs e)
        {
            if (tb_email_correct.Text == "" )
            {
                 tb_email_correct.Text = "Exemple@gmail.com";
                 tb_email_correct.ForeColor = Color.Silver;
            }
        }

        private void tb_email_Click(object sender, EventArgs e)
        {
            if (tb_email.Text == "Email")
            {
                tb_email.Text = "";
                tb_email.ForeColor = Color.Black;
            }
        }
    }
}
