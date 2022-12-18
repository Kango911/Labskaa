namespace Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string pathOfProject = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string csvReadersPath = pathOfProject + "//Data//Readers.csv";
            string readerSchemaPath = pathOfProject + "//Schemas//reader.schema.json";

            string csvBooksPath = pathOfProject + "//Data//Books.csv";
            string bookSchemaPath = pathOfProject + "//Schemas//book.schema.json";

            string[] readersData = CsvDataParser.GetDataFromCsv(csvReadersPath, readerSchemaPath);
            string[] booksData = CsvDataParser.GetDataFromCsv(csvBooksPath, bookSchemaPath);

            List<Reader> readers = new List<Reader>();
            List<Book> books = new List<Book>();

            if (readersData == null || booksData == null)
            {
                return;
            }

            foreach(string item in readersData)
            {
                string[] elements = item.Split(";");
                readers.Add(new Reader(int.Parse(elements[0]), elements[1]));
            }

            foreach(string item in booksData)
            {
                string[] elements = item.Split(";");
                books.Add(new Book(int.Parse(elements[0]), elements[1], elements[2], int.Parse(elements[3]),
                                    int.Parse(elements[4]), int.Parse(elements[5]), bool.Parse(elements[6])));
            }
            //Создаем тестовые ReadersBook на основе уже поступивших Book и Reader. Потом это уже можно будет записать в табличку.
            List<ReadersBook> readersBooks = new List<ReadersBook>();
            //Для заполнение книг у которых нет читателя. Да, костыль :(
            Reader emptyReader = new Reader(0, "");
            int countTestReadersBook = 5;

            for(int i = 0; i < countTestReadersBook; i++)
            {
                books[i].IsAvailable = false;
                readersBooks.Add(new ReadersBook(DateTime.Parse($"{i+1}.12.2022"), books[i], readers[i]));
            }

            for(int j = countTestReadersBook; j < books.Count; j++)
            {
                readersBooks.Add(new ReadersBook(DateTime.Parse($"{j}.12.2022"), books[j], emptyReader));
            }

            DataDisplay.Display(readersBooks.ToArray());
            Console.ReadKey();
        }
    }
}