using HospitalClassLibrary.model;
using HospitalClassLibrary.model.uzytkownicy;
using HospitalClassLibrary.model.uzytkownicy.pracownicy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class StworzUzytkownika : Form
    {
        Szpital szpital;
        public StworzUzytkownika(Szpital szpital)
        {
            this.szpital = szpital;   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string pesel = textBox3.Text;
            string login = textBox4.Text;
            string haslo = textBox5.Text;
            Pracownik pracownik = new Pielegniarka(imie,nazwisko,pesel,login,haslo);
            szpital.dodajPracownika(pracownik);
        }
    }
}
