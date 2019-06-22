namespace ApkaDietetyczna
{
    partial class AplikacjaDietetyczna
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
            this.components = new System.ComponentModel.Container();
            this.Age1 = new System.Windows.Forms.TextBox();
            this.Growth1 = new System.Windows.Forms.TextBox();
            this.Weight1 = new System.Windows.Forms.TextBox();
            this.Plec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Kalorie = new System.Windows.Forms.Label();
            this.PracaFizyczna = new System.Windows.Forms.CheckBox();
            this.comboBoxPracaFizyczna = new System.Windows.Forms.ComboBox();
            this.PracaStojaco = new System.Windows.Forms.CheckBox();
            this.comboBoxPracaStojaca = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Walking = new System.Windows.Forms.ComboBox();
            this.Sit = new System.Windows.Forms.CheckBox();
            this.SztukiWalki = new System.Windows.Forms.CheckBox();
            this.MartialArts = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Cycling = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Produkty = new System.Windows.Forms.ListBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.StrengthTraining = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Sylwetka = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cele = new System.Windows.Forms.ComboBox();
            this.Szaczowa = new System.Windows.Forms.Label();
            this.TimeToCele = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Age1
            // 
            this.Age1.Location = new System.Drawing.Point(120, 78);
            this.Age1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Age1.Name = "Age1";
            this.Age1.Size = new System.Drawing.Size(132, 22);
            this.Age1.TabIndex = 1;
            this.Age1.TextChanged += new System.EventHandler(this.Age1_TextChanged);
            // 
            // Growth1
            // 
            this.Growth1.Location = new System.Drawing.Point(120, 110);
            this.Growth1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Growth1.Name = "Growth1";
            this.Growth1.Size = new System.Drawing.Size(132, 22);
            this.Growth1.TabIndex = 2;
            // 
            // Weight1
            // 
            this.Weight1.Location = new System.Drawing.Point(120, 142);
            this.Weight1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Weight1.Name = "Weight1";
            this.Weight1.Size = new System.Drawing.Size(132, 22);
            this.Weight1.TabIndex = 3;
            // 
            // Plec
            // 
            this.Plec.FormattingEnabled = true;
            this.Plec.Location = new System.Drawing.Point(120, 46);
            this.Plec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Plec.Name = "Plec";
            this.Plec.Size = new System.Drawing.Size(132, 24);
            this.Plec.TabIndex = 5;
            this.Plec.SelectedIndexChanged += new System.EventHandler(this.Plec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Płeć";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wiek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wzrost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Waga";
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(17, 635);
            this.Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(79, 30);
            this.Button.TabIndex = 10;
            this.Button.Text = "OK";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(208, 690);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(132, 22);
            this.Result.TabIndex = 11;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Kalorie
            // 
            this.Kalorie.AutoSize = true;
            this.Kalorie.Location = new System.Drawing.Point(15, 698);
            this.Kalorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kalorie.Name = "Kalorie";
            this.Kalorie.Size = new System.Drawing.Size(153, 17);
            this.Kalorie.TabIndex = 12;
            this.Kalorie.Text = "Zalecana kaloryczność";
            // 
            // PracaFizyczna
            // 
            this.PracaFizyczna.AutoSize = true;
            this.PracaFizyczna.Location = new System.Drawing.Point(17, 379);
            this.PracaFizyczna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PracaFizyczna.Name = "PracaFizyczna";
            this.PracaFizyczna.Size = new System.Drawing.Size(126, 21);
            this.PracaFizyczna.TabIndex = 13;
            this.PracaFizyczna.Text = "Praca fizyczna ";
            this.PracaFizyczna.UseVisualStyleBackColor = true;
            this.PracaFizyczna.CheckedChanged += new System.EventHandler(this.PracaFizyczna_CheckedChanged);
            // 
            // comboBoxPracaFizyczna
            // 
            this.comboBoxPracaFizyczna.FormattingEnabled = true;
            this.comboBoxPracaFizyczna.Location = new System.Drawing.Point(231, 379);
            this.comboBoxPracaFizyczna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPracaFizyczna.Name = "comboBoxPracaFizyczna";
            this.comboBoxPracaFizyczna.Size = new System.Drawing.Size(132, 24);
            this.comboBoxPracaFizyczna.TabIndex = 14;
            this.comboBoxPracaFizyczna.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPracaFizyczna_SelectedIndexChanged);
            // 
            // PracaStojaco
            // 
            this.PracaStojaco.AutoSize = true;
            this.PracaStojaco.Location = new System.Drawing.Point(17, 407);
            this.PracaStojaco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PracaStojaco.Name = "PracaStojaco";
            this.PracaStojaco.Size = new System.Drawing.Size(116, 21);
            this.PracaStojaco.TabIndex = 15;
            this.PracaStojaco.Text = "Praca stojąca";
            this.PracaStojaco.UseVisualStyleBackColor = true;
            this.PracaStojaco.CheckedChanged += new System.EventHandler(this.PracaStojaco_CheckedChanged);
            // 
            // comboBoxPracaStojaca
            // 
            this.comboBoxPracaStojaca.FormattingEnabled = true;
            this.comboBoxPracaStojaca.Location = new System.Drawing.Point(231, 410);
            this.comboBoxPracaStojaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPracaStojaca.Name = "comboBoxPracaStojaca";
            this.comboBoxPracaStojaca.Size = new System.Drawing.Size(132, 24);
            this.comboBoxPracaStojaca.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 471);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(169, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Poruszanie się Pieszo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Walking
            // 
            this.Walking.FormattingEnabled = true;
            this.Walking.Location = new System.Drawing.Point(231, 464);
            this.Walking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Walking.Name = "Walking";
            this.Walking.Size = new System.Drawing.Size(132, 24);
            this.Walking.TabIndex = 18;
            this.Walking.SelectedIndexChanged += new System.EventHandler(this.Walking_SelectedIndexChanged);
            // 
            // Sit
            // 
            this.Sit.AutoSize = true;
            this.Sit.Location = new System.Drawing.Point(17, 436);
            this.Sit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sit.Name = "Sit";
            this.Sit.Size = new System.Drawing.Size(129, 21);
            this.Sit.TabIndex = 19;
            this.Sit.Text = "Praca Siedząca";
            this.Sit.UseVisualStyleBackColor = true;
            this.Sit.CheckedChanged += new System.EventHandler(this.Sit_CheckedChanged);
            // 
            // SztukiWalki
            // 
            this.SztukiWalki.AutoSize = true;
            this.SztukiWalki.Location = new System.Drawing.Point(16, 500);
            this.SztukiWalki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SztukiWalki.Name = "SztukiWalki";
            this.SztukiWalki.Size = new System.Drawing.Size(106, 21);
            this.SztukiWalki.TabIndex = 20;
            this.SztukiWalki.Text = "Sztuki Walki";
            this.SztukiWalki.UseVisualStyleBackColor = true;
            this.SztukiWalki.CheckedChanged += new System.EventHandler(this.SztukiWalki_CheckedChanged);
            // 
            // MartialArts
            // 
            this.MartialArts.FormattingEnabled = true;
            this.MartialArts.Location = new System.Drawing.Point(231, 495);
            this.MartialArts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MartialArts.Name = "MartialArts";
            this.MartialArts.Size = new System.Drawing.Size(132, 24);
            this.MartialArts.TabIndex = 21;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 530);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(142, 21);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Jazda na rowerze";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Cycling
            // 
            this.Cycling.FormattingEnabled = true;
            this.Cycling.Location = new System.Drawing.Point(231, 526);
            this.Cycling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cycling.Name = "Cycling";
            this.Cycling.Size = new System.Drawing.Size(132, 24);
            this.Cycling.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Proszę podać swoje prawdziwe dane";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Proszę podać swoją aktywność na przestrzeni tygodnia";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(17, 607);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(296, 21);
            this.checkBox3.TabIndex = 26;
            this.checkBox3.Text = "Dodatkowa aktywność, której nie ma wyżej";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Zalecane produkty do spożycia";
            // 
            // Produkty
            // 
            this.Produkty.FormattingEnabled = true;
            this.Produkty.ItemHeight = 16;
            this.Produkty.Location = new System.Drawing.Point(428, 50);
            this.Produkty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Produkty.Name = "Produkty";
            this.Produkty.Size = new System.Drawing.Size(467, 500);
            this.Produkty.TabIndex = 28;
            this.Produkty.SelectedIndexChanged += new System.EventHandler(this.Produkty_SelectedIndexChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(17, 565);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(120, 21);
            this.checkBox4.TabIndex = 29;
            this.checkBox4.Text = "Trening siłowy";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // StrengthTraining
            // 
            this.StrengthTraining.FormattingEnabled = true;
            this.StrengthTraining.Location = new System.Drawing.Point(231, 562);
            this.StrengthTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StrengthTraining.Name = "StrengthTraining";
            this.StrengthTraining.Size = new System.Drawing.Size(132, 24);
            this.StrengthTraining.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Odpowiedz na pytania";
            // 
            // Sylwetka
            // 
            this.Sylwetka.FormattingEnabled = true;
            this.Sylwetka.Location = new System.Drawing.Point(236, 218);
            this.Sylwetka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sylwetka.Name = "Sylwetka";
            this.Sylwetka.Size = new System.Drawing.Size(132, 24);
            this.Sylwetka.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Twój typ sylwetki";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Twoje cele";
            // 
            // Cele
            // 
            this.Cele.FormattingEnabled = true;
            this.Cele.Location = new System.Drawing.Point(236, 257);
            this.Cele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cele.Name = "Cele";
            this.Cele.Size = new System.Drawing.Size(132, 24);
            this.Cele.TabIndex = 35;
            // 
            // Szaczowa
            // 
            this.Szaczowa.AutoSize = true;
            this.Szaczowa.Location = new System.Drawing.Point(16, 293);
            this.Szaczowa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Szaczowa.Name = "Szaczowa";
            this.Szaczowa.Size = new System.Drawing.Size(164, 17);
            this.Szaczowa.TabIndex = 36;
            this.Szaczowa.Text = "Czas na osiągnięcie celu";
            // 
            // TimeToCele
            // 
            this.TimeToCele.FormattingEnabled = true;
            this.TimeToCele.Location = new System.Drawing.Point(236, 293);
            this.TimeToCele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeToCele.Name = "TimeToCele";
            this.TimeToCele.Size = new System.Drawing.Size(132, 24);
            this.TimeToCele.TabIndex = 37;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AplikacjaDietetyczna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(945, 782);
            this.Controls.Add(this.TimeToCele);
            this.Controls.Add(this.Szaczowa);
            this.Controls.Add(this.Cele);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Sylwetka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StrengthTraining);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.Produkty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cycling);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.MartialArts);
            this.Controls.Add(this.SztukiWalki);
            this.Controls.Add(this.Sit);
            this.Controls.Add(this.Walking);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxPracaStojaca);
            this.Controls.Add(this.PracaStojaco);
            this.Controls.Add(this.comboBoxPracaFizyczna);
            this.Controls.Add(this.PracaFizyczna);
            this.Controls.Add(this.Kalorie);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Plec);
            this.Controls.Add(this.Weight1);
            this.Controls.Add(this.Growth1);
            this.Controls.Add(this.Age1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AplikacjaDietetyczna";
            this.Text = "Aplikacja Dietetyczna";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Age1;
        private System.Windows.Forms.TextBox Growth1;
        private System.Windows.Forms.TextBox Weight1;
        private System.Windows.Forms.ComboBox Plec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label Kalorie;
        private System.Windows.Forms.CheckBox PracaFizyczna;
        private System.Windows.Forms.ComboBox comboBoxPracaFizyczna;
        private System.Windows.Forms.CheckBox PracaStojaco;
        private System.Windows.Forms.ComboBox comboBoxPracaStojaca;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox Walking;
        private System.Windows.Forms.CheckBox Sit;
        private System.Windows.Forms.CheckBox SztukiWalki;
        private System.Windows.Forms.ComboBox MartialArts;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox Cycling;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Produkty;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox StrengthTraining;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Sylwetka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cele;
        private System.Windows.Forms.Label Szaczowa;
        private System.Windows.Forms.ComboBox TimeToCele;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

