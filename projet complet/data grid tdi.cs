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
    public partial class DG_tdi : Form
    {
        public DG_tdi()
        {
            InitializeComponent();
        }

        public static bool admiin = conneect_admin_user.admin;
        private void DG_tdi_Load(object sender, EventArgs e)
        {
            //design data grid view
           






            DGV_tdi.Rows.Add(8);
            //DGV_tdi.Rows.Add("Bmce", "service bank", "Directeur", "21");
            /////////////////////////////////
            DGV_tdi.Rows[0].Cells[0].Value = Image.FromFile("photo/bmce.png");
            DGV_tdi.Rows[0].Cells[1].Value = "Bmce";
            DGV_tdi.Rows[0].Cells[2].Value = "Bank";
            DGV_tdi.Rows[0].Cells[3].Value = "El Jadida";
            DGV_tdi.Rows[0].Cells[4].Value = "Directeur";
            DGV_tdi.Rows[0].Cells[5].Value = "25";
            /////////////////////////////////
            //DGV_tdi.Rows.Add("Maroc telecome", "Service comminucation", "chef d'agence", "5");
            
            DGV_tdi.Rows[1].Cells[0].Value = Image.FromFile("photo/iam.png");
            DGV_tdi.Rows[1].Cells[1].Value = "Maroc Telecom";
            DGV_tdi.Rows[1].Cells[2].Value = "Telecom";
            DGV_tdi.Rows[1].Cells[3].Value = "Casa Blanca";
            DGV_tdi.Rows[1].Cells[4].Value = "Commercial";
            DGV_tdi.Rows[1].Cells[5].Value = "3";
            /////////////////////////////////
            //DGV_tdi.Rows.Add("Royal", "Royal air de maroc", "chef de travail", "11");
            DGV_tdi.Rows[2].Cells[0].Value = Image.FromFile("photo/ram.jpg");
            DGV_tdi.Rows[2].Cells[1].Value = "Royal";
            DGV_tdi.Rows[2].Cells[2].Value = "Royal air Maroc";
            DGV_tdi.Rows[2].Cells[3].Value = "Rabat";
            DGV_tdi.Rows[2].Cells[4].Value = "technicien";
            DGV_tdi.Rows[2].Cells[5].Value = "16";
            /////////////////////////////////
            //DGV_tdi.Rows.Add("Marjane", "market", "chef de travail", "15");
            
            
            DGV_tdi.Rows[3].Cells[0].Value = Image.FromFile("photo/marjane.png");
            DGV_tdi.Rows[3].Cells[1].Value = "Marjane";
            DGV_tdi.Rows[3].Cells[2].Value = "Marche";
            DGV_tdi.Rows[3].Cells[3].Value = "Marrakech";
            DGV_tdi.Rows[3].Cells[4].Value = "Gestion de magazin";
            DGV_tdi.Rows[3].Cells[5].Value = "2";
            /////////////////////////////////
            //DGV_tdi.Rows.Add("Paypal", "service", "developpeur", "8");
            DGV_tdi.Rows[4].Cells[0].Value = Image.FromFile("photo/paypal.png");
            DGV_tdi.Rows[4].Cells[1].Value = "paypal";
            DGV_tdi.Rows[4].Cells[2].Value = "service";
            DGV_tdi.Rows[4].Cells[3].Value = "international";
            DGV_tdi.Rows[4].Cells[4].Value = "programeur";
            DGV_tdi.Rows[4].Cells[5].Value = "19";
            /////////////////////////////////
            //DGV_tdi.Rows.Add("Bim", "market", "sécurité", "12");
            
            DGV_tdi.Rows[5].Cells[0].Value = Image.FromFile("photo/twitter.png");
            DGV_tdi.Rows[5].Cells[1].Value = "twitter";
            DGV_tdi.Rows[5].Cells[2].Value = "service";
            DGV_tdi.Rows[5].Cells[3].Value = "usa";
            DGV_tdi.Rows[5].Cells[4].Value = "designer";
            DGV_tdi.Rows[5].Cells[5].Value = "8";
            //DGV_tdi.Rows.Add("Inwi", "telecom", "gerer ateleier", "5");
            DGV_tdi.Rows[6].Cells[0].Value = Image.FromFile("photo/inwi.png");
            DGV_tdi.Rows[6].Cells[1].Value = "inwi";
            DGV_tdi.Rows[6].Cells[2].Value = "telecom";
            DGV_tdi.Rows[6].Cells[3].Value = "maknes";
            DGV_tdi.Rows[6].Cells[4].Value = "technisien";
            DGV_tdi.Rows[6].Cells[5].Value = "12";
            //DGV_tdi.Rows.Add("Facebook", "service", "developpeur", "20"); 
            DGV_tdi.Rows[7].Cells[0].Value = Image.FromFile("photo/facebook.png");
            DGV_tdi.Rows[7].Cells[1].Value = "facebook";
            DGV_tdi.Rows[7].Cells[2].Value = "service";
            DGV_tdi.Rows[7].Cells[3].Value = "international";
            DGV_tdi.Rows[7].Cells[4].Value = "developpeur";
            DGV_tdi.Rows[7].Cells[5].Value = "40";
            string nomuser = conneect_admin_user.nom_user;

            if (conneect_admin_user.admin == true)
            {
                lb_userName.Text = "ADMIN";
                DGV_tdi.ReadOnly = false;
                panel1.Visible = true;
                otil_admin.Visible = true;
                lb_welcome.Visible = true;
            }
            if (conneect_admin_user.admin == false)
            {
                lb_userName.Text = nomuser;
                panel1.Visible = false;
                //lb_welcome.Text = nomuser.ToUpper();
                DGV_tdi.Location = new Point(210, 129) ;
                DGV_tdi.Size = new Size(1055, 367);
                //panel_titre.Location = new Point(235, 27);
                lb_welcome.Visible = true;
                panel_quit_annul.Location = new Point(597,493);
            }
        }

        private void DGV_tdi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public object arr;
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            string[] arr = new string[] { TB_societee.Text, TB_categorie.Text,tb_ville.Text , TB_poste.Text, TB_nbpost.Text };
            DGV_tdi.Rows.Add(guna2CirclePictureBox1.Image, TB_societee.Text, TB_categorie.Text, tb_ville.Text, TB_poste.Text, TB_nbpost.Text);
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            if (DGV_tdi.SelectedRows.Count > 0)
            {
                DGV_tdi.Rows.RemoveAt(DGV_tdi.SelectedRows[0].Index);
            }
        }

        private void btn_trier_Click(object sender, EventArgs e)
        {
            DGV_tdi.Sort(DGV_tdi.Columns[1], ListSortDirection.Ascending);
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            DGV_tdi.Rows.Clear();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "choisi photo";
            openFileDialog1.InitialDirectory = @"C:/Users/lenovo/Desktop/hat/image";
            openFileDialog1.FileName = "Icon";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "(*.png)|*.png|(*.jpg)|*.jpg";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            guna2CirclePictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void developpementInformatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void réseauInformatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new DG_tri();
            this.Hide();
            f.Show();
        }

        private void electromécaniqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new DG_esa();
            this.Hide();
            f.Show();
        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new question_f();
            f.Show();
            this.Hide();
        }

        private void contactSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new contact();
            f.Show();
            
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new propos_equipe();
            f.Show();
            this.Hide();
        }

        private void appJobLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new infoApp();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new message__admin();
            f.Show();
        }

        private void otil_admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = DGV_tdi.CurrentRow;
            guna2CirclePictureBox1.Image = (Image)dr.Cells[0].Value;
            TB_societee.Text = dr.Cells[1].Value.ToString();
            TB_categorie.Text = dr.Cells[2].Value.ToString();
            tb_ville.Text = dr.Cells[3].Value.ToString();
            TB_poste.Text = dr.Cells[4].Value.ToString();
            TB_nbpost.Text = dr.Cells[4].Value.ToString();

            DGV_tdi.Rows.Remove(dr);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void DGV_tdi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = e.RowIndex;
            if (rowindex == 0)
            {
                Form f = new form_bmce();
                this.Hide();
                f.Show();

            }
            if (rowindex == 1)
            {
                Form f = new form_groupe_maroc_telecom();
                this.Hide();
                f.Show();
            }
            if (rowindex == 2)
            {
                Form f = new form_royal_air_maroc();
                this.Hide();
                f.Show();
            }
            if (rowindex == 3)
            {
                Form f = new form_marjane();
                this.Hide();
                f.Show();
            }
            if (rowindex == 4)
            {
                Form f = new Paypal();
                this.Hide();
                f.Show();

            }
            if (rowindex == 5)
            {
                Form f = new Twitter();
                this.Hide();
                f.Show();
            }
            if (rowindex == 6)
            {
                Form f = new Inwi();
                this.Hide();
                f.Show();
            }
            if (rowindex == 7)
            {
                Form f = new Facebook();
                this.Hide();
                f.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "choisi photo";
            openFileDialog1.InitialDirectory = @"C:/Users/lenovo/Desktop";
            openFileDialog1.FileName = "Icon";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "(*.png)|*.png|(*.jpg)|*.jpg";
            openFileDialog1.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            this.Hide();
            f.Show();
        }
    }
}
