﻿namespace WindowsFormsApp1
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
            this.bC = new System.Windows.Forms.Button();
            this.bCofnij = new System.Windows.Forms.Button();
            this.bDodaj = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bOdejmij = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bPomnoz = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bPrzecinek = new System.Windows.Forms.Button();
            this.bRownaSie = new System.Windows.Forms.Button();
            this.CoMamy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWynik
            // 
            this.tbWynik.Location = new System.Drawing.Point(12, 24);
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.Size = new System.Drawing.Size(227, 20);
            this.tbWynik.TabIndex = 0;
            this.tbWynik.Text = "0";
            this.tbWynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(12, 52);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(52, 23);
            this.bCE.TabIndex = 1;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(71, 51);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(51, 23);
            this.bC.TabIndex = 2;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bCofnij
            // 
            this.bCofnij.Location = new System.Drawing.Point(128, 170);
            this.bCofnij.Name = "bCofnij";
            this.bCofnij.Size = new System.Drawing.Size(51, 23);
            this.bCofnij.TabIndex = 3;
            this.bCofnij.Text = "<-";
            this.bCofnij.UseVisualStyleBackColor = true;
            // 
            // bDodaj
            // 
            this.bDodaj.Location = new System.Drawing.Point(185, 82);
            this.bDodaj.Name = "bDodaj";
            this.bDodaj.Size = new System.Drawing.Size(52, 23);
            this.bDodaj.TabIndex = 4;
            this.bDodaj.Text = "+";
            this.bDodaj.UseVisualStyleBackColor = true;
            this.bDodaj.Click += new System.EventHandler(this.bDzialanie_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 81);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(52, 23);
            this.b7.TabIndex = 5;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(71, 81);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(51, 23);
            this.b8.TabIndex = 6;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(129, 80);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(51, 23);
            this.b9.TabIndex = 7;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b_Click);
            // 
            // bOdejmij
            // 
            this.bOdejmij.Location = new System.Drawing.Point(185, 111);
            this.bOdejmij.Name = "bOdejmij";
            this.bOdejmij.Size = new System.Drawing.Size(52, 23);
            this.bOdejmij.TabIndex = 8;
            this.bOdejmij.Text = "-";
            this.bOdejmij.UseVisualStyleBackColor = true;
            this.bOdejmij.Click += new System.EventHandler(this.bDzialanie_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 111);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(52, 23);
            this.b4.TabIndex = 9;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(71, 111);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(51, 23);
            this.b5.TabIndex = 10;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(129, 111);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(51, 23);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b_Click);
            // 
            // bPomnoz
            // 
            this.bPomnoz.Location = new System.Drawing.Point(185, 141);
            this.bPomnoz.Name = "bPomnoz";
            this.bPomnoz.Size = new System.Drawing.Size(52, 23);
            this.bPomnoz.TabIndex = 12;
            this.bPomnoz.Text = "*";
            this.bPomnoz.UseVisualStyleBackColor = true;
            this.bPomnoz.Click += new System.EventHandler(this.bDzialanie_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 141);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(52, 23);
            this.b1.TabIndex = 13;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(71, 141);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(51, 23);
            this.b2.TabIndex = 14;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(129, 141);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(51, 23);
            this.b3.TabIndex = 15;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b_Click);
            // 
            // bDzielenie
            // 
            this.bDzielenie.Location = new System.Drawing.Point(185, 171);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(52, 23);
            this.bDzielenie.TabIndex = 16;
            this.bDzielenie.Text = "/";
            this.bDzielenie.UseVisualStyleBackColor = true;
            this.bDzielenie.Click += new System.EventHandler(this.bDzialanie_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 171);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(52, 23);
            this.b0.TabIndex = 17;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b_Click);
            // 
            // bPrzecinek
            // 
            this.bPrzecinek.Location = new System.Drawing.Point(71, 171);
            this.bPrzecinek.Name = "bPrzecinek";
            this.bPrzecinek.Size = new System.Drawing.Size(51, 23);
            this.bPrzecinek.TabIndex = 18;
            this.bPrzecinek.Text = ",";
            this.bPrzecinek.UseVisualStyleBackColor = true;
            this.bPrzecinek.Click += new System.EventHandler(this.b_Click);
            // 
            // bRownaSie
            // 
            this.bRownaSie.Location = new System.Drawing.Point(130, 52);
            this.bRownaSie.Name = "bRownaSie";
            this.bRownaSie.Size = new System.Drawing.Size(109, 23);
            this.bRownaSie.TabIndex = 19;
            this.bRownaSie.Text = "=";
            this.bRownaSie.UseVisualStyleBackColor = true;
            this.bRownaSie.Click += new System.EventHandler(this.bRownaSie_Click);
            // 
            // CoMamy
            // 
            this.CoMamy.AutoSize = true;
            this.CoMamy.BackColor = System.Drawing.Color.White;
            this.CoMamy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CoMamy.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CoMamy.Location = new System.Drawing.Point(20, 28);
            this.CoMamy.Name = "CoMamy";
            this.CoMamy.Size = new System.Drawing.Size(9, 13);
            this.CoMamy.TabIndex = 20;
            this.CoMamy.Text = "l";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 214);
            this.Controls.Add(this.CoMamy);
            this.Controls.Add(this.bRownaSie);
            this.Controls.Add(this.bPrzecinek);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bDzielenie);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bPomnoz);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bOdejmij);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bDodaj);
            this.Controls.Add(this.bCofnij);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.tbWynik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCofnij;
        private System.Windows.Forms.Button bDodaj;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bOdejmij;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bPomnoz;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bDzielenie;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bPrzecinek;
        private System.Windows.Forms.Button bRownaSie;
        private System.Windows.Forms.Label CoMamy;
    }
}

