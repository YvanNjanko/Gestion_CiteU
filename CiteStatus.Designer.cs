namespace FrontEnd_Gestion_CiteU
{
    partial class CiteStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiteStatus));
            button1 = new Button();
            labelTotalBuildings = new Label();
            labelTotalRevenue = new Label();
            labelOccupiedRooms = new Label();
            labelTotalRooms = new Label();
            labelTotalGains2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            labelTotalR = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 27);
            button1.TabIndex = 27;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTotalBuildings
            // 
            labelTotalBuildings.AutoSize = true;
            labelTotalBuildings.Location = new Point(70, 121);
            labelTotalBuildings.Name = "labelTotalBuildings";
            labelTotalBuildings.Size = new Size(164, 21);
            labelTotalBuildings.TabIndex = 28;
            labelTotalBuildings.Text = "Nombre Batiments";
            // 
            // labelTotalRevenue
            // 
            labelTotalRevenue.AutoSize = true;
            labelTotalRevenue.Location = new Point(70, 290);
            labelTotalRevenue.Name = "labelTotalRevenue";
            labelTotalRevenue.Size = new Size(137, 21);
            labelTotalRevenue.TabIndex = 29;
            labelTotalRevenue.Text = "Chiffre d'Affaire";
            // 
            // labelOccupiedRooms
            // 
            labelOccupiedRooms.AutoSize = true;
            labelOccupiedRooms.Location = new Point(70, 235);
            labelOccupiedRooms.Name = "labelOccupiedRooms";
            labelOccupiedRooms.Size = new Size(285, 21);
            labelOccupiedRooms.TabIndex = 30;
            labelOccupiedRooms.Text = "Nombre Chambre(s) Occupee(s)";
            // 
            // labelTotalRooms
            // 
            labelTotalRooms.AutoSize = true;
            labelTotalRooms.Location = new Point(70, 179);
            labelTotalRooms.Name = "labelTotalRooms";
            labelTotalRooms.Size = new Size(235, 21);
            labelTotalRooms.TabIndex = 31;
            labelTotalRooms.Text = "Nombre Total de Chambre";
            // 
            // labelTotalGains2
            // 
            labelTotalGains2.AutoSize = true;
            labelTotalGains2.Location = new Point(70, 345);
            labelTotalGains2.Name = "labelTotalGains2";
            labelTotalGains2.Size = new Size(132, 21);
            labelTotalGains2.TabIndex = 32;
            labelTotalGains2.Text = "Gains Cumules";
            labelTotalGains2.Click += labelTotalGains2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(558, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 427);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(164, 450);
            button2.Name = "button2";
            button2.Size = new Size(189, 38);
            button2.TabIndex = 34;
            button2.Text = "Manage Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelTotalR
            // 
            labelTotalR.AutoSize = true;
            labelTotalR.Location = new Point(70, 403);
            labelTotalR.Name = "labelTotalR";
            labelTotalR.Size = new Size(200, 21);
            labelTotalR.TabIndex = 35;
            labelTotalR.Text = "Nombre de Resident(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18.2686558F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(164, 43);
            label2.Name = "label2";
            label2.Size = new Size(205, 40);
            label2.TabIndex = 36;
            label2.Text = "'C.U. Status'";
            // 
            // CiteStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1132, 577);
            Controls.Add(label2);
            Controls.Add(labelTotalR);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(labelTotalGains2);
            Controls.Add(labelTotalRooms);
            Controls.Add(labelOccupiedRooms);
            Controls.Add(labelTotalRevenue);
            Controls.Add(labelTotalBuildings);
            Controls.Add(button1);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CiteStatus";
            Text = "CiteStatus";
            Load += CiteStatus_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelTotalBuildings;
        private Label labelTotalRevenue;
        private Label labelOccupiedRooms;
        private Label labelTotalRooms;
        private Label labelTotalGains2;
        private PictureBox pictureBox1;
        private Button button2;
        private Label labelTotalR;
        private Label label2;
    }
}