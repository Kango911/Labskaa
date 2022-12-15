using System;

namespace Labs
{
    class Menu
    {
        public static void Main()
        {
            string x;
            Console.WriteLine("Hello! \nWrote number lab... \nDM1 or DM2");
            Book book = new();
            do
            {
                x = Console.ReadLine();
                switch (x)
                {
                    case "DM1":
                        Console.WriteLine(book.Author);
                        break;
                    case "DM2":
                        labDM2.LabDM2();
                        break;
                    default:
                        Console.WriteLine("Введен не верный номер Lab \nПерезапустите программу");
                        break;
                }
            } while (x == "DM1" | x == "DM2");
        }
    }
} 
