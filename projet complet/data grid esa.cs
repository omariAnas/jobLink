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
    public partial class DG_esa : Form
    {
        public DG_esa()
        {
            InitializeComponent();
        }
        public static bool admiin = conneect_admin_user.admin;
        private void DG_esa_Load(object sender, EventArgs e)
        {

            DGV_esa.Rows.Add(8);
            //DGV_esa.Rows.Add("photos\\1.png", "Dian Cooper", "(239)555-2020","Cilacap","Jan 21,2020 -13:30","Jan 21,2020","Jan 21,2020");
            /////////////////////////////////
            DGV_esa.Rows[0].Cells[0].Value = Image.FromFile("photo/ciment.jpg");
            DGV_esa.Rows[0].Cells[1].Value = "Ciment";
            DGV_esa.Rows[0].Cells[2].Value = "Ciment";
            DGV_esa.Rows[0].Cells[3].Value = "El Jadida";
            DGV_esa.Rows[0].Cells[4].Value = "chef de projet";
            DGV_esa.Rows[0].Cells[5].Value = "25";
            /////////////////////////////////
            //DGV_esa.Rows.Add("Afriqua", "distribution gaz", "conducteur", "15");

            DGV_esa.Rows[1].Cells[0].Value = Image.FromFile("photo/Afriquia.png");
            DGV_esa.Rows[1].Cells[1].Value = "Afriqua";
            DGV_esa.Rows[1].Cells[2].Value = "distribution gaz";
            DGV_esa.Rows[1].Cells[3].Value = "Casa blanca";
            DGV_esa.Rows[1].Cells[4].Value = "conducteur";
            DGV_esa.Rows[0].Cells[5].Value = "25";
            /////////////////////////////////
            //DGV_esa.Rows.Add("Auto hall", "Automobile ", "tecnisien ", "21");
            DGV_esa.Rows[2].Cells[0].Value = Image.FromFile("photo/auto.jpg");
            DGV_esa.Rows[2].Cells[1].Value = "Auto hall";
            DGV_esa.Rows[2].Cells[2].Value = "Automobile";
            DGV_esa.Rows[2].Cells[3].Value = "El Jadida";
            DGV_esa.Rows[2].Cells[4].Value = "technicien";
            DGV_esa.Rows[2].Cells[5].Value = "16";
            /////////////////////////////////
            //DGV_esa.Rows.Add("Al mada holding", "invertissement", "chef de travail", "17");
            DGV_esa.Rows[3].Cells[0].Value = Image.FromFile("photo/ram.jpg");
            DGV_esa.Rows[3].Cells[1].Value = "Al mada holding";
            DGV_esa.Rows[3].Cells[2].Value = "invertissement";
            DGV_esa.Rows[3].Cells[3].Value = "Rabat";
            DGV_esa.Rows[3].Cells[4].Value = "chef de equipe";
            DGV_esa.Rows[3].Cells[5].Value = "2";
            /////////////////////////////////
            //DGV_esa.Rows.Add("Cih bank", "bank", "programmeur", "10");
            DGV_esa.Rows[4].Cells[0].Value = Image.FromFile("photo/cih.png");
            DGV_esa.Rows[4].Cells[1].Value = "cih bank";
            DGV_esa.Rows[4].Cells[2].Value = "Bank";
            DGV_esa.Rows[4].Cells[3].Value = "Rabat";
            DGV_esa.Rows[4].Cells[4].Value = "présedent";
            DGV_esa.Rows[4].Cells[5].Value = "1";
            /////////////////////////////////
            //DGV_esa.Rows.Add("Ofppt", "enseignement", "formateur", "3");
            DGV_esa.Rows[5].Cells[0].Value = Image.FromFile("photo/ofppt.png");
            DGV_esa.Rows[5].Cells[1].Value = "ofppt";
            DGV_esa.Rows[5].Cells[2].Value = "enseignement";
            DGV_esa.Rows[5].Cells[3].Value = "El Jadida";
            DGV_esa.Rows[5].Cells[4].Value = "formateur";
            DGV_esa.Rows[5].Cells[5].Value = "8";
            //DGV_esa.Rows.Add("ocp", "production", "gardin de sécurité", "11");
            DGV_esa.Rows[6].Cells[0].Value = Image.FromFile("photo/ocp.png");
            DGV_esa.Rows[6].Cells[1].Value = "ocp";
            DGV_esa.Rows[6].Cells[2].Value = "production";
            DGV_esa.Rows[6].Cells[3].Value = "El jarf esfar";
            DGV_esa.Rows[6].Cells[4].Value = "technisien";
            DGV_esa.Rows[6].Cells[5].Value = "25";
            //DGV_esa.Rows.Add("margane", "marche ", "chef de travail", "8");
            DGV_esa.Rows[7].Cells[0].Value = Image.FromFile("photo/marjane.png");
            DGV_esa.Rows[7].Cells[1].Value = "marjane";
            DGV_esa.Rows[7].Cells[2].Value = "marché";
            DGV_esa.Rows[7].Cells[3].Value = "Tanger";
            DGV_esa.Rows[7].Cells[4].Value = "chef de magazine";
            DGV_esa.Rows[7].Cells[5].Value = "8";
            
            string nomuser = conneect_admin_user.nom_user;
            if(conneect_admin_user.admin == true)
            {
                lb_userName.Text = "ADMIN";
                DGV_esa.ReadOnly = false;
                panel1.Visible = true;
                otil_admin.Visible = true;
                lb_welcome.Visible = true;
            }
            if (conneect_admin_user.admin == false)
            {
                lb_userName.Text = nomuser;
                panel1.Visible = false;
                //lb_welcome.Text = nomuser.ToUpper();
                DGV_esa.Location = new Point(210, 129);
                DGV_esa.Size = new Size(1055, 367);
                //panel_titre.Location = new Point(235, 27);
                lb_welcome.Visible = true;
                panel_quit_annul.Location = new Point(597, 493);
            }

        }
         

        private void DGV_esa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public object arr;
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //string[] arr = new string[] {   };
            DGV_esa.Rows.Add(guna2CirclePictureBox1.Image, TB_societee.Text, TB_categorie.Text, tb_ville.Text, TB_poste.Text, TB_nbpost.Text);

        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            if (DGV_esa.SelectedRows.Count > 0)
            {
                DGV_esa.Rows.RemoveAt(DGV_esa.SelectedRows[0].Index);
            }
        }

        private void btn_trier_Click(object sender, EventArgs e)
        {
            DGV_esa.Sort(DGV_esa.Columns[1], ListSortDirection.Ascending);
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            DGV_esa.Rows.Clear();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            guna2CirclePictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void developpementInformatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new DG_tdi();
            this.Hide();
            f.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_titre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
            /*
             // admin
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
            //Menu
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
            //Equipe
            Form f = new propos_equipe();
            f.Show();
            this.Hide();
            //question
            Form f = new question();
            f.Show();
            this.Hide();
             //app
            Form f = new infoApp();
            f.Show();
            this.Hide();
             */
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            f.Show();
            this.Hide();
        }

        private void aproposEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new propos_equipe();
            f.Show();

        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new question_f();
            f.Show();
        }

        private void aproposJoblinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new infoApp();
            f.Show();

        }

        private void contactAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form f = new contact();
             f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new message__admin();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGV_esa.Rows.Add(TB_societee.Text, TB_categorie.Text, TB_poste.Text, TB_nbpost.Text);
        }

        private void proposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new infoApp();
            f.Show();
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new propos_equipe();
            f.Show();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = DGV_esa.CurrentRow;

            guna2CirclePictureBox1.Image = (Image)dr.Cells[0].Value;
            TB_societee.Text = dr.Cells[1].Value.ToString();
            TB_categorie.Text = dr.Cells[2].Value.ToString();
            tb_ville.Text = dr.Cells[3].Value.ToString();
            TB_poste.Text = dr.Cells[4].Value.ToString();
            TB_nbpost.Text = dr.Cells[4].Value.ToString();
            DGV_esa.Rows.Remove(dr);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void DGV_esa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            
            int rowindex = e.RowIndex;
            if (rowindex == 0 && admiin == false)
            {
                Form f = new form_ciments();
                this.Hide();
                f.Show();

            }
            if (rowindex == 1 && admiin == false)
            {
                Form f = new form_afriquia();
                this.Hide();
                f.Show();
            }
            if (rowindex == 2 && admiin == false)
            {
                Form f = new Auto_hall();
                this.Hide();
                f.Show();
            }
            if (rowindex == 3 && admiin == false)
            {
                Form f = new form_al_mada();
                this.Hide();
                f.Show();
            }
            if (rowindex == 4 && admiin == false)
            {
                Form f = new Cih_Bank();
                this.Hide();
                f.Show();

            }
            if (rowindex == 5 && admiin == false)
            {
                Form f = new Ofppt();
                this.Hide();
                f.Show();
            }
            if (rowindex == 6 && admiin == false)
            {
                Form f = new form_ocp();
                this.Hide();
                f.Show();
            }
            if (rowindex == 7 && admiin == false)
            {
                Form f = new form_marjane();
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

        private void button5_Click_1(object sender, EventArgs e)
        {
             
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
          
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
