namespace FrontEnd_Gestion_CiteU
{
    partial class AddStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStud));
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            addStudentBtn = new Button();
            enterNiveau = new TextBox();
            enterMat = new TextBox();
            enterAge = new TextBox();
            enterSex = new TextBox();
            EnterName = new TextBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            button3 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(18, 17);
            button1.Name = "button1";
            button1.Size = new Size(40, 27);
            button1.TabIndex = 24;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(472, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(457, 289);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 354);
            label7.Name = "label7";
            label7.Size = new Size(185, 21);
            label7.TabIndex = 18;
            label7.Text = "Niveau Academique";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 277);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 17;
            label6.Text = "Matricule";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 209);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 16;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 143);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 15;
            label4.Text = "Sexe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 78);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 14;
            label3.Text = "Noms Et Prenoms";
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.Black;
            addStudentBtn.ForeColor = Color.White;
            addStudentBtn.Location = new Point(67, 436);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(332, 51);
            addStudentBtn.TabIndex = 13;
            addStudentBtn.Text = "Add";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // enterNiveau
            // 
            enterNiveau.Location = new Point(65, 367);
            enterNiveau.Multiline = true;
            enterNiveau.Name = "enterNiveau";
            enterNiveau.Size = new Size(342, 37);
            enterNiveau.TabIndex = 7;
            enterNiveau.TextChanged += enterNiveau_TextChanged;
            // 
            // enterMat
            // 
            enterMat.Location = new Point(65, 291);
            enterMat.Multiline = true;
            enterMat.Name = "enterMat";
            enterMat.Size = new Size(342, 37);
            enterMat.TabIndex = 6;
            enterMat.TextChanged += enterMat_TextChanged;
            // 
            // enterAge
            // 
            enterAge.Location = new Point(65, 222);
            enterAge.Multiline = true;
            enterAge.Name = "enterAge";
            enterAge.Size = new Size(342, 37);
            enterAge.TabIndex = 5;
            enterAge.TextChanged += enterAge_TextChanged;
            // 
            // enterSex
            // 
            enterSex.Location = new Point(65, 154);
            enterSex.Multiline = true;
            enterSex.Name = "enterSex";
            enterSex.Size = new Size(342, 37);
            enterSex.TabIndex = 4;
            enterSex.TextChanged += enterSex_TextChanged;
            // 
            // EnterName
            // 
            EnterName.Location = new Point(65, 91);
            EnterName.Multiline = true;
            EnterName.Name = "EnterName";
            EnterName.Size = new Size(342, 37);
            EnterName.TabIndex = 3;
            EnterName.TextChanged += EnterName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(273, 15);
            label2.Name = "label2";
            label2.Size = new Size(332, 44);
            label2.TabIndex = 2;
            label2.Text = "Add New Student";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Black;
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(checkBox1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(addStudentBtn);
            splitContainer1.Panel2.Controls.Add(enterNiveau);
            splitContainer1.Panel2.Controls.Add(enterMat);
            splitContainer1.Panel2.Controls.Add(enterAge);
            splitContainer1.Panel2.Controls.Add(enterSex);
            splitContainer1.Panel2.Controls.Add(EnterName);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1135, 559);
            splitContainer1.SplitterDistance = 199;
            splitContainer1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button3.Location = new Point(539, 367);
            button3.Name = "button3";
            button3.Size = new Size(332, 51);
            button3.TabIndex = 27;
            button3.Text = "Display Student";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(539, 436);
            button2.Name = "button2";
            button2.Size = new Size(332, 51);
            button2.TabIndex = 26;
            button2.Text = "Delete Student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(911, 539);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 25;
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(161, 210);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // AddStud
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1135, 559);
            Controls.Add(splitContainer1);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddStud";
            Text = "AddStud";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button addStudentBtn;
        private TextBox enterNiveau;
        private TextBox enterMat;
        private TextBox enterAge;
        private TextBox enterSex;
        private TextBox EnterName;
        private Label label2;
        private SplitContainer splitContainer1;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox3;
    }
}