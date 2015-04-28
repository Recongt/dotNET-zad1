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
            this.comboBoxListaMozliwychZabawek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAccelerate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRise = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDive = new System.Windows.Forms.NumericUpDown();
            this.comboBoxZZabawkami = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxActualDive = new System.Windows.Forms.TextBox();
            this.textBoxActualRise = new System.Windows.Forms.TextBox();
            this.textBoxActualAccelerate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazwaZabawki = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDive)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaZabawka
            // 
            this.buttonNowaZabawka.Location = new System.Drawing.Point(239, 70);
            this.buttonNowaZabawka.Name = "buttonNowaZabawka";
            this.buttonNowaZabawka.Size = new System.Drawing.Size(90, 23);
            this.buttonNowaZabawka.TabIndex = 0;
            this.buttonNowaZabawka.Text = "Nowa zabawka";
            this.buttonNowaZabawka.UseVisualStyleBackColor = true;
            this.buttonNowaZabawka.Click += new System.EventHandler(this.buttonNowaZabawka_Click);
            // 
            // comboBoxListaMozliwychZabawek
            // 
            this.comboBoxListaMozliwychZabawek.FormattingEnabled = true;
            this.comboBoxListaMozliwychZabawek.Items.AddRange(new object[] {
            "Car",
            "Submarine",
            "Plane",
            "Computer",
            "Dino"});
            this.comboBoxListaMozliwychZabawek.Location = new System.Drawing.Point(12, 70);
            this.comboBoxListaMozliwychZabawek.Name = "comboBoxListaMozliwychZabawek";
            this.comboBoxListaMozliwychZabawek.Size = new System.Drawing.Size(221, 21);
            this.comboBoxListaMozliwychZabawek.TabIndex = 2;
            this.comboBoxListaMozliwychZabawek.Text = "Car";
            this.comboBoxListaMozliwychZabawek.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accelerate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rise";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dive";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDownAccelerate
            // 
            this.numericUpDownAccelerate.Location = new System.Drawing.Point(6, 131);
            this.numericUpDownAccelerate.Name = "numericUpDownAccelerate";
            this.numericUpDownAccelerate.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownAccelerate.TabIndex = 7;
            this.numericUpDownAccelerate.ValueChanged += new System.EventHandler(this.numericUpDownAccelerate_ValueChanged);
            // 
            // numericUpDownRise
            // 
            this.numericUpDownRise.Location = new System.Drawing.Point(68, 131);
            this.numericUpDownRise.Name = "numericUpDownRise";
            this.numericUpDownRise.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownRise.TabIndex = 8;
            this.numericUpDownRise.ValueChanged += new System.EventHandler(this.numericUpDownRise_ValueChanged);
            // 
            // numericUpDownDive
            // 
            this.numericUpDownDive.Location = new System.Drawing.Point(132, 131);
            this.numericUpDownDive.Name = "numericUpDownDive";
            this.numericUpDownDive.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownDive.TabIndex = 9;
            this.numericUpDownDive.ValueChanged += new System.EventHandler(this.numericUpDownDive_ValueChanged);
            // 
            // comboBoxZZabawkami
            // 
            this.comboBoxZZabawkami.FormattingEnabled = true;
            this.comboBoxZZabawkami.Location = new System.Drawing.Point(6, 82);
            this.comboBoxZZabawkami.Name = "comboBoxZZabawkami";
            this.comboBoxZZabawkami.Size = new System.Drawing.Size(225, 21);
            this.comboBoxZZabawkami.TabIndex = 13;
            this.comboBoxZZabawkami.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBoxZZabawkami.SelectedValueChanged += new System.EventHandler(this.comboBoxZZabawkami_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxActualDive);
            this.groupBox1.Controls.Add(this.textBoxActualRise);
            this.groupBox1.Controls.Add(this.textBoxActualAccelerate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxZZabawkami);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownDive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownRise);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownAccelerate);
            this.groupBox1.Location = new System.Drawing.Point(416, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 205);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stworzone Zabawki";
            // 
            // textBoxActualDive
            // 
            this.textBoxActualDive.Location = new System.Drawing.Point(131, 32);
            this.textBoxActualDive.Name = "textBoxActualDive";
            this.textBoxActualDive.Size = new System.Drawing.Size(55, 20);
            this.textBoxActualDive.TabIndex = 19;
            // 
            // textBoxActualRise
            // 
            this.textBoxActualRise.Location = new System.Drawing.Point(70, 33);
            this.textBoxActualRise.Name = "textBoxActualRise";
            this.textBoxActualRise.Size = new System.Drawing.Size(55, 20);
            this.textBoxActualRise.TabIndex = 18;
            // 
            // textBoxActualAccelerate
            // 
            this.textBoxActualAccelerate.Location = new System.Drawing.Point(9, 33);
            this.textBoxActualAccelerate.Name = "textBoxActualAccelerate";
            this.textBoxActualAccelerate.Size = new System.Drawing.Size(55, 20);
            this.textBoxActualAccelerate.TabIndex = 17;
            this.textBoxActualAccelerate.TextChanged += new System.EventHandler(this.textBoxActualAccelerate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Accelerate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rise";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dive";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxNazwaZabawki);
            this.groupBox2.Controls.Add(this.comboBoxListaMozliwychZabawek);
            this.groupBox2.Controls.Add(this.buttonNowaZabawka);
            this.groupBox2.Location = new System.Drawing.Point(53, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 197);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tworzenie nowej zabawki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa zabawki";
            // 
            // textBoxNazwaZabawki
            // 
            this.textBoxNazwaZabawki.Location = new System.Drawing.Point(6, 135);
            this.textBoxNazwaZabawki.Name = "textBoxNazwaZabawki";
            this.textBoxNazwaZabawki.Size = new System.Drawing.Size(317, 20);
            this.textBoxNazwaZabawki.TabIndex = 3;
            this.textBoxNazwaZabawki.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 237);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Zabawki";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDive)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaZabawka;
        private System.Windows.Forms.ComboBox comboBoxListaMozliwychZabawek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAccelerate;
        private System.Windows.Forms.NumericUpDown numericUpDownRise;
        private System.Windows.Forms.NumericUpDown numericUpDownDive;
        private System.Windows.Forms.ComboBox comboBoxZZabawkami;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazwaZabawki;
        private System.Windows.Forms.TextBox textBoxActualDive;
        private System.Windows.Forms.TextBox textBoxActualRise;
        private System.Windows.Forms.TextBox textBoxActualAccelerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        
    }
}

