
namespace projet_complet
{
    partial class question_f
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(question_f));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P_okk = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PB_attt = new System.Windows.Forms.ProgressBar();
            this.PB_wait = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.P_okk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_wait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quel est votre problème ?";
            // 
            // tb_question
            // 
            this.tb_question.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_question.Location = new System.Drawing.Point(52, 253);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(339, 75);
            this.tb_question.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-25, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Publier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.P_okk);
            this.panel1.Controls.Add(this.PB_attt);
            this.panel1.Controls.Add(this.PB_wait);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tb_question);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(112, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 464);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // P_okk
            // 
            this.P_okk.BackColor = System.Drawing.Color.Gainsboro;
            this.P_okk.Controls.Add(this.button2);
            this.P_okk.Controls.Add(this.label2);
            this.P_okk.Location = new System.Drawing.Point(34, 81);
            this.P_okk.Name = "P_okk";
            this.P_okk.Size = new System.Drawing.Size(379, 146);
            this.P_okk.TabIndex = 8;
            this.P_okk.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(143, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(82, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Publier avec succes";
            // 
            // PB_attt
            // 
            this.PB_attt.Location = new System.Drawing.Point(91, 449);
            this.PB_attt.Name = "PB_attt";
            this.PB_attt.Size = new System.Drawing.Size(256, 8);
            this.PB_attt.TabIndex = 7;
            this.PB_attt.Visible = false;
            // 
            // PB_wait
            // 
            this.PB_wait.Image = global::projet_complet.Properties.Resources.cupertino_activity_indicator1;
            this.PB_wait.Location = new System.Drawing.Point(150, 178);
            this.PB_wait.Name = "PB_wait";
            this.PB_wait.Size = new System.Drawing.Size(132, 110);
            this.PB_wait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_wait.TabIndex = 6;
            this.PB_wait.TabStop = false;
            this.PB_wait.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Question";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projet_complet.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(52, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // question_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(668, 508);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "question_f";
            this.Text = "question";
            this.Load += new System.EventHandler(this.question_f_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.P_okk.ResumeLayout(false);
            this.P_okk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_wait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PB_wait;
        private System.Windows.Forms.Panel P_okk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PB_attt;
        private System.Windows.Forms.Timer timer1;
    }
}