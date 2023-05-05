using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop Shop = new Shop();
            Shop.Create();
            Shop.Dispose();
        }

        class Shop : IDisposable
        {
            private string name;
            private string address;
            private string type_shope;

            public Shop()
            {
                name = "Text";
                address = "Text";
                type_shope = "Text";
            }

            public void Show_shop()
            {
                Console.WriteLine($"\nName: {name}" +
                                  $"\nAddress: {address}" +
                                  $"\nType_shope: {type_shope}");
            }

            public void Create()
            {
                while (true)
                {
                    Console.WriteLine("1. Create Shop");
                    Console.WriteLine("2. Show Shop");
                    Console.WriteLine("3. Exit");
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Name: ");
                            name = Console.ReadLine();
                            Console.Write("Enter Address: ");
                            address = Console.ReadLine();
                            Console.WriteLine("Enter Shop Type:" +
                                              "\n1. Grocery " +
                                              "\n2. nEconomic" +
                                              "\n3. Cloth" +
                                              "\n4. Shoes" +
                                              "\n5. Exit");
                            int ShopChoice = Int32.Parse(Console.ReadLine());
                            switch (ShopChoice)
                            {
                                case 1:
                                    type_shope = "Grocery";
                                    Console.WriteLine($"\nType: {type_shope}");
                                    break;
                                case 2:
                                    type_shope = "\nEconomic";
                                    Console.WriteLine($"\nType: {type_shope}");
                                    break;
                                case 3:
                                    type_shope = "Cloth";
                                    Console.WriteLine($"\nnType: {type_shope}");
                                    break;
                                case 4:
                                    type_shope = "Shoes";
                                    Console.WriteLine($"\nType: {type_shope}");
                                    break;
                                case 5:
                                    Show_shop();
                                    break;
                                default:
                                    Console.WriteLine("Error Number");
                                    break;
                            }
                            break;
                        case 2:
                            Show_shop();
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("Error");
                            break;
                    };
                }
            }
            public void Dispose()
            {
                Console.WriteLine("Dispose");
                name = null;
                address = null;
                type_shope = null;
            }

            ~Shop()
            {
                Console.WriteLine("Destructor");
                Dispose();
            }
        }
    }
}
