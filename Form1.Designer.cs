namespace Kalkulator
{
    partial class Form1
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
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.bCE = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bMnozenie = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bDodawanie = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bOdejmowanie = new System.Windows.Forms.Button();
            this.bWynik = new System.Windows.Forms.Button();
            this.bKropka = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWynik
            // 
            this.tbWynik.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbWynik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbWynik.Enabled = false;
            this.tbWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWynik.Location = new System.Drawing.Point(12, 34);
            this.tbWynik.Multiline = true;
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWynik.Size = new System.Drawing.Size(458, 50);
            this.tbWynik.TabIndex = 0;
            // 
            // bCE
            // 
            this.bCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCE.Location = new System.Drawing.Point(118, 115);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(93, 62);
            this.bCE.TabIndex = 1;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = false;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bDel
            // 
            this.bDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDel.Location = new System.Drawing.Point(238, 115);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(90, 62);
            this.bDel.TabIndex = 3;
            this.bDel.Text = "DEL";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bDzielenie
            // 
            this.bDzielenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bDzielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDzielenie.Location = new System.Drawing.Point(380, 115);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(90, 62);
            this.bDzielenie.TabIndex = 4;
            this.bDzielenie.Text = "/";
            this.bDzielenie.UseVisualStyleBackColor = false;
            this.bDzielenie.Click += new System.EventHandler(this.bDzielenie_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(15, 200);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(90, 62);
            this.b7.TabIndex = 5;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(121, 200);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(90, 62);
            this.b8.TabIndex = 6;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(238, 200);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(90, 62);
            this.b9.TabIndex = 7;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bMnozenie
            // 
            this.bMnozenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bMnozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMnozenie.Location = new System.Drawing.Point(380, 200);
            this.bMnozenie.Name = "bMnozenie";
            this.bMnozenie.Size = new System.Drawing.Size(90, 62);
            this.bMnozenie.TabIndex = 8;
            this.bMnozenie.Text = "*";
            this.bMnozenie.UseVisualStyleBackColor = false;
            this.bMnozenie.Click += new System.EventHandler(this.bMnozenie_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(15, 291);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(90, 62);
            this.b4.TabIndex = 9;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(121, 291);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(90, 62);
            this.b5.TabIndex = 10;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(238, 291);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(90, 62);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bDodawanie
            // 
            this.bDodawanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bDodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDodawanie.Location = new System.Drawing.Point(380, 291);
            this.bDodawanie.Name = "bDodawanie";
            this.bDodawanie.Size = new System.Drawing.Size(90, 62);
            this.bDodawanie.TabIndex = 12;
            this.bDodawanie.Text = "+";
            this.bDodawanie.UseVisualStyleBackColor = false;
            this.bDodawanie.Click += new System.EventHandler(this.bDodawanie_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(15, 379);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(90, 62);
            this.b1.TabIndex = 13;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(121, 379);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(90, 62);
            this.b2.TabIndex = 14;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(238, 379);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(90, 62);
            this.b3.TabIndex = 15;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bOdejmowanie
            // 
            this.bOdejmowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bOdejmowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOdejmowanie.Location = new System.Drawing.Point(380, 379);
            this.bOdejmowanie.Name = "bOdejmowanie";
            this.bOdejmowanie.Size = new System.Drawing.Size(90, 62);
            this.bOdejmowanie.TabIndex = 16;
            this.bOdejmowanie.Text = "-";
            this.bOdejmowanie.UseVisualStyleBackColor = false;
            this.bOdejmowanie.Click += new System.EventHandler(this.bOdejmowanie_Click);
            // 
            // bWynik
            // 
            this.bWynik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bWynik.Location = new System.Drawing.Point(380, 479);
            this.bWynik.Name = "bWynik";
            this.bWynik.Size = new System.Drawing.Size(90, 62);
            this.bWynik.TabIndex = 17;
            this.bWynik.Text = "=";
            this.bWynik.UseVisualStyleBackColor = false;
            this.bWynik.Click += new System.EventHandler(this.bWynik_Click);
            // 
            // bKropka
            // 
            this.bKropka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKropka.Location = new System.Drawing.Point(238, 479);
            this.bKropka.Name = "bKropka";
            this.bKropka.Size = new System.Drawing.Size(90, 62);
            this.bKropka.TabIndex = 18;
            this.bKropka.Text = ".";
            this.bKropka.UseVisualStyleBackColor = true;
            this.bKropka.Click += new System.EventHandler(this.bKropka_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(121, 479);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(90, 62);
            this.b0.TabIndex = 19;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bKropka);
            this.Controls.Add(this.bWynik);
            this.Controls.Add(this.bOdejmowanie);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bDodawanie);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bMnozenie);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bDzielenie);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.tbWynik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bDzielenie;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bMnozenie;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bDodawanie;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bOdejmowanie;
        private System.Windows.Forms.Button bWynik;
        private System.Windows.Forms.Button bKropka;
        private System.Windows.Forms.Button b0;
    }
}

