namespace FrontEnd_Gestion_CiteU
{
    partial class ViewPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPay));
            label2 = new Label();
            dataGridViewBuildings = new DataGridView();
            button6 = new Button();
            labelTotalGains2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(527, 37);
            label2.Name = "label2";
            label2.Size = new Size(391, 44);
            label2.TabIndex = 10;
            label2.Text = "'Validated Payments'";
            // 
            // dataGridViewBuildings
            // 
            dataGridViewBuildings.BackgroundColor = Color.GhostWhite;
            dataGridViewBuildings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuildings.Location = new Point(368, 94);
            dataGridViewBuildings.Name = "dataGridViewBuildings";
            dataGridViewBuildings.RowHeadersWidth = 57;
            dataGridViewBuildings.RowTemplate.Height = 32;
            dataGridViewBuildings.Size = new Size(719, 404);
            dataGridViewBuildings.TabIndex = 9;
            // 
            // button6
            // 
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(40, 27);
            button6.TabIndex = 57;
            button6.Text = "<";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // labelTotalGains2
            // 
            labelTotalGains2.AutoSize = true;
            labelTotalGains2.Font = new Font("Century Gothic", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalGains2.Location = new Point(14, 108);
            labelTotalGains2.Name = "labelTotalGains2";
            labelTotalGains2.Size = new Size(178, 22);
            labelTotalGains2.TabIndex = 58;
            labelTotalGains2.Text = "Paiements valides:";
            labelTotalGains2.Click += labelTotalGains2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 151);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 59;
            label1.Text = "Gains Cumules:";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // ViewPay
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1101, 565);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(labelTotalGains2);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(dataGridViewBuildings);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ViewPay";
            Text = "ViewPay";
            Load += ViewPay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewBuildings;
        private Button button6;
        private Label labelTotalGains2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}