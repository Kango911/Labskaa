namespace Labskaa;

class Reader
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Reader(int id, string name)
        {
            Id = id; Name = name;
        }
        
    }
