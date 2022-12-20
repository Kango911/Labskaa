using System;

namespace Labs
{
    class Book
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }
        public int Bookcase { get; private set; }
        public int Shelf { get; private set; }
        public bool IsAvailable { get; set; }

        public Book(int id, string name, string author, int year, int wardrobe, int shelf, bool available)
        {
            Id = id;
            Name = name;
            Author = author;
            Year = year;
            Bookcase = wardrobe;
            Shelf = shelf;
            IsAvailable = available;
        }
    }
}