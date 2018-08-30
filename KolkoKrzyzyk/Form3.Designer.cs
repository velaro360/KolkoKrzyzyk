namespace KolkoKrzyzyk
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.rbLatwy = new System.Windows.Forms.RadioButton();
            this.rbTrudny = new System.Windows.Forms.RadioButton();
            this.tabelaImie = new System.Windows.Forms.Label();
            this.tabelaCzas = new System.Windows.Forms.Label();
            this.tabelaData = new System.Windows.Forms.Label();
            this.tabelaLiczba = new System.Windows.Forms.Label();
            this.info_rekordy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbLatwy
            // 
            this.rbLatwy.AutoSize = true;
            this.rbLatwy.Location = new System.Drawing.Point(107, 123);
            this.rbLatwy.Name = "rbLatwy";
            this.rbLatwy.Size = new System.Drawing.Size(110, 21);
            this.rbLatwy.TabIndex = 1;
            this.rbLatwy.TabStop = true;
            this.rbLatwy.Text = "Poziom łatwy";
            this.rbLatwy.UseVisualStyleBackColor = true;
            this.rbLatwy.CheckedChanged += new System.EventHandler(this.rbLatwy_CheckedChanged);
            // 
            // rbTrudny
            // 
            this.rbTrudny.AutoSize = true;
            this.rbTrudny.Location = new System.Drawing.Point(267, 123);
            this.rbTrudny.Name = "rbTrudny";
            this.rbTrudny.Size = new System.Drawing.Size(119, 21);
            this.rbTrudny.TabIndex = 2;
            this.rbTrudny.TabStop = true;
            this.rbTrudny.Text = "Poziom trudny";
            this.rbTrudny.UseVisualStyleBackColor = true;
            this.rbTrudny.CheckedChanged += new System.EventHandler(this.rbTrudny_CheckedChanged);
            // 
            // tabelaImie
            // 
            this.tabelaImie.AutoSize = true;
            this.tabelaImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabelaImie.Location = new System.Drawing.Point(78, 185);
            this.tabelaImie.Name = "tabelaImie";
            this.tabelaImie.Size = new System.Drawing.Size(52, 25);
            this.tabelaImie.TabIndex = 3;
            this.tabelaImie.Text = "Imię";
            // 
            // tabelaCzas
            // 
            this.tabelaCzas.AutoSize = true;
            this.tabelaCzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabelaCzas.Location = new System.Drawing.Point(227, 185);
            this.tabelaCzas.Name = "tabelaCzas";
            this.tabelaCzas.Size = new System.Drawing.Size(95, 25);
            this.tabelaCzas.TabIndex = 4;
            this.tabelaCzas.Text = "Czas (s)";
            // 
            // tabelaData
            // 
            this.tabelaData.AutoSize = true;
            this.tabelaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabelaData.Location = new System.Drawing.Point(361, 185);
            this.tabelaData.Name = "tabelaData";
            this.tabelaData.Size = new System.Drawing.Size(57, 25);
            this.tabelaData.TabIndex = 5;
            this.tabelaData.Text = "Data";
            // 
            // tabelaLiczba
            // 
            this.tabelaLiczba.AutoSize = true;
            this.tabelaLiczba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabelaLiczba.Location = new System.Drawing.Point(21, 185);
            this.tabelaLiczba.Name = "tabelaLiczba";
            this.tabelaLiczba.Size = new System.Drawing.Size(42, 25);
            this.tabelaLiczba.TabIndex = 6;
            this.tabelaLiczba.Text = "Lp.";
            // 
            // info_rekordy
            // 
            this.info_rekordy.AutoSize = true;
            this.info_rekordy.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_rekordy.ForeColor = System.Drawing.Color.Red;
            this.info_rekordy.Location = new System.Drawing.Point(145, 279);
            this.info_rekordy.Name = "info_rekordy";
            this.info_rekordy.Size = new System.Drawing.Size(191, 36);
            this.info_rekordy.TabIndex = 7;
            this.info_rekordy.Text = "Brak graczy";
            this.info_rekordy.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 101);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info_rekordy);
            this.Controls.Add(this.tabelaLiczba);
            this.Controls.Add(this.tabelaData);
            this.Controls.Add(this.tabelaCzas);
            this.Controls.Add(this.tabelaImie);
            this.Controls.Add(this.rbTrudny);
            this.Controls.Add(this.rbLatwy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Ranking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbLatwy;
        private System.Windows.Forms.RadioButton rbTrudny;
        private System.Windows.Forms.Label tabelaImie;
        private System.Windows.Forms.Label tabelaCzas;
        private System.Windows.Forms.Label tabelaData;
        private System.Windows.Forms.Label tabelaLiczba;
        private System.Windows.Forms.Label info_rekordy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}