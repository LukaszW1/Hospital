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
        Szpital szpital;
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
            bool userFound = false;
            foreach(Pracownik pracownik in pracownicySzpitala)
            {   
                if(pracownik.Login == login)
                {
                    userFound = true;
                    if(pracownik.Haslo == haslo)
                    {
                        this.Hide();
                        MessageBox.Show("Zalogowano pomyslnie");
                        if (pracownik is Administrator)
                        {                            
                            PanelAdmina panelAdmina = new PanelAdmina(szpital);
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
            if(userFound == false)
            {
                MessageBox.Show("Nie znaleziono uzytkownika");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
