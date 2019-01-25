using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalClassLibrary.model;
using HospitalClassLibrary.model.uzytkownicy.pracownicy;
using HospitalClassLibrary.model.uzytkownicy;
using Newtonsoft.Json;
using System.IO;

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
            string json;
            try
            {
                // TODO change to relative path ( "pracownicy.json" as parameter is not working properly")

                using (StreamReader r = new StreamReader(@"c:\users\lukasz\source\repos\Hospital\Hospital\pracownicy.json"))
                {
                    json = r.ReadToEnd();
                    // TODO try to fix to recognize type of user
                    List<Administrator> items = JsonConvert.DeserializeObject<List<Administrator>>(json);
                    dynamic array = JsonConvert.DeserializeObject(json);
                    foreach (Pracownik pracownik in items)
                    {
                        szpital.dodajPracownika(pracownik);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }




            Administrator admin = new Administrator("jolka", "administratorka", "007", "admin", "admin");
            szpital.dodajPracownika(admin);
            List<Pracownik> listaPracownikow = szpital.zwrocListePracownikow();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(szpital));
            json = JsonConvert.SerializeObject(listaPracownikow);
            using (StreamWriter streamWriter = new StreamWriter(@"c:\users\lukasz\source\repos\Hospital\Hospital\pracownicy.json"))
            {
                streamWriter.Write(json);
            }

        }
        
    }
}
