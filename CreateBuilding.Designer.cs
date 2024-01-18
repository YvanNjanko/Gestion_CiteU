namespace FrontEnd_Gestion_CiteU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            enterCode = new TextBox();
            enterEtage = new TextBox();
            enterRoom = new TextBox();
            enterPrix = new TextBox();
            enterBed = new TextBox();
            CreateBuildingBtn = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(CreateBuildingBtn);
            splitContainer1.Panel2.Controls.Add(enterBed);
            splitContainer1.Panel2.Controls.Add(enterPrix);
            splitContainer1.Panel2.Controls.Add(enterRoom);
            splitContainer1.Panel2.Controls.Add(enterEtage);
            splitContainer1.Panel2.Controls.Add(enterCode);
            splitContainer1.Panel2.Controls.Add(pictureBox3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1098, 568);
            splitContainer1.SplitterDistance = 205;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2089548F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 17);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 5;
            label1.Text = "Gestion";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(224, 29);
            label2.Name = "label2";
            label2.Size = new Size(388, 44);
            label2.TabIndex = 3;
            label2.Text = "Create New Building";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(646, 424);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(214, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // enterCode
            // 
            enterCode.Location = new Point(42, 139);
            enterCode.Multiline = true;
            enterCode.Name = "enterCode";
            enterCode.PlaceholderText = "Entrez le code du  batiment";
            enterCode.Size = new Size(327, 45);
            enterCode.TabIndex = 6;
            // 
            // enterEtage
            // 
            enterEtage.Location = new Point(42, 228);
            enterEtage.Multiline = true;
            enterEtage.Name = "enterEtage";
            enterEtage.PlaceholderText = "Entrez le nombre d'etage";
            enterEtage.Size = new Size(327, 45);
            enterEtage.TabIndex = 7;
            // 
            // enterRoom
            // 
            enterRoom.Location = new Point(42, 316);
            enterRoom.Multiline = true;
            enterRoom.Name = "enterRoom";
            enterRoom.PlaceholderText = "Entrez le nbre de chambre/etage";
            enterRoom.Size = new Size(327, 45);
            enterRoom.TabIndex = 8;
            // 
            // enterPrix
            // 
            enterPrix.Location = new Point(459, 139);
            enterPrix.Multiline = true;
            enterPrix.Name = "enterPrix";
            enterPrix.PlaceholderText = "Entrez le prix des chambres";
            enterPrix.Size = new Size(327, 45);
            enterPrix.TabIndex = 9;
            // 
            // enterBed
            // 
            enterBed.Location = new Point(459, 228);
            enterBed.Multiline = true;
            enterBed.Name = "enterBed";
            enterBed.PlaceholderText = "Entrez le nbre de lit(s) par chambre";
            enterBed.Size = new Size(327, 45);
            enterBed.TabIndex = 10;
            // 
            // CreateBuildingBtn
            // 
            CreateBuildingBtn.BackColor = Color.Black;
            CreateBuildingBtn.ForeColor = Color.White;
            CreateBuildingBtn.Location = new Point(459, 315);
            CreateBuildingBtn.Name = "CreateBuildingBtn";
            CreateBuildingBtn.Size = new Size(324, 46);
            CreateBuildingBtn.TabIndex = 11;
            CreateBuildingBtn.Text = "Create";
            CreateBuildingBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 424);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(214, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 115);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 13;
            label3.Text = "Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 204);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 14;
            label4.Text = "Etage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 292);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 15;
            label5.Text = "Chambre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 115);
            label6.Name = "label6";
            label6.Size = new Size(36, 21);
            label6.TabIndex = 16;
            label6.Text = "Prix";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(459, 213);
            label7.Name = "label7";
            label7.Size = new Size(35, 21);
            label7.TabIndex = 17;
            label7.Text = "Lits";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1098, 568);
            Controls.Add(splitContainer1);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button CreateBuildingBtn;
        private TextBox enterBed;
        private TextBox enterPrix;
        private TextBox enterRoom;
        private TextBox enterEtage;
        private TextBox enterCode;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}