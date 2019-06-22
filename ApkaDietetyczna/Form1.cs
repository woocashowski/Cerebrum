using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cerebrum;
//using Product;

namespace ApkaDietetyczna
{
    public partial class AplikacjaDietetyczna : Form
    {
        Osoba Adam = new Osoba(); 

    
        double[] PracaFiz = new double [7] { 0.00, 0.05, 0.1, 0.15, 0.20, 0.25, 0.30 };
        public AplikacjaDietetyczna()
        {

            


            InitializeComponent();
            Plec.Items.Add("Kobieta");
            Plec.Items.Add("Mężczyzna");

            comboBoxPracaFizyczna.Items.Add(" ");
            comboBoxPracaFizyczna.Items.Add("Poniżej 16 godzin");
            comboBoxPracaFizyczna.Items.Add("16-24 godziny");
            comboBoxPracaFizyczna.Items.Add("24-36 godzin");
            comboBoxPracaFizyczna.Items.Add("36-48 godzin");
            comboBoxPracaFizyczna.Items.Add("48-72 godziny");
            comboBoxPracaFizyczna.Items.Add("+72 godziny");


            comboBoxPracaStojaca.Items.Add("Poniżej 16 godzin");
            comboBoxPracaStojaca.Items.Add("16-24 godziny");
            comboBoxPracaStojaca.Items.Add("24-36 godzin");
            comboBoxPracaStojaca.Items.Add("36-48 godzin");
            comboBoxPracaStojaca.Items.Add("48-72 godziny");
            comboBoxPracaStojaca.Items.Add("+72 godziny");


            Walking.Items.Add("Poniżej 1h");
            Walking.Items.Add("Około Godziny");
            Walking.Items.Add("1-2 godziny");
            Walking.Items.Add("Około 2 godziny");
            Walking.Items.Add("Ponad 3 godziny");


            StrengthTraining.Items.Add("3-4h");
            StrengthTraining.Items.Add("4-5h");
            StrengthTraining.Items.Add("6-7h");
            StrengthTraining.Items.Add("8-9h");
            StrengthTraining.Items.Add("10-12h");

            MartialArts.Items.Add("1-2h");
            MartialArts.Items.Add("2-3h");
            MartialArts.Items.Add("4-5h");
            MartialArts.Items.Add("6-7h");
            MartialArts.Items.Add("Ponad 7h");

            Cycling.Items.Add("Poniżej 1h");
            Cycling.Items.Add("1-2h");
            Cycling.Items.Add("3-4h");
            Cycling.Items.Add("5-8h");
            Cycling.Items.Add("Ponad 8 godzin");


            Sylwetka.Items.Add("Umięśniona");
            Sylwetka.Items.Add("Szczupła");
            Sylwetka.Items.Add("Skinny-fat*");
            Sylwetka.Items.Add("Otyła");


            Cele.Items.Add("Schudnąć");
            Cele.Items.Add("Utrzymać wagę");
            Cele.Items.Add("Przytyć");

            TimeToCele.Items.Add("Miesiąc");
            TimeToCele.Items.Add("Dwa miesiące");
            TimeToCele.Items.Add("Trzy miesiące");
            TimeToCele.Items.Add("Cztery miesiące");
            TimeToCele.Items.Add("Pięć miesiące");
            TimeToCele.Items.Add("Pół Roku");
            TimeToCele.Items.Add("Rok");
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //   float Multiplier = 1.20F;
            //   comboBoxPracaFizyczna.Items.Add(Multiplier);
            //   comboBoxPracaStojaca.Items.Add(Multiplier);
            //   Walking.Items.Add(Multiplier);
            //   MartialArts.Items.Add(Multiplier);
            //   Cycling.Items.Add(Multiplier);
            //   StrengthTraining.Items.Add(Multiplier);
            comboBoxPracaFizyczna.Enabled = false;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {

                Adam.wiek = Convert.ToInt32(Age1.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(Age1,"Proszę uzupełnić dane");
            } 
            
            
            Adam.waga = Convert.ToInt32(Weight1.Text);
            int Wynik = Convert.ToInt32(Plec.SelectedIndex);

            double Mnoznik = (double)1.2;// + PracaFiz[comboBoxPracaFizyczna.SelectedIndex];
            //double result = ((Adam.waga * 10 + Adam.wzrost * 6.25 - 5 * Adam.wiek) * Mnoznik);
            double result = Adam.waga * 30;
            
            if (Wynik == 0)
            {
                Adam.plec = false;
                result -= 161;
            }
            else if (Wynik == 1)
            {
                Adam.plec = true;
                result += 5;
            }

            Result.Text = result.ToString();
            uint kalorie = Convert.ToUInt32(result);


            Produkty.Items.Clear();
            foreach (Product item in Cerebrum.Cerebrum.select(kalorie / 16, kalorie / 36, kalorie / 8, 15))
            {
                string produkt = (item.name.ToString());
                produkt += (" B: ");
                produkt += (item.protein.ToString());
                produkt += (" T: ");
                produkt += (item.fat.ToString());
                produkt += (" W: ");
                produkt += (item.carbs.ToString());
                Produkty.Items.Add(produkt);
            }

        }

        private void ComboBoxPracaFizyczna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PracaFizyczna_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPracaFizyczna.Enabled = ((CheckBox)sender).Checked; 
           
        }

        private void Walking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PracaStojaco_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPracaStojaca.Enabled = ((CheckBox)sender).Checked;
        }

        private void Sit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SztukiWalki_CheckedChanged(object sender, EventArgs e)
        {
            MartialArts.Enabled = ((CheckBox)sender).Checked;
        }

        private void Age1_TextChanged(object sender, EventArgs e) 
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Walking.Enabled = ((CheckBox)sender).Checked;
        }

        private void Plec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Produkty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
