using HospitalClassLibrary.logic.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassLibrary.model.uzytkownicy
{
    public class Administrator : Pracownik, IPrintable
    {
        public Administrator(string imie, string nazwisko, string pesel, string login, string haslo) : base(imie, nazwisko, pesel, login, haslo)
        {
        }

        public void Wypisz()
        {
            throw new NotImplementedException();
        }
    }
}
