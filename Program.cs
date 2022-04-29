using FileHelper;

var fileHelper = new Helper("File1.csv");

var prod = fileHelper.LeggiProdotti();

Console.WriteLine("*********************");

foreach (var prodotto in prod)
{
    Console.WriteLine($"idprodotto: {prodotto.idprodotto} - nomeprodotto: {prodotto.nomeprodotto} - quantità: {prodotto.quantità}");
}

Console.WriteLine("*********************");

Console.WriteLine("Inserisci l'id del prodotto");
var idprodotto = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci il nome del prodotto");
var nomeprodotto = Console.ReadLine();
Console.WriteLine("Inserisci la quantità");
var quantità = int.Parse(Console.ReadLine());

var nuovoprodotto = new Prodotto();
nuovoprodotto.idprodotto = idprodotto;
nuovoprodotto.nomeprodotto = nomeprodotto;
nuovoprodotto.quantità = quantità;

fileHelper.AggiungiProdotto(nuovoprodotto);
fileHelper = new Helper("File1.csv");
prod = fileHelper.LeggiProdotti();


Console.WriteLine("*********************");

foreach (var prodotto in prod)
{
    Console.WriteLine($"idprodotto: {prodotto.idprodotto} - nomeprodotto: {prodotto.nomeprodotto} - quantità: {prodotto.quantità}");
}

Console.WriteLine("*********************");


Console.ReadLine();
