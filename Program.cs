using System.Xml;

namespace PP_Oppgave_UKE_3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            //var objekt = new
            //{
            // År = "2023",
            // Tittel = "JOHN SOM HANDLER I BERGEN",
            // Forfatter = "john",
            // Sjanger = "kjedelig",
            // Handling = "John som handler i Bergen"
            //};

            book.newBook();
            Console.WriteLine($"Tittel: {book.Tittel}. Dette er en {book.Sjanger} bok skrevet av {book.Forfatter} som handler om {book.Handling}. Boken er fra {book.År}");
        }

    }

    public class Book{
        public string Tittel { get; set; }
        public string Forfatter = "";
        public string Sjanger = "";
        public string Handling = "handling";
        public string År = "år";


        internal void newBook(){
            Console.WriteLine("Hva er tittelen på denne boken?");
            Tittel = Console.ReadLine();

            Console.WriteLine("hvem er forfatteren bak boken?");
            Forfatter = Console.ReadLine();

            Console.WriteLine("hva er sjangeren på boken?");
            Sjanger = Console.ReadLine();

            Console.WriteLine("hva er handlingen til boken?");
            Handling = Console.ReadLine();

            Console.WriteLine("hvem år ble boken publisert?");
            År = Console.ReadLine();
        }




            

    }



}