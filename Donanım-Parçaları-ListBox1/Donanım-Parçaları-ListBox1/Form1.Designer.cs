namespace Donanım_Parçaları_ListBox1
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
            this.lstTumparcalar = new System.Windows.Forms.ListBox();
            this.lstDisdonanim = new System.Windows.Forms.ListBox();
            this.lstİcdonanım = new System.Windows.Forms.ListBox();
            this.lblTumparcalar = new System.Windows.Forms.Label();
            this.lblDisdonanim = new System.Windows.Forms.Label();
            this.lblİcdonanim = new System.Windows.Forms.Label();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTumparcalar
            // 
            this.lstTumparcalar.BackColor = System.Drawing.Color.SkyBlue;
            this.lstTumparcalar.FormattingEnabled = true;
            this.lstTumparcalar.Items.AddRange(new object[] {
            "Ram",
            "Hoparlör",
            "Anakart",
            "Ekran Kartı",
            "Monitör",
            "CPU",
            "Mikrofon",
            "Hardisk",
            "Klavye",
            "SSD"});
            this.lstTumparcalar.Location = new System.Drawing.Point(22, 59);
            this.lstTumparcalar.Name = "lstTumparcalar";
            this.lstTumparcalar.Size = new System.Drawing.Size(133, 251);
            this.lstTumparcalar.TabIndex = 0;
            // 
            // lstDisdonanim
            // 
            this.lstDisdonanim.BackColor = System.Drawing.Color.SkyBlue;
            this.lstDisdonanim.FormattingEnabled = true;
            this.lstDisdonanim.Location = new System.Drawing.Point(205, 59);
            this.lstDisdonanim.Name = "lstDisdonanim";
            this.lstDisdonanim.Size = new System.Drawing.Size(133, 251);
            this.lstDisdonanim.TabIndex = 1;
            // 
            // lstİcdonanım
            // 
            this.lstİcdonanım.BackColor = System.Drawing.Color.SkyBlue;
            this.lstİcdonanım.FormattingEnabled = true;
            this.lstİcdonanım.Location = new System.Drawing.Point(388, 59);
            this.lstİcdonanım.Name = "lstİcdonanım";
            this.lstİcdonanım.Size = new System.Drawing.Size(133, 251);
            this.lstİcdonanım.TabIndex = 2;
            // 
            // lblTumparcalar
            // 
            this.lblTumparcalar.AutoSize = true;
            this.lblTumparcalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTumparcalar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTumparcalar.Location = new System.Drawing.Point(19, 29);
            this.lblTumparcalar.Name = "lblTumparcalar";
            this.lblTumparcalar.Size = new System.Drawing.Size(81, 15);
            this.lblTumparcalar.TabIndex = 3;
            this.lblTumparcalar.Text = "Tüm Parçalar";
            // 
            // lblDisdonanim
            // 
            this.lblDisdonanim.AutoSize = true;
            this.lblDisdonanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDisdonanim.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisdonanim.Location = new System.Drawing.Point(202, 29);
            this.lblDisdonanim.Name = "lblDisdonanim";
            this.lblDisdonanim.Size = new System.Drawing.Size(131, 15);
            this.lblDisdonanim.TabIndex = 4;
            this.lblDisdonanim.Text = "Dış Donanım Parçaları";
            // 
            // lblİcdonanim
            // 
            this.lblİcdonanim.AutoSize = true;
            this.lblİcdonanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİcdonanim.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblİcdonanim.Location = new System.Drawing.Point(385, 29);
            this.lblİcdonanim.Name = "lblİcdonanim";
            this.lblİcdonanim.Size = new System.Drawing.Size(122, 15);
            this.lblİcdonanim.TabIndex = 5;
            this.lblİcdonanim.Text = "İç Donanım Parçaları";
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAktar.Location = new System.Drawing.Point(22, 339);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(100, 27);
            this.btnAktar.TabIndex = 6;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(549, 398);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lblİcdonanim);
            this.Controls.Add(this.lblDisdonanim);
            this.Controls.Add(this.lblTumparcalar);
            this.Controls.Add(this.lstİcdonanım);
            this.Controls.Add(this.lstDisdonanim);
            this.Controls.Add(this.lstTumparcalar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTumparcalar;
        private System.Windows.Forms.ListBox lstDisdonanim;
        private System.Windows.Forms.ListBox lstİcdonanım;
        private System.Windows.Forms.Label lblTumparcalar;
        private System.Windows.Forms.Label lblDisdonanim;
        private System.Windows.Forms.Label lblİcdonanim;
        private System.Windows.Forms.Button btnAktar;
    }
}

