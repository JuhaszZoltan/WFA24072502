using System.Text;
using UtasszallitokCLI;

List<Utasszallito> utasszallitok = [];
List<string> osszesSebessegKategoria = [
    "Alacsony sebességű",
    "Szubszonikus",
    "Transzszonikus",
    "Szuperszonikus"];

using StreamReader sr = new("..\\..\\..\\src\\utasszallitok.txt", Encoding.UTF8);
string fejlec = sr.ReadLine();
while (!sr.EndOfStream) utasszallitok.Add(new(sr.ReadLine()));

Console.WriteLine($"4. feladat: adatsorok szama: {utasszallitok.Count}");

int f5 = utasszallitok.Count(u => u.Tipus.StartsWith("Boeing"));
Console.WriteLine($"5. feladat: boeing tipusok szama: {f5}");

Utasszallito f6 = utasszallitok.MaxBy(u => u.Utas.Ig);
Console.WriteLine("6. feladat: a legtobb utast szallito repulogeptipus:");
Console.WriteLine(f6);

var gyartottSK = utasszallitok.Select(u => u.SebessegKategoria.KategoriaNev).Distinct();
var f7 = osszesSebessegKategoria.Except(gyartottSK).ToArray();
Console.Write("7. feladat:\n\t");
if (f7.Length == 0) Console.WriteLine("minden kategoriabol van repulogeptipus");
else foreach (var kn in f7) Console.Write($"{kn} ");

using StreamWriter sw = new("..\\..\\..\\src\\utasszallitok_new.txt", false, Encoding.UTF8);
sw.WriteLine(fejlec);
foreach (var u in utasszallitok)
{
    sw.WriteLine(
        $"{u.Tipus};" +
        $"{u.Ev};" +
        $"{u.Utas.Ig};" +
        $"{u.Szemelyzet.Ig};" +
        $"{u.UtazoSebesseg};" +
        $"{Math.Round(u.FelszalloTomeg/1000F):0};" +
        $"{Math.Round(u.Fesztav * 3.2808F):0}");
}