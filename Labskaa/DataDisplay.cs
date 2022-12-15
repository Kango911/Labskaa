namespace Labs
{
    class DataDisplay
    {
        public static void Display(ReadersBook[] readersBook)
        {
            int maxNameLength = readersBook.Max(x => x.BookReadersData.Item1.Name.Length);
            int maxAuthorLength = readersBook.Max(x => x.BookReadersData.Item1.Author.Length);
            int maxReaderFullname = readersBook.Max(x => x.BookReadersData.Item2.Name.Length);
            int maxDateOfGetting = readersBook.Max(x => x.DateOfGetting.ToString().Length);


            CreateTableRow("Book".PadRight(maxNameLength), "Author".PadRight(maxAuthorLength),
                            "Reader".PadRight(maxReaderFullname), "Date Of Getting".PadRight(maxDateOfGetting));

            CreateHeadersSeparator(maxNameLength, maxAuthorLength, maxReaderFullname, maxDateOfGetting);

            foreach(ReadersBook data in readersBook)
            {
                string bookName = data.BookReadersData.Item1.Name.PadRight(maxNameLength);
                string author = data.BookReadersData.Item1.Author.PadRight(maxAuthorLength);
                string gettingDate = data.BookReadersData.Item2.Name != "" 
                    ? data.DateOfGetting.ToString().PadRight(maxDateOfGetting)
                    : "".PadRight(maxDateOfGetting);
                string readerName = data.BookReadersData.Item2.Name.PadRight(maxReaderFullname);
                CreateTableRow(bookName, author, readerName, gettingDate);
            }
        }

        private static void CreateTableRow(string bookName, string author, string readerName, string dateOfGetting)
        {
            Console.WriteLine($"|{author}|{bookName}|{readerName}|{dateOfGetting}|");
        }

        private static void CreateHeadersSeparator(int maxNameLength, int maxAuthorLength, int maxReaderName, int maxDate)
        {
            int separatorsCountInRow = 5;

            for(int i = 0; i< (5 + maxNameLength + maxAuthorLength + maxReaderName + maxDate); i++)
            {
                Console.Write("=");
            }

            Console.Write("\n");
        }
    }
}