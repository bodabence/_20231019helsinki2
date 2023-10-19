using _20231019;
using System.ComponentModel;
using System.Text;

var lista = new List<Helsinki>();
var sr = new StreamReader(
    path: @"..\..\..\src\helsinki.txt",
    encoding: Encoding.UTF8);
while (!sr.EndOfStream)
{
    lista.Add(new Helsinki(sr.ReadLine()));
}

Console.WriteLine($"3.feladat: \n Pontszerző helyezések száma: {lista.Count}");

var f4 = lista.Count(x => x.Helyezes == 1);
var f41 = lista.Count(x => x.Helyezes == 2);
var f42 = lista.Count(x => x.Helyezes == 3);

Console.WriteLine($"4.feladat \n Arany: {f4} \n Ezüst: {f41} \n Bronz: {f42} \n Összesen: {f4 + f41 + f42}");
Console.ReadLine();

int olimpiaPont =  0;
foreach (Helsinki h in lista)
{
    if (h.Helyezes == 1) olimpiaPont += 7;
    else if (h.Helyezes == 2) olimpiaPont += 5;
    else if (h.Helyezes == 3) olimpiaPont += 4;
    else if (h.Helyezes == 4) olimpiaPont += 3;
    else if (h.Helyezes == 5) olimpiaPont += 2;
    else olimpiaPont++;

}
Console.WriteLine($"5.feladat \n Olimpia pontok száma : {olimpiaPont}");
Console.ReadLine();
var torna = lista
    .Where(x => x.sportagNeve == "torna" && x.Helyezes < 4)
    .Count();
var uszas = lista
    .Where(x => x.sportagNeve == "uszas" && x.Helyezes < 4)
    .Count();
if (torna > uszas) Console.WriteLine("6.feladat \n Torna sportágban szereztek több érmet");
else if (uszas > torna) Console.WriteLine("6.feladat \n Úszás sportágban szereztek több érmet");
else Console.WriteLine("6.feladat \n Az érmek száma egyenlő");
Console.ReadLine();
var sw = new StreamWriter(
    path: @"..\..\..\src\helsinki2.txt");
foreach (var x in lista)
{
    if (x.sportagNeve == "kajakkenu")
    {
        sw.WriteLine($"{x.Helyezes} {x.sportolokSzama} kajak-kenu {x.versenySzamNeve}");
    }
    else
    {
        sw.WriteLine($"{x.Helyezes} {x.sportolokSzama} {x.sportagNeve} {x.versenySzamNeve}");
    }
}

sw.Close();
