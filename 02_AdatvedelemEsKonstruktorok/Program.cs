using _02_AdatvedelemEsKonstruktorok;

Bankszamla Anna = new Bankszamla("100");
Bankszamla Bela = new Bankszamla("200", 100000, 50000);

Anna.Befizetes(10000);
Bela.Kivetel(20000);

Console.WriteLine($"Anna számlaszáma: {Anna.Szamlaszam}, egyenlege: {Anna.Egyenleg}, hitelkerete: {Anna.HitelKeret}");
Console.WriteLine($"Béla számlaszáma: {Bela.Szamlaszam}, egyenlege: {Bela.Egyenleg}, hitelkerete: {Bela.HitelKeret}");