﻿namespace FrontEnd_Gestion_CiteU
{
    partial class NewBuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBuild));
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            CreateBuildingBtn = new Button();
            enterBed = new TextBox();
            enterPrix = new TextBox();
            enterRoom = new TextBox();
            enterEtage = new TextBox();
            enterCode = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 260);
            label7.Name = "label7";
            label7.Size = new Size(35, 21);
            label7.TabIndex = 17;
            label7.Text = "Lits";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(536, 171);
            label6.Name = "label6";
            label6.Size = new Size(36, 21);
            label6.TabIndex = 16;
            label6.Text = "Prix";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 333);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 15;
            label5.Text = "Chambre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 252);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 14;
            label4.Text = "Etage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 171);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 13;
            label3.Text = "Code";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 525);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // CreateBuildingBtn
            // 
            CreateBuildingBtn.BackColor = Color.Black;
            CreateBuildingBtn.ForeColor = Color.White;
            CreateBuildingBtn.Location = new Point(536, 354);
            CreateBuildingBtn.Name = "CreateBuildingBtn";
            CreateBuildingBtn.Size = new Size(379, 54);
            CreateBuildingBtn.TabIndex = 11;
            CreateBuildingBtn.Text = "Create";
            CreateBuildingBtn.UseVisualStyleBackColor = false;
            CreateBuildingBtn.Click += CreateBuildingBtn_Click;
            // 
            // enterBed
            // 
            enterBed.Location = new Point(536, 274);
            enterBed.Multiline = true;
            enterBed.Name = "enterBed";
            enterBed.PlaceholderText = "Entrez le nbre de lit(s) par chambre";
            enterBed.Size = new Size(382, 53);
            enterBed.TabIndex = 10;
            enterBed.TextChanged += enterBed_TextChanged;
            // 
            // enterPrix
            // 
            enterPrix.Location = new Point(536, 193);
            enterPrix.Multiline = true;
            enterPrix.Name = "enterPrix";
            enterPrix.PlaceholderText = "Entrez le prix des chambres";
            enterPrix.Size = new Size(382, 53);
            enterPrix.TabIndex = 9;
            enterPrix.TextChanged += enterPrix_TextChanged;
            // 
            // enterRoom
            // 
            enterRoom.Location = new Point(73, 355);
            enterRoom.Multiline = true;
            enterRoom.Name = "enterRoom";
            enterRoom.PlaceholderText = "Entrez le nbre de chambre/etage";
            enterRoom.Size = new Size(382, 53);
            enterRoom.TabIndex = 8;
            enterRoom.TextChanged += enterRoom_TextChanged;
            // 
            // enterEtage
            // 
            enterEtage.Location = new Point(73, 274);
            enterEtage.Multiline = true;
            enterEtage.Name = "enterEtage";
            enterEtage.PlaceholderText = "Entrez le nombre d'etage";
            enterEtage.Size = new Size(382, 53);
            enterEtage.TabIndex = 7;
            enterEtage.TextChanged += enterEtage_TextChanged;
            // 
            // enterCode
            // 
            enterCode.Location = new Point(73, 193);
            enterCode.Multiline = true;
            enterCode.Name = "enterCode";
            enterCode.PlaceholderText = "Entrez le code du  batiment";
            enterCode.Size = new Size(382, 53);
            enterCode.TabIndex = 6;
            enterCode.TextChanged += enterCode_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(746, 525);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(261, 171);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.9552231F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(262, 52);
            label2.Name = "label2";
            label2.Size = new Size(415, 46);
            label2.TabIndex = 3;
            label2.Text = "Create New Building";
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
            splitContainer1.Panel1.Controls.Add(pictureBox4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
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
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1228, 696);
            splitContainer1.SplitterDistance = 228;
            splitContainer1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(32, 207);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(161, 234);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(40, 27);
            button1.TabIndex = 26;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewBuild
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1228, 696);
            Controls.Add(splitContainer1);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewBuild";
            Text = "NewBuild";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private Button CreateBuildingBtn;
        private TextBox enterBed;
        private TextBox enterPrix;
        private TextBox enterRoom;
        private TextBox enterEtage;
        private TextBox enterCode;
        private PictureBox pictureBox3;
        private Label label2;
        private SplitContainer splitContainer1;
        private Button button1;
        private PictureBox pictureBox4;
    }
}