using System;

namespace Labs
{
    class Menu
    {
        public static void Main()
        {
            Console.WriteLine("Hello! \nWrote number lab...");
            string x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    labDM1.LabDM1();
                    break;
                case "2":
                    labDM2.LabDM2();
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
} 