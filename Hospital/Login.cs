using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalClassLibrary.model;
using HospitalClassLibrary.model.uzytkownicy;

namespace Hospital
{
    public partial class Login : Form
    {
        Szpital szpital = new Szpital();
        List<Pracownik> pracownicySzpitala;
        public Login(Szpital szpital)
        {
            this.szpital = szpital;
            InitializeComponent();
            pracownicySzpitala = szpital.zwrocListePracownikow();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string haslo = textBox2.Text;
            foreach(Pracownik pracownik in pracownicySzpitala)
            {   
                // TODO fix when no user is found
                if(pracownik.Login == login)
                {
                    if(pracownik.Haslo == haslo)
                    {
                        MessageBox.Show("Zalogowano pomyslnie");
                        if (pracownik is Administrator)
                        {
                            PanelAdmina panelAdmina = new PanelAdmina();
                            panelAdmina.Show();
                        }
                        else
                        {
                            PanelUzytkownika panelUzytkownika = new PanelUzytkownika();
                            panelUzytkownika.Show();
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Złe hasło");
                        break;
                    }
                }
                            
            }
            MessageBox.Show("Nie znaleziono uzytkownika");
        }
    }
}
