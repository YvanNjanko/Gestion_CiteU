namespace FrontEnd_Gestion_CiteU
{
    partial class ManagePay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePay));
            label2 = new Label();
            dataGridViewBuildings = new DataGridView();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            addStudentBtn = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(629, 59);
            label2.Name = "label2";
            label2.Size = new Size(420, 44);
            label2.TabIndex = 8;
            label2.Text = "'Payment Informations'";
            // 
            // dataGridViewBuildings
            // 
            dataGridViewBuildings.BackgroundColor = Color.GhostWhite;
            dataGridViewBuildings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuildings.Location = new Point(473, 119);
            dataGridViewBuildings.Name = "dataGridViewBuildings";
            dataGridViewBuildings.RowHeadersWidth = 57;
            dataGridViewBuildings.RowTemplate.Height = 32;
            dataGridViewBuildings.Size = new Size(721, 407);
            dataGridViewBuildings.TabIndex = 7;
            // 
            // button6
            // 
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(40, 27);
            button6.TabIndex = 56;
            button6.Text = "<";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(85, 475);
            button1.Name = "button1";
            button1.Size = new Size(294, 51);
            button1.TabIndex = 59;
            button1.Text = "View Payment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(115, 406);
            button2.Name = "button2";
            button2.Size = new Size(227, 51);
            button2.TabIndex = 58;
            button2.Text = "Cancel Payment";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.Black;
            addStudentBtn.ForeColor = Color.White;
            addStudentBtn.Location = new Point(85, 335);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(294, 51);
            addStudentBtn.TabIndex = 57;
            addStudentBtn.Text = "Valider Paiement";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            button4.Location = new Point(745, 542);
            button4.Name = "button4";
            button4.Size = new Size(237, 54);
            button4.TabIndex = 61;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1164, 72);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 62;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button3.Location = new Point(115, 543);
            button3.Name = "button3";
            button3.Size = new Size(227, 51);
            button3.TabIndex = 63;
            button3.Text = "Delete Resident";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ManagePay
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1215, 661);
            Controls.Add(button3);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(addStudentBtn);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(dataGridViewBuildings);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ManagePay";
            Text = "ManagePay";
            Load += ManagePay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewBuildings;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button addStudentBtn;
        private PictureBox pictureBox1;
        private Button button4;
        private PictureBox pictureBox3;
        private Button button3;
    }
}