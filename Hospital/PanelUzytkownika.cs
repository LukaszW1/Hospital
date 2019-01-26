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
    public partial class PanelUzytkownika : Form
    {   Szpital szpital;
        List<Pracownik> pracownicySzpitala;
        public PanelUzytkownika(Szpital szpital)
        {
            this.szpital = szpital;
            InitializeComponent();
            pracownicySzpitala = szpital.zwrocListePracownikow();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.BeginEdit(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();

            binding.DataSource = pracownicySzpitala;
            dataGridView1.DataSource = pracownicySzpitala;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
