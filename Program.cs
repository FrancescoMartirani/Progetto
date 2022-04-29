using System.IO;

namespace FileHelper
{
    public class Helper
    {

        private readonly string Path;
        public Helper(string path)
        {
            Path = path;
        }
        public void AggiungiProdotto(Prodotto prodotto)
        {
            var result = $"{prodotto.idprodotto};{prodotto.nomeprodotto};{prodotto.quantità}";

            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine(result);
            }
        }

        public List<Prodotto> LeggiProdotti()
        {
            var prodotti = new List<Prodotto>();

            using (var stream = new StreamReader(Path))
            {
                var header = "idprodotto;nomeprodotto;quantità";

                var firstLine = stream.ReadLine();
                if (!firstLine.Equals(header))
                    throw new Exception("File non conforme!");


                while (!stream.EndOfStream)
                {
                    var row = stream.ReadLine();
                    var splitted = row.Split(";");

                    var prodotto = new Prodotto
                    {
                        idprodotto = splitted[0],
                        nomeprodotto = splitted[1],
                        quantità = splitted[2],
                    
                    };

                    prodotti.Add(prodotto);
                }

                return prodotti;
            }
        }


    }
}