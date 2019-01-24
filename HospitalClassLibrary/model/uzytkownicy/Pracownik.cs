using HospitalClassLibrary.logic.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLibrary.model.uzytkownicy
{
    abstract class Pracownik : IPrintable
    {
        string imie;
        string nazwisko;
        string pesel;
        string login;
        string haslo;

        public Pracownik(string imie, string nazwisko, string pesel, string login, string haslo)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.login = login;
            this.haslo = haslo;
        }

        public void Wypisz()
        {
            throw new NotImplementedException();
        }
    }
}
