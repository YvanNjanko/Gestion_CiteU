namespace FrontEnd_Gestion_CiteU
{
    partial class AddBed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBed));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            enterCode = new TextBox();
            createRoomBtn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 27);
            button1.TabIndex = 26;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(525, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(565, 487);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(128, 33);
            label2.Name = "label2";
            label2.Size = new Size(281, 44);
            label2.TabIndex = 28;
            label2.Text = "'Add New Bed'";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 165);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 30;
            label3.Text = "Code";
            // 
            // enterCode
            // 
            enterCode.Location = new Point(99, 189);
            enterCode.Multiline = true;
            enterCode.Name = "enterCode";
            enterCode.PlaceholderText = "Entrez le code de la chambre";
            enterCode.Size = new Size(393, 45);
            enterCode.TabIndex = 29;
            enterCode.TextChanged += enterCode_TextChanged;
            // 
            // createRoomBtn
            // 
            createRoomBtn.BackColor = Color.Black;
            createRoomBtn.ForeColor = Color.White;
            createRoomBtn.Location = new Point(141, 267);
            createRoomBtn.Name = "createRoomBtn";
            createRoomBtn.Size = new Size(268, 54);
            createRoomBtn.TabIndex = 31;
            createRoomBtn.Text = "Add";
            createRoomBtn.UseVisualStyleBackColor = false;
            createRoomBtn.Click += createRoomBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(141, 342);
            button2.Name = "button2";
            button2.Size = new Size(268, 54);
            button2.TabIndex = 33;
            button2.Text = "Delete Bed";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddBed
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1112, 581);
            Controls.Add(button2);
            Controls.Add(createRoomBtn);
            Controls.Add(label3);
            Controls.Add(enterCode);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBed";
            Text = "AddBed";
            Load += AddBed_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox enterCode;
        private Button createRoomBtn;
        private Button button2;
    }
}