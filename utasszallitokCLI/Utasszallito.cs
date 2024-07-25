using System.Diagnostics;
using System.Security.Principal;

namespace UtasszallitokCLI
{
    internal class Utasszallito
    {
        private readonly string utasString;
        private readonly string szemelyzetString;
        public string Tipus { get; set; }
        public int Ev { get; set; }
        public (int? Tol, int Ig) Utas => ErtekParKonvertalo(utasString);
        public (int? Tol, int Ig) Szemelyzet => ErtekParKonvertalo(szemelyzetString);
        public int UtazoSebesseg { get; set; }
        public int FelszalloTomeg { get; set; }
        public float Fesztav { get; set; }
        public SebessegKategoria SebessegKategoria { get; set; }

        static private (int?, int) ErtekParKonvertalo(string ertekString)
        {
            if (ertekString.Contains('-'))
            {
                string[] darabok = ertekString.Split('-');
                return (int.Parse(darabok[0]), int.Parse(darabok[1]));
            }
            return (null, int.Parse(ertekString));
        }

        public override string ToString() =>
            $"\tTípus: {Tipus}\n" +
            $"\tElső felszállás: {Ev}\n" +
            $"\tUtasok száma: {utasString} fő\n" +
            $"\tSzemélyzet: {szemelyzetString} fő\n" +
            $"\tUtazósebesség {UtazoSebesseg} km/h";

        public Utasszallito(string sor)
        {
            // típus;év;utas;személyzet;utazósebesség;felszállótömeg;fesztáv
            string[] adattagok = sor.Split(';');
            Tipus = adattagok[0];
            Ev = int.Parse(adattagok[1]);
            utasString = adattagok[2];
            szemelyzetString = adattagok[3];
            UtazoSebesseg = int.Parse(adattagok[4]);
            FelszalloTomeg = int.Parse(adattagok[5]);
            Fesztav = float.Parse(adattagok[6]);
            SebessegKategoria = new(UtazoSebesseg);
        }
    }
}
