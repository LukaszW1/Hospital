using HospitalClassLibrary.logic.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLibrary.model.uzytkownicy
{
    public abstract class Pracownik : IPrintable
    {
        string imie;
        string nazwisko;
        string pesel;
        public string Login { get; private set; }
        public string Haslo { get; private set; }

        public Pracownik(string imie, string nazwisko, string pesel, string login, string haslo)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.Login = login;
            this.Haslo = haslo;
        }

        public void Wypisz()
        {
            throw new NotImplementedException();
        }
    }
}
