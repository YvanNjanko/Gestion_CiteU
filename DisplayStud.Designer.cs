namespace FrontEnd_Gestion_CiteU
{
    partial class DisplayStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayStud));
            dataGridViewBuildings = new DataGridView();
            label2 = new Label();
            addStudentBtn = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBuildings
            // 
            dataGridViewBuildings.BackgroundColor = Color.GhostWhite;
            dataGridViewBuildings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuildings.Location = new Point(499, 95);
            dataGridViewBuildings.Name = "dataGridViewBuildings";
            dataGridViewBuildings.RowHeadersWidth = 57;
            dataGridViewBuildings.RowTemplate.Height = 32;
            dataGridViewBuildings.Size = new Size(697, 404);
            dataGridViewBuildings.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(681, 35);
            label2.Name = "label2";
            label2.Size = new Size(323, 44);
            label2.TabIndex = 5;
            label2.Text = "'All Your Students'";
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.Black;
            addStudentBtn.ForeColor = Color.White;
            addStudentBtn.Location = new Point(78, 324);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(332, 51);
            addStudentBtn.TabIndex = 14;
            addStudentBtn.Text = "Affect Student";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(123, 401);
            button2.Name = "button2";
            button2.Size = new Size(244, 51);
            button2.TabIndex = 27;
            button2.Text = "Delete Student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(78, 484);
            button1.Name = "button1";
            button1.Size = new Size(332, 51);
            button1.TabIndex = 28;
            button1.Text = "Our Residents";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(40, 27);
            button3.TabIndex = 29;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1168, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            button4.Location = new Point(747, 534);
            button4.Name = "button4";
            button4.Size = new Size(235, 51);
            button4.TabIndex = 37;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // DisplayStud
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1208, 659);
            Controls.Add(button4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(addStudentBtn);
            Controls.Add(label2);
            Controls.Add(dataGridViewBuildings);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DisplayStud";
            Text = "DisplayStud";
            Load += DisplayStud_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBuildings;
        private Label label2;
        private Button addStudentBtn;
        private Button button2;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button4;
    }
}