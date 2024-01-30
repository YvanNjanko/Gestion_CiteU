namespace FrontEnd_Gestion_CiteU
{
    partial class CheckResd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckResd));
            dataGridViewBuildings = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            addStudentBtn = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBuildings
            // 
            dataGridViewBuildings.BackgroundColor = Color.GhostWhite;
            dataGridViewBuildings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuildings.Location = new Point(615, 113);
            dataGridViewBuildings.Name = "dataGridViewBuildings";
            dataGridViewBuildings.RowHeadersWidth = 57;
            dataGridViewBuildings.RowTemplate.Height = 32;
            dataGridViewBuildings.Size = new Size(499, 407);
            dataGridViewBuildings.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(709, 40);
            label2.Name = "label2";
            label2.Size = new Size(339, 44);
            label2.TabIndex = 6;
            label2.Text = "'All Your Residents'";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(417, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(140, 395);
            button2.Name = "button2";
            button2.Size = new Size(307, 51);
            button2.TabIndex = 32;
            button2.Text = "Delete Resident";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.Black;
            addStudentBtn.ForeColor = Color.White;
            addStudentBtn.Location = new Point(179, 464);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(235, 51);
            addStudentBtn.TabIndex = 31;
            addStudentBtn.Text = "Refresh";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(40, 27);
            button3.TabIndex = 34;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CheckResd
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1179, 635);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(addStudentBtn);
            Controls.Add(label2);
            Controls.Add(dataGridViewBuildings);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CheckResd";
            Text = "CheckResd";
            Load += CheckResd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBuildings;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button addStudentBtn;
        private Button button3;
    }
}