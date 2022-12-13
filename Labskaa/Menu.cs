using System;

namespace Labs
{
    class Menu
    {
        public static void Main()
        {
            string x;
            Console.WriteLine("Hello! \nWrote number lab...");
            do
            {
                x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        labDM1.LabDM1();
                        break;
                    case "2":
                        labDM2.LabDM2();
                        break;
                    default:
                        Console.WriteLine("Введен не верный номер Lab \nПерезапустите программу");
                        break;
                }
            } while (x == "1" | x == "2");
            
            
            
        }
    }
} 
