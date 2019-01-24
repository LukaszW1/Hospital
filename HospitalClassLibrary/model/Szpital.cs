using HospitalClassLibrary.logic.api;
using HospitalClassLibrary.model.uzytkownicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLibrary.model
{
    public class Szpital : IPrintable
    {
        public static List<Pracownik> pracownicySzpitala = new List<Pracownik>();
        public Szpital()
        {
            

        }

        public void dodajPracownika(Pracownik pracownik)
        {
            pracownicySzpitala.Add(pracownik);
        }

        public List<Pracownik> zwrocListePracownikow()
        {
            return pracownicySzpitala;
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
