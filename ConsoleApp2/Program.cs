using ConsoleApp2.CRUD;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            ProductCrud pc = new ProductCrud();

            while (check)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Fetch Products");
                Console.WriteLine("5. Exit");
                Console.WriteLine(" ---------------->>");
                Console.Write("Choose option: ");
                

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // ADD
                        Product p = new Product();
                        Console.Write("Enter Product Name: ");
                        p.Name = Console.ReadLine();
                        Console.Write("Enter Category Id: ");
                        p.CategId = int.Parse(Console.ReadLine());
                        Console.WriteLine(pc.AddProduct(p));
                        break;

                    case 2: // UPDATE
                        Product up = new Product();
                        Console.Write("Enter Product Id: ");
                        up.ProductId = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        up.Name = Console.ReadLine();
                        Console.Write("Enter New Category Id: ");
                        up.CategId = int.Parse(Console.ReadLine());
                        pc.UpdateProduct(up);
                        Console.WriteLine("Updated");
                        break;

                    case 3: // DELETE
                        Console.Write("Enter Product Id to delete: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine(pc.Delete(id));
                        break;

                    case 4: // FETCH
                        {
                            List<Product> products = pc.GetProducts();
                            Console.WriteLine("PrdtId || Name CategId");
                            foreach (var item in products)
                            {
                                Console.WriteLine(
                                    item.ProductId + "      || " +
                                    item.Name + "  " +
                                    item.CategId);
                            }
                            break;
                        }

                    case 5:
                        check = false;
                        break;

                   
                }
            }
        }
    }
}
