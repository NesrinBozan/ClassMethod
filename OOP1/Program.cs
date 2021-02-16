using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product1 product = new Product1();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitPrice = 3;

            Product1 product1 = new Product1 { Id = 2, CategoryId = 5, UnitsInStock = 5, UnitPrice=35,ProductName="Kalem" };
            
            //PascalCase     //camelCase
            ProductManager productManager = new ProductManager();

            
        }
    }
}
