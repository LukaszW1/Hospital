using HospitalClassLibrary.model;
using HospitalClassLibrary.model.uzytkownicy;
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
    public partial class PanelAdmina : Form
    { Szpital szpital;
        List<Pracownik> pracownicySzpitala;
        public PanelAdmina(Szpital szpital)
        {
            this.szpital = szpital;
            InitializeComponent();
            pracownicySzpitala = szpital.zwrocListePracownikow();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.BeginEdit(true);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();

            binding.DataSource = pracownicySzpitala;
            dataGridView1.DataSource = pracownicySzpitala;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StworzUzytkownika stworzUzytkownika = new StworzUzytkownika(szpital);
            stworzUzytkownika.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
