namespace Labs
{
    class ReadersBook
    {
        public DateTime DateOfGetting { get; private set; }
        public DateTime DateOfReturning { get; set; }
        public Tuple<Book, Reader> BookReadersData { get; private set; }

        public ReadersBook(DateTime getting, Book book, Reader reader)
        {
            DateOfGetting = getting;
            BookReadersData = new Tuple<Book, Reader>(book, reader);
        }
    }
}