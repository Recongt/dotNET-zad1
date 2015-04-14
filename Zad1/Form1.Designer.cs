namespace Zad1
{
    partial class Form1
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
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNowaZabawka = new System.Windows.Forms.Button();
            this.buttonZamienParametry = new System.Windows.Forms.Button();
            this.comboBoxListaMozliwychZabawek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAccelerate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRise = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDive = new System.Windows.Forms.NumericUpDown();
            this.ListaZabawek = new System.Windows.Forms.ListBox();
            this.textBoxdoDebugu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDive)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNowaZabawka
            // 
            this.buttonNowaZabawka.Location = new System.Drawing.Point(510, 99);
            this.buttonNowaZabawka.Name = "buttonNowaZabawka";
            this.buttonNowaZabawka.Size = new System.Drawing.Size(96, 23);
            this.buttonNowaZabawka.TabIndex = 0;
            this.buttonNowaZabawka.Text = "Nowa zabawka";
            this.buttonNowaZabawka.UseVisualStyleBackColor = true;
            this.buttonNowaZabawka.Click += new System.EventHandler(this.buttonNowaZabawka_Click);
            // 
            // buttonZamienParametry
            // 
            this.buttonZamienParametry.Location = new System.Drawing.Point(510, 184);
            this.buttonZamienParametry.Name = "buttonZamienParametry";
            this.buttonZamienParametry.Size = new System.Drawing.Size(96, 23);
            this.buttonZamienParametry.TabIndex = 1;
            this.buttonZamienParametry.Text = "Zmien parametry";
            this.buttonZamienParametry.UseVisualStyleBackColor = true;
            // 
            // comboBoxListaMozliwychZabawek
            // 
            this.comboBoxListaMozliwychZabawek.FormattingEnabled = true;
            this.comboBoxListaMozliwychZabawek.Items.AddRange(new object[] {
            "Car",
            "Submarine",
            "Plane",
            "Computer",
            "Bike",
            "Dino"});
            this.comboBoxListaMozliwychZabawek.Location = new System.Drawing.Point(123, 97);
            this.comboBoxListaMozliwychZabawek.Name = "comboBoxListaMozliwychZabawek";
            this.comboBoxListaMozliwychZabawek.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListaMozliwychZabawek.TabIndex = 2;
            this.comboBoxListaMozliwychZabawek.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tworzenie nowej zabawki";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accelerate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rise";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dive";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDownAccelerate
            // 
            this.numericUpDownAccelerate.Location = new System.Drawing.Point(105, 209);
            this.numericUpDownAccelerate.Name = "numericUpDownAccelerate";
            this.numericUpDownAccelerate.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownAccelerate.TabIndex = 7;
            // 
            // numericUpDownRise
            // 
            this.numericUpDownRise.Location = new System.Drawing.Point(167, 209);
            this.numericUpDownRise.Name = "numericUpDownRise";
            this.numericUpDownRise.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownRise.TabIndex = 8;
            // 
            // numericUpDownDive
            // 
            this.numericUpDownDive.Location = new System.Drawing.Point(231, 209);
            this.numericUpDownDive.Name = "numericUpDownDive";
            this.numericUpDownDive.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownDive.TabIndex = 9;
            // 
            // ListaZabawek
            // 
            this.ListaZabawek.FormattingEnabled = true;
            this.ListaZabawek.Location = new System.Drawing.Point(329, 97);
            this.ListaZabawek.Name = "ListaZabawek";
            this.ListaZabawek.Size = new System.Drawing.Size(120, 95);
            this.ListaZabawek.TabIndex = 10;
            // 
            // textBoxdoDebugu
            // 
            this.textBoxdoDebugu.Location = new System.Drawing.Point(276, 333);
            this.textBoxdoDebugu.Name = "textBoxdoDebugu";
            this.textBoxdoDebugu.Size = new System.Drawing.Size(100, 20);
            this.textBoxdoDebugu.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 422);
            this.Controls.Add(this.textBoxdoDebugu);
            this.Controls.Add(this.ListaZabawek);
            this.Controls.Add(this.numericUpDownDive);
            this.Controls.Add(this.numericUpDownRise);
            this.Controls.Add(this.numericUpDownAccelerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxListaMozliwychZabawek);
            this.Controls.Add(this.buttonZamienParametry);
            this.Controls.Add(this.buttonNowaZabawka);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaZabawka;
        private System.Windows.Forms.Button buttonZamienParametry;
        private System.Windows.Forms.ComboBox comboBoxListaMozliwychZabawek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAccelerate;
        private System.Windows.Forms.NumericUpDown numericUpDownRise;
        private System.Windows.Forms.NumericUpDown numericUpDownDive;
        private System.Windows.Forms.ListBox ListaZabawek;
        private System.Windows.Forms.TextBox textBoxdoDebugu;
    }
}

