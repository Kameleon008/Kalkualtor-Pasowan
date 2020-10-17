namespace Kalkulator_Pasowan
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxRollerTolerance = new System.Windows.Forms.ComboBox();
            this.comboBoxRollerClass = new System.Windows.Forms.ComboBox();
            this.labelRollerTitle = new System.Windows.Forms.Label();
            this.labelRollerClass = new System.Windows.Forms.Label();
            this.labelRollTolerance = new System.Windows.Forms.Label();
            this.labelRollDiameter = new System.Windows.Forms.Label();
            this.textBoxRollDiameter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRollerTolerance
            // 
            this.comboBoxRollerTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRollerTolerance.FormattingEnabled = true;
            this.comboBoxRollerTolerance.Location = new System.Drawing.Point(181, 152);
            this.comboBoxRollerTolerance.Name = "comboBoxRollerTolerance";
            this.comboBoxRollerTolerance.Size = new System.Drawing.Size(82, 28);
            this.comboBoxRollerTolerance.TabIndex = 0;
            this.comboBoxRollerTolerance.SelectedIndexChanged += new System.EventHandler(this.comboBoxRollerTolerance_SelectedIndexChanged);
            // 
            // comboBoxRollerClass
            // 
            this.comboBoxRollerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRollerClass.FormattingEnabled = true;
            this.comboBoxRollerClass.Location = new System.Drawing.Point(181, 186);
            this.comboBoxRollerClass.Name = "comboBoxRollerClass";
            this.comboBoxRollerClass.Size = new System.Drawing.Size(82, 28);
            this.comboBoxRollerClass.TabIndex = 1;
            this.comboBoxRollerClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxRollerClass_SelectedIndexChanged);
            // 
            // labelRollerTitle
            // 
            this.labelRollerTitle.AutoSize = true;
            this.labelRollerTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.labelRollerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRollerTitle.ForeColor = System.Drawing.Color.White;
            this.labelRollerTitle.Location = new System.Drawing.Point(24, 61);
            this.labelRollerTitle.Name = "labelRollerTitle";
            this.labelRollerTitle.Size = new System.Drawing.Size(94, 31);
            this.labelRollerTitle.TabIndex = 5;
            this.labelRollerTitle.Text = "Wałek";
            // 
            // labelRollerClass
            // 
            this.labelRollerClass.AutoSize = true;
            this.labelRollerClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.labelRollerClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRollerClass.ForeColor = System.Drawing.Color.White;
            this.labelRollerClass.Location = new System.Drawing.Point(26, 190);
            this.labelRollerClass.Name = "labelRollerClass";
            this.labelRollerClass.Size = new System.Drawing.Size(149, 19);
            this.labelRollerClass.TabIndex = 8;
            this.labelRollerClass.Text = "Klasa dokładności IT:";
            this.labelRollerClass.Click += new System.EventHandler(this.labelRollerClass_Click);
            // 
            // labelRollTolerance
            // 
            this.labelRollTolerance.AutoSize = true;
            this.labelRollTolerance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.labelRollTolerance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRollTolerance.ForeColor = System.Drawing.Color.White;
            this.labelRollTolerance.Location = new System.Drawing.Point(62, 156);
            this.labelRollTolerance.Name = "labelRollTolerance";
            this.labelRollTolerance.Size = new System.Drawing.Size(113, 19);
            this.labelRollTolerance.TabIndex = 7;
            this.labelRollTolerance.Text = "Położenie Pola:";
            // 
            // labelRollDiameter
            // 
            this.labelRollDiameter.AutoSize = true;
            this.labelRollDiameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.labelRollDiameter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRollDiameter.ForeColor = System.Drawing.Color.White;
            this.labelRollDiameter.Location = new System.Drawing.Point(103, 127);
            this.labelRollDiameter.Name = "labelRollDiameter";
            this.labelRollDiameter.Size = new System.Drawing.Size(72, 19);
            this.labelRollDiameter.TabIndex = 6;
            this.labelRollDiameter.Text = "Średnica:";
            // 
            // textBoxRollDiameter
            // 
            this.textBoxRollDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRollDiameter.Location = new System.Drawing.Point(181, 120);
            this.textBoxRollDiameter.Name = "textBoxRollDiameter";
            this.textBoxRollDiameter.Size = new System.Drawing.Size(82, 26);
            this.textBoxRollDiameter.TabIndex = 2;
            this.textBoxRollDiameter.TextChanged += new System.EventHandler(this.textBoxRollDiameter_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 190);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(284, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 190);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Location = new System.Drawing.Point(724, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 190);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Otwór";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(466, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Klasa dokładności IT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(502, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Położenie Pola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(543, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Średnica:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(621, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 26);
            this.textBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(621, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(621, 186);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 28);
            this.comboBox2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pictureBox4.Location = new System.Drawing.Point(452, 46);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(272, 190);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelRollerTitle);
            this.Controls.Add(this.labelRollerClass);
            this.Controls.Add(this.labelRollTolerance);
            this.Controls.Add(this.labelRollDiameter);
            this.Controls.Add(this.textBoxRollDiameter);
            this.Controls.Add(this.comboBoxRollerTolerance);
            this.Controls.Add(this.comboBoxRollerClass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Kalkulator Pasowań";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRollerTolerance;
        private System.Windows.Forms.ComboBox comboBoxRollerClass;
        private System.Windows.Forms.Label labelRollerClass;
        private System.Windows.Forms.Label labelRollTolerance;
        private System.Windows.Forms.Label labelRollDiameter;
        private System.Windows.Forms.TextBox textBoxRollDiameter;
        private System.Windows.Forms.Label labelRollerTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

