namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FormInTrayButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCountComets = new System.Windows.Forms.TextBox();
            this.txtCountStars = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountPlanets = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAboutObject = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FormInTrayButton);
            this.panel1.Controls.Add(this.CloseFormButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Склад \"Космос\"";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // FormInTrayButton
            // 
            this.FormInTrayButton.FlatAppearance.BorderSize = 0;
            this.FormInTrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormInTrayButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormInTrayButton.ForeColor = System.Drawing.Color.White;
            this.FormInTrayButton.Location = new System.Drawing.Point(695, 0);
            this.FormInTrayButton.Name = "FormInTrayButton";
            this.FormInTrayButton.Size = new System.Drawing.Size(59, 26);
            this.FormInTrayButton.TabIndex = 13;
            this.FormInTrayButton.Text = "_";
            this.FormInTrayButton.UseVisualStyleBackColor = true;
            this.FormInTrayButton.Click += new System.EventHandler(this.FormInTrayButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.FlatAppearance.BorderSize = 0;
            this.CloseFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFormButton.ForeColor = System.Drawing.Color.White;
            this.CloseFormButton.Location = new System.Drawing.Point(760, 0);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(54, 26);
            this.CloseFormButton.TabIndex = 12;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.txtCountComets);
            this.panel2.Controls.Add(this.txtCountStars);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCountPlanets);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 463);
            this.panel2.TabIndex = 1;
            // 
            // txtCountComets
            // 
            this.txtCountComets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtCountComets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountComets.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountComets.ForeColor = System.Drawing.Color.White;
            this.txtCountComets.Location = new System.Drawing.Point(172, 250);
            this.txtCountComets.Name = "txtCountComets";
            this.txtCountComets.Size = new System.Drawing.Size(62, 19);
            this.txtCountComets.TabIndex = 11;
            this.txtCountComets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCountStars
            // 
            this.txtCountStars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtCountStars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountStars.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountStars.ForeColor = System.Drawing.Color.White;
            this.txtCountStars.Location = new System.Drawing.Point(170, 155);
            this.txtCountStars.Name = "txtCountStars";
            this.txtCountStars.Size = new System.Drawing.Size(62, 19);
            this.txtCountStars.TabIndex = 10;
            this.txtCountStars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Comet;
            this.pictureBox3.Location = new System.Drawing.Point(17, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 55);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(81, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кометы :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Star;
            this.pictureBox2.Location = new System.Drawing.Point(17, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 55);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(81, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Звезды :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Planet;
            this.pictureBox1.Location = new System.Drawing.Point(17, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 57);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Планеты :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCountPlanets
            // 
            this.txtCountPlanets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.txtCountPlanets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountPlanets.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountPlanets.ForeColor = System.Drawing.Color.White;
            this.txtCountPlanets.Location = new System.Drawing.Point(172, 68);
            this.txtCountPlanets.Name = "txtCountPlanets";
            this.txtCountPlanets.Size = new System.Drawing.Size(62, 19);
            this.txtCountPlanets.TabIndex = 3;
            this.txtCountPlanets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Забрать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пополнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAboutObject
            // 
            this.txtAboutObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtAboutObject.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAboutObject.ForeColor = System.Drawing.Color.White;
            this.txtAboutObject.Location = new System.Drawing.Point(413, 349);
            this.txtAboutObject.Name = "txtAboutObject";
            this.txtAboutObject.ReadOnly = true;
            this.txtAboutObject.Size = new System.Drawing.Size(391, 125);
            this.txtAboutObject.TabIndex = 2;
            this.txtAboutObject.Text = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(292, 372);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 71);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(391, 71);
            this.button3.TabIndex = 0;
            this.button3.Text = "Пустая ячейка";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(391, 70);
            this.button4.TabIndex = 1;
            this.button4.Text = "Пустая ячейка";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(391, 66);
            this.button5.TabIndex = 2;
            this.button5.Text = "Пустая ячейка";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(413, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 261);
            this.panel3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(254, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "1-ый в очереди";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(254, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "2-ой в очереди";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(254, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "3-ий в очереди";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(814, 489);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtAboutObject);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountPlanets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCountComets;
        private System.Windows.Forms.TextBox txtCountStars;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Button FormInTrayButton;
        private System.Windows.Forms.RichTextBox txtAboutObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

