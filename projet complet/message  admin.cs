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
    public partial class message__admin : Form
    {
        public message__admin()
        {
            InitializeComponent();
        }
           //List<string> lst = question.l;
           
        private void message__admin_Load(object sender, EventArgs e)
        {
            // print list  of questions in list Box 
            List<string> ll = question_f.questions;
            List<string> lll = contact.messages;
            list_questions.Items.AddRange(ll.ToArray());
            list_messages.Items.AddRange(lll.ToArray());


            //foreach(string item in lll)
            //{
            //    list_questions.Items.Add(item);
            //}
        }

        private void btn_voir_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_questions.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list_messages.Items.Clear();
        }

        private void tn_delet_Click(object sender, EventArgs e)
        {
            // button delete 
            list_questions.Items.Remove(list_questions.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // button delete 
            list_messages.Items.Remove(list_messages.SelectedItem);
        }

        private void question_Click(object sender, EventArgs e)
        {

        }

        private void list_questions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
