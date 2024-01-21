namespace FrontEnd_Gestion_CiteU
{
    partial class CreateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoom));
            splitContainer1 = new SplitContainer();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            createRoomBtn = new Button();
            enterEtage = new TextBox();
            enterCode = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(createRoomBtn);
            splitContainer1.Panel2.Controls.Add(enterEtage);
            splitContainer1.Panel2.Controls.Add(enterCode);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1096, 556);
            splitContainer1.SplitterDistance = 209;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 144);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(161, 233);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(107, 408);
            button2.Name = "button2";
            button2.Size = new Size(268, 54);
            button2.TabIndex = 26;
            button2.Text = "Delete Room";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 34);
            button1.Name = "button1";
            button1.Size = new Size(40, 27);
            button1.TabIndex = 25;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 215);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 10;
            label4.Text = "Etage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 120);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 9;
            label3.Text = "Code";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(479, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(370, 356);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // createRoomBtn
            // 
            createRoomBtn.BackColor = Color.Black;
            createRoomBtn.ForeColor = Color.White;
            createRoomBtn.Location = new Point(107, 329);
            createRoomBtn.Name = "createRoomBtn";
            createRoomBtn.Size = new Size(268, 54);
            createRoomBtn.TabIndex = 7;
            createRoomBtn.Text = "Create";
            createRoomBtn.UseVisualStyleBackColor = false;
            createRoomBtn.Click += createRoomBtn_Click;
            // 
            // enterEtage
            // 
            enterEtage.Location = new Point(46, 239);
            enterEtage.Multiline = true;
            enterEtage.Name = "enterEtage";
            enterEtage.PlaceholderText = "Entrez le numero de l'etage";
            enterEtage.Size = new Size(393, 45);
            enterEtage.TabIndex = 6;
            enterEtage.TextChanged += enterEtage_TextChanged;
            // 
            // enterCode
            // 
            enterCode.Location = new Point(46, 144);
            enterCode.Multiline = true;
            enterCode.Name = "enterCode";
            enterCode.PlaceholderText = "Entrez le code du batiment";
            enterCode.Size = new Size(393, 45);
            enterCode.TabIndex = 5;
            enterCode.TextChanged += enterCode_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(240, 26);
            label2.Name = "label2";
            label2.Size = new Size(351, 44);
            label2.TabIndex = 4;
            label2.Text = "Create New Room";
            // 
            // CreateRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1096, 556);
            Controls.Add(splitContainer1);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateRoom";
            Text = "CreateRoom";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox2;
        private Button createRoomBtn;
        private TextBox enterEtage;
        private TextBox enterCode;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox3;
    }
}