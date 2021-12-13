using System;

namespace Yemek_Uygulaması
{
    class yemek
    {
        static void Main(string[] args)
        {
            string name;
            string FoodName;
            string material;

            //  Name
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();

            // yemek
            Console.WriteLine("enter the name of the dish : ");
            FoodName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("lütfen malzemeleri yazarken araya virgül koyunuz");
            Console.WriteLine();

            // ingredients for food
            Console.WriteLine("Used materials");
            material = Console.ReadLine();

            Console.WriteLine("İsminiz: " + name);
            Console.WriteLine("Yapılacak Yemeğin Adı: " + FoodName);
            Console.WriteLine("Alınacak malzemeler: " + material);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}