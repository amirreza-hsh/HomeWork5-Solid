using System;
using System.Collections.Generic;
using System.Text;

namespace H_w_5.task_2
{
    public class ProductViewer(IProductDataSource dataSource)
    {
        public void ShowProducts()
        {
            var products = dataSource.GetProducts();
            Console.WriteLine("--- Product List ---");
            foreach (var product in products)
            {
                Console.WriteLine($"- {product}");
            }
            Console.WriteLine("--------------------\n");
        }
    }


}
