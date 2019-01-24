using HospitalClassLibrary.logic.api;
using HospitalClassLibrary.model.uzytkownicy.pracownicy.stałe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLibrary.model.uzytkownicy.pracownicy
{
    class Lekarz : Pracownik, IPrintable
    {

        SpecjalnoscLekarza specjalnosc;
        string PWZ;

        public Lekarz(string imie, string nazwisko, string pesel, string login, string haslo, string PWZ) : base(imie, nazwisko, pesel, login, haslo)
        {
           this.PWZ = PWZ;
        }

        public Lekarz(string imie, string nazwisko, string pesel, string login, string haslo, string PWZ, SpecjalnoscLekarza specjalnosc) : base(imie, nazwisko, pesel, login, haslo)
        {
            
            this.PWZ = PWZ;
            this.specjalnosc = specjalnosc;
        }

        public void Wypisz()
        {
            throw new NotImplementedException();
        }
    }
}
