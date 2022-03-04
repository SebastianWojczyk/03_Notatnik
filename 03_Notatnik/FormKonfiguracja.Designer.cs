namespace _03_Notatnik
{
    partial class FormKonfiguracja
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonKolorCzcionki = new System.Windows.Forms.Button();
            this.buttonKolorTla = new System.Windows.Forms.Button();
            this.buttonCzcionka = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(90, 99);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(171, 99);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 1;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonKolorCzcionki
            // 
            this.buttonKolorCzcionki.Location = new System.Drawing.Point(12, 12);
            this.buttonKolorCzcionki.Name = "buttonKolorCzcionki";
            this.buttonKolorCzcionki.Size = new System.Drawing.Size(117, 23);
            this.buttonKolorCzcionki.TabIndex = 2;
            this.buttonKolorCzcionki.Text = "Kolor czcionki";
            this.buttonKolorCzcionki.UseVisualStyleBackColor = true;
            this.buttonKolorCzcionki.Click += new System.EventHandler(this.buttonKolorCzcionki_Click);
            // 
            // buttonKolorTla
            // 
            this.buttonKolorTla.Location = new System.Drawing.Point(12, 41);
            this.buttonKolorTla.Name = "buttonKolorTla";
            this.buttonKolorTla.Size = new System.Drawing.Size(117, 23);
            this.buttonKolorTla.TabIndex = 3;
            this.buttonKolorTla.Text = "Kolor tła";
            this.buttonKolorTla.UseVisualStyleBackColor = true;
            this.buttonKolorTla.Click += new System.EventHandler(this.buttonKolorTla_Click);
            // 
            // buttonCzcionka
            // 
            this.buttonCzcionka.Location = new System.Drawing.Point(12, 70);
            this.buttonCzcionka.Name = "buttonCzcionka";
            this.buttonCzcionka.Size = new System.Drawing.Size(117, 23);
            this.buttonCzcionka.TabIndex = 4;
            this.buttonCzcionka.Text = "Czcionka";
            this.buttonCzcionka.UseVisualStyleBackColor = true;
            this.buttonCzcionka.Click += new System.EventHandler(this.buttonCzcionka_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(148, 22);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(28, 13);
            this.labelTest.TabIndex = 5;
            this.labelTest.Text = "Test";
            // 
            // FormKonfiguracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 126);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.buttonCzcionka);
            this.Controls.Add(this.buttonKolorTla);
            this.Controls.Add(this.buttonKolorCzcionki);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormKonfiguracja";
            this.Text = "Konfiguracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonKolorCzcionki;
        private System.Windows.Forms.Button buttonKolorTla;
        private System.Windows.Forms.Button buttonCzcionka;
        private System.Windows.Forms.Label labelTest;
    }
}