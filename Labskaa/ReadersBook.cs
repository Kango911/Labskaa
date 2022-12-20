namespace Labskaa
{
    class ReadersBook
    {
        public DateTime DateGetting { get; private set; }
        public DateTime DateReturning { get; set; }
        public Tuple<Book, Reader> BookReadersData { get; private set; }

        public ReadersBook(DateTime getting, Book book, Reader reader)
        {
            DateGetting = getting;
            BookReadersData = new Tuple<Book, Reader>(book, reader);
        }
    }
}