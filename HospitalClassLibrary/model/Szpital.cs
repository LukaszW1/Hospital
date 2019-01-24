using HospitalClassLibrary.logic.api;
using HospitalClassLibrary.model.uzytkownicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLibrary.model
{
    class Szpital : IPrintable
    {
        List<Pracownik> pracownicySzpitala = new List<Pracownik>();

        public void dodajPracownika(Pracownik pracownik)
        {
            pracownicySzpitala.Add(pracownik);
        }

        public void Wypisz()
        {
            foreach(Pracownik pracownik in pracownicySzpitala)
            {
                pracownik.Wypisz();
            }
        }
    }
}
