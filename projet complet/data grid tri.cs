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
    public partial class DG_tri : Form
    {
        public DG_tri()
        {
            InitializeComponent();
        }
        public static bool admiin = conneect_admin_user.admin;

            

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }        
        private void DG_tri_Load(object sender, EventArgs e)
        {
            DGV_tri.Rows.Add(8);
            //dt.Rows.Add("Orange", "communication", "chef d'agence", "29");

            /////////////////////////////////
            DGV_tri.Rows[0].Cells[0].Value = Image.FromFile("photo/orange.png");
            DGV_tri.Rows[0].Cells[1].Value = "Orange";
            DGV_tri.Rows[0].Cells[2].Value = "communication";
            DGV_tri.Rows[0].Cells[3].Value = "El Jadida";
            DGV_tri.Rows[0].Cells[4].Value = "chef d'agence";
            DGV_tri.Rows[0].Cells[5].Value = "2 ";
            /////////////////////////////////
            //dt.Rows.Add("Attijariwafabank", "bbank", "secueite", "3");

            DGV_tri.Rows[1].Cells[0].Value = Image.FromFile("photo/wafa.jpg");
            DGV_tri.Rows[1].Cells[1].Value = "Attijariwafaabank";
            DGV_tri.Rows[1].Cells[2].Value = "bank";
            DGV_tri.Rows[1].Cells[3].Value = "Casa Blanca";
            DGV_tri.Rows[1].Cells[4].Value = "Commercial";
            DGV_tri.Rows[0].Cells[5].Value = "3";
            /////////////////////////////////
            //dt.Rows.Add("Group ocp", "Production", "contabilitée", "21");


            DGV_tri.Rows[2].Cells[0].Value = Image.FromFile("photo/ram.jpg");
            DGV_tri.Rows[2].Cells[1].Value = "Royal";
            DGV_tri.Rows[2].Cells[2].Value = "Royal air Maroc";
            DGV_tri.Rows[2].Cells[3].Value = "Rabat";
            DGV_tri.Rows[2].Cells[4].Value = "technicien";
            DGV_tri.Rows[2].Cells[5].Value = "16";
            /////////////////////////////////
            //dt.Rows.Add("Bmce", "Technologie", "chef de travail", "23");



            DGV_tri.Rows[3].Cells[0].Value = Image.FromFile("photo/marjane.png");
            DGV_tri.Rows[3].Cells[1].Value = "Marjane";
            DGV_tri.Rows[3].Cells[2].Value = "Marche";
            DGV_tri.Rows[3].Cells[3].Value = "Marrakech";
            DGV_tri.Rows[3].Cells[4].Value = "Gestion de magazin";
            DGV_tri.Rows[3].Cells[5].Value = "2";
            /////////////////////////////////
            //dt.Rows.Add("dell", "Technologie", "gerer", "23");

            DGV_tri.Rows[4].Cells[0].Value = Image.FromFile("photo/dell.jpg");
            DGV_tri.Rows[4].Cells[1].Value = "dell";
            DGV_tri.Rows[4].Cells[2].Value = "technologie";
            DGV_tri.Rows[4].Cells[3].Value = "france";
            DGV_tri.Rows[4].Cells[4].Value = "intellegent";
            DGV_tri.Rows[4].Cells[5].Value = "9";
            /////////////////////////////////
            // dt.Rows.Add("city bus", "tronspeur", "conducteur ", "50");

            DGV_tri.Rows[5].Cells[0].Value = Image.FromFile("photo/bus.png");
            DGV_tri.Rows[5].Cells[1].Value = "city bus";
            DGV_tri.Rows[5].Cells[2].Value = "tronsport";
            DGV_tri.Rows[5].Cells[3].Value = "El Jadida";
            DGV_tri.Rows[5].Cells[4].Value = "conducteur";
            DGV_tri.Rows[5].Cells[5].Value = "8";
            //dt.Rows.Add("cent un", "resturant", "developpeur", "2");


            DGV_tri.Rows[6].Cells[0].Value = Image.FromFile("photo/centun.jpg");
            DGV_tri.Rows[6].Cells[1].Value = "cent un";
            DGV_tri.Rows[6].Cells[2].Value = "resturant";
            DGV_tri.Rows[6].Cells[3].Value = "el jadida";
            DGV_tri.Rows[6].Cells[4].Value = "cuisine";
            DGV_tri.Rows[6].Cells[5].Value = "5";
            //dt.Rows.Add("google", "service", "chef d equipe", "1");

            DGV_tri.Rows[7].Cells[0].Value = Image.FromFile("photo/google.png");
            DGV_tri.Rows[7].Cells[1].Value = "google";
            DGV_tri.Rows[7].Cells[2].Value = "service";
            DGV_tri.Rows[7].Cells[3].Value = "international";
            DGV_tri.Rows[7].Cells[4].Value = "developpeur";
            DGV_tri.Rows[7].Cells[5].Value = "40";

            string email__admin = conneect_admin_user.email_admin;
            if (conneect_admin_user.admin == true)
            {
                lb_useName.Text = "ADMIN";
                DGV_tri.ReadOnly = true;
                otil_admin.Visible = true;
                lb_welcome.Visible = true;
            }
            if (conneect_admin_user.admin == false)
            {
                string nomuser = conneect_admin_user.nom_user;
                lb_useName.Text = nomuser;
                //lb_welcome.Text = nomuser.ToUpper();
                DGV_tri.Location = new Point(210, 129);
                DGV_tri.Size=new Size(1061,355);
                //panel_titre.Location = new Point(150, 10);
                panel_quit_annul.Location = new Point(600, 493);
            }


            if (conneect_admin_user.admin == true)
            {
                panel1.Visible = true; 
            }
            if (conneect_admin_user.admin == false)
            {  
                panel1.Visible = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public object arr ;
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //string[] arr = new string[] { };
            DGV_tri.Rows.Add(guna2CirclePictureBox1.Image, TB_societee.Text, TB_categorie.Text, tb_ville.Text, TB_poste.Text, TB_nbpost.Text);


        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            if(DGV_tri.SelectedRows.Count>0)
            {
                DGV_tri.Rows.RemoveAt(DGV_tri.SelectedRows[0].Index);
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = DGV_tri.CurrentRow;
            guna2CirclePictureBox1.Image = (Image)dr.Cells[0].Value;
            TB_societee.Text = dr.Cells[1].Value.ToString();
            TB_categorie.Text = dr.Cells[2].Value.ToString();
            tb_ville.Text = dr.Cells[3].Value.ToString();
            TB_poste.Text = dr.Cells[4].Value.ToString();
            TB_nbpost.Text = dr.Cells[4].Value.ToString();

            DGV_tri.Rows.Remove(dr);
            // this is still vide 
        }

        private void btn_trier_Click(object sender, EventArgs e)
        {
            DGV_tri.Sort(DGV_tri.Columns[1], ListSortDirection.Ascending);
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            DGV_tri.Rows.Clear();
        }
        #region
        private void btn_import_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }
#endregion
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
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new question_f();
            f.Show();
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new message__admin();
            f.Show();
                
        }
        #region
        private void otil_admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new conneect_admin_user();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
        #region
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_tri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = e.RowIndex;
            if (rowindex == 0)
            {
                Form f = new form_orange();
                this.Hide();
                f.Show();

            }
            if (rowindex == 1)
            {
                Form f = new form_attijariwafabank();
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
                Form f = new dell();
                this.Hide();
                f.Show();
            }
            if (rowindex == 5)
            {
                Form f = new City_bus();
                this.Hide();
                f.Show();
            }
            if (rowindex == 6)
            {
                Form f = new Cent_un();
                this.Hide();
                f.Show();
            }
            if (rowindex == 7)
            {
                Form f = new google();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
