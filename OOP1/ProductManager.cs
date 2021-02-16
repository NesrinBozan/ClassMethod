using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
    
    public void Add(Product1 product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");

        }
    public void Update (Product1 product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
        
    }
}
