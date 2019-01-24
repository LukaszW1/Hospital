using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalClassLibrary.model;
using HospitalClassLibrary.model.uzytkownicy.pracownicy;
using HospitalClassLibrary.model.uzytkownicy;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Szpital szpital = new Szpital();
            Administrator admin = new Administrator("admin", "admin", "admin", "admin", "admin");
            Lekarz lekarz = new Lekarz("Stefan", "Żeromski", "4634647", "stefek", "12345", "285");
            szpital.dodajPracownika(admin);
            szpital.dodajPracownika(lekarz);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(szpital));

           
        }
    }
}
