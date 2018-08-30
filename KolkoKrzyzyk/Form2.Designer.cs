namespace KolkoKrzyzyk
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imie = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.zobacz = new System.Windows.Forms.Button();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.czas = new System.Windows.Forms.Label();
            this.czas_value = new System.Windows.Forms.Label();
            this.info_wynik = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.info_wynik)).BeginInit();
            this.SuspendLayout();
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.Location = new System.Drawing.Point(110, 164);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(145, 20);
            this.imie.TabIndex = 1;
            this.imie.Text = "Wpisz swoje imię:";
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(266, 164);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(185, 22);
            this.tbImie.TabIndex = 2;
            // 
            // zobacz
            // 
            this.zobacz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zobacz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zobacz.Location = new System.Drawing.Point(294, 211);
            this.zobacz.Name = "zobacz";
            this.zobacz.Size = new System.Drawing.Size(157, 37);
            this.zobacz.TabIndex = 3;
            this.zobacz.Text = "Zobacz ranking";
            this.zobacz.UseVisualStyleBackColor = false;
            this.zobacz.Click += new System.EventHandler(this.zobacz_Click);
            // 
            // zatwierdz
            // 
            this.zatwierdz.BackColor = System.Drawing.Color.GreenYellow;
            this.zatwierdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zatwierdz.Location = new System.Drawing.Point(114, 211);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(157, 37);
            this.zatwierdz.TabIndex = 4;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = false;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(187, 124);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(110, 17);
            this.czas.TabIndex = 5;
            this.czas.Text = "Twój czas (sek):";
            // 
            // czas_value
            // 
            this.czas_value.AutoSize = true;
            this.czas_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas_value.Location = new System.Drawing.Point(303, 124);
            this.czas_value.Name = "czas_value";
            this.czas_value.Size = new System.Drawing.Size(38, 17);
            this.czas_value.TabIndex = 6;
            this.czas_value.Text = "time";
            // 
            // info_wynik
            // 
            this.info_wynik.Image = ((System.Drawing.Image)(resources.GetObject("info_wynik.Image")));
            this.info_wynik.Location = new System.Drawing.Point(70, 21);
            this.info_wynik.Margin = new System.Windows.Forms.Padding(0);
            this.info_wynik.Name = "info_wynik";
            this.info_wynik.Size = new System.Drawing.Size(452, 91);
            this.info_wynik.TabIndex = 7;
            this.info_wynik.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 260);
            this.Controls.Add(this.info_wynik);
            this.Controls.Add(this.czas_value);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.zobacz);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.imie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.info_wynik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label imie;
        public System.Windows.Forms.TextBox tbImie;
        public System.Windows.Forms.Button zobacz;
        public System.Windows.Forms.Button zatwierdz;
        public System.Windows.Forms.Label czas_value;
        public System.Windows.Forms.Label czas;
        public System.Windows.Forms.PictureBox info_wynik;
    }
}