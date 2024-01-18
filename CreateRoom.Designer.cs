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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1096, 556);
            splitContainer1.SplitterDistance = 209;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2089548F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 7;
            label1.Text = "Gestion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            // textBox1
            // 
            textBox1.Location = new Point(46, 144);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Entrez le code du batiment";
            textBox1.Size = new Size(393, 45);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 239);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Entrez le numero de l'etage";
            textBox2.Size = new Size(393, 45);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(107, 329);
            button1.Name = "button1";
            button1.Size = new Size(268, 54);
            button1.TabIndex = 7;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 120);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 9;
            label3.Text = "Code";
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
            // CreateRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1096, 556);
            Controls.Add(splitContainer1);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreateRoom";
            Text = "CreateRoom";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}