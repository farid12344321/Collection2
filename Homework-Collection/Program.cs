
//1. Fənn adı və imtahan tarixindən ibarət key-value collection yaradırsınız.
// Özünüzdən datalar əlavə edin dictionary-ə və sonda diztionarydəki dataları console-a yazdırın fənn adı,
// imtahan tarixi və imtahana neçə gün qaldığını

//Dictionary<string,DateTime> keyValuePairs = new Dictionary<string,DateTime>();

//string opt;
//do
//{
//    Console.WriteLine("1.  Fenn elave edin :");
//    Console.WriteLine("2.  Butun fenlere baxin");
//    opt = Console.ReadLine();

//    switch (opt)
//    {
//        case "1":
//            Console.WriteLine("Fenn adi");
//            string subjectStr = Console.ReadLine();
//            if (string.IsNullOrWhiteSpace(subjectStr))
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Bos ola bilmez");
//                Console.ForegroundColor= ConsoleColor.White;
//                break;
//            }
//            Console.WriteLine("Imtahan vaxtini daxil edin:");
//            string dateStr = Console.ReadLine();
//            DateTime date;
//            if (!DateTime.TryParse(dateStr,out date))
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Duzgun vaxt teyin edin");
//                Console.ForegroundColor= ConsoleColor.White;
//                break;
//            }
//            if (date < DateTime.Now)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Indiki vaxtdan kicik olla blimez");
//                Console.ForegroundColor= ConsoleColor.White;
//                break;
//            }
//            keyValuePairs.Add(subjectStr, date);
//            break;
//        case "2":
//            foreach (var item in keyValuePairs)
//            {
//                Console.WriteLine($"\nFenn: {item.Key} - Vaxti: {item.Value.ToString("dd.MM.yyyy")} - Nece gun qaldiqi: {(item.Value.Date - DateTime.Now.Date).TotalDays}\n");
//            }
//            break;
//        default:
//            break;
//    }
//} while (opt != "0");


using Homework_Collection;
using Homework_Collection.Exceptions;
using System.Globalization;

Library library = new Library();
string opt;
do
{
    Console.WriteLine("1 Book elave etmek");
    Console.WriteLine("2 Book silmek");
    Console.WriteLine("3 Butun kitablara baxmaq");
    Console.WriteLine("4 Kitablar uzerin search etmek");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            Console.WriteLine("Kitab elave et: ");
            string bookStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bookStr))
            {
                Console.WriteLine("book ad bos olmaz");
                break;
            }
            try
            {
                library.Add(bookStr);
            }
            catch (BookAlreadyExist e)
            {

                Console.WriteLine(e.Message);
            }
            break;
        case "2":
            Console.WriteLine("Book adini qeyd edin: ");
            string removeBook = Console.ReadLine();
            library.Remove(removeBook);
            break;
        case "3":
            library.ShowBook();
            break;
        case "4":
            Console.WriteLine("Axtaris edin: ");
            string searchBookStr = Console.ReadLine();
            library.SearchBook(searchBookStr);
            break;
        default:
            break;
    }
} while (opt !="0");



