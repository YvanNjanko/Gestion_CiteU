﻿namespace FrontEnd_Gestion_CiteU
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
            dataGridViewBuildings = new DataGridView();
            label2 = new Label();
            addStudentBtn = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBuildings
            // 
            dataGridViewBuildings.BackgroundColor = Color.GhostWhite;
            dataGridViewBuildings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuildings.Location = new Point(422, 85);
            dataGridViewBuildings.Name = "dataGridViewBuildings";
            dataGridViewBuildings.RowHeadersWidth = 57;
            dataGridViewBuildings.RowTemplate.Height = 32;
            dataGridViewBuildings.Size = new Size(675, 404);
            dataGridViewBuildings.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8805962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(592, 25);
            label2.Name = "label2";
            label2.Size = new Size(323, 44);
            label2.TabIndex = 5;
            label2.Text = "'All Your Students'";
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = Color.Black;
            addStudentBtn.ForeColor = Color.White;
            addStudentBtn.Location = new Point(41, 278);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(332, 51);
            addStudentBtn.TabIndex = 14;
            addStudentBtn.Text = "Add";
            addStudentBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.Location = new Point(41, 359);
            button2.Name = "button2";
            button2.Size = new Size(332, 51);
            button2.TabIndex = 27;
            button2.Text = "Delete Student";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 438);
            button1.Name = "button1";
            button1.Size = new Size(332, 51);
            button1.TabIndex = 28;
            button1.Text = "Delete Student";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 3);
            button3.Name = "button3";
            button3.Size = new Size(40, 27);
            button3.TabIndex = 29;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DisplayStud
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1119, 588);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(addStudentBtn);
            Controls.Add(label2);
            Controls.Add(dataGridViewBuildings);
            Font = new Font("Century Gothic", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DisplayStud";
            Text = "DisplayStud";
            Load += DisplayStud_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuildings).EndInit();
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
    }
}