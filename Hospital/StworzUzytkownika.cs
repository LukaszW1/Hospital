using HospitalClassLibrary.model;
using HospitalClassLibrary.model.uzytkownicy;
using HospitalClassLibrary.model.uzytkownicy.pracownicy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string typUzytkownika = comboBox1.SelectedItem.ToString();
            Pracownik pracownik;
            if (typUzytkownika == "Pielegniarka")
            {
                pracownik = new Pielegniarka(imie, nazwisko, pesel, login, haslo);
            }else if(typUzytkownika == "Lekarz")
            {
                string PWZ = textBox6.Text;
                pracownik = new Lekarz(imie,nazwisko,pesel,login,haslo,PWZ);
            }
            else
            {
                pracownik = new Administrator(imie, nazwisko, pesel, login, haslo);
            }
            szpital.dodajPracownika(pracownik);
            List<Pracownik> listaPracownikow = szpital.zwrocListePracownikow();
            string json = JsonConvert.SerializeObject(listaPracownikow);
            using (StreamWriter streamWriter = new StreamWriter(@"c:\users\lukasz\source\repos\Hospital\Hospital\pracownicy.json"))
            {
                streamWriter.Write(json);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
