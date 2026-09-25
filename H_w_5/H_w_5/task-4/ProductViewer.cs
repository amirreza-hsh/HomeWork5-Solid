using System;
using System.Collections.Generic;

namespace H_w_5.task_4
{
    public class ProductViewer
    {
        private readonly IProductDataSource _dataSource;

        public ProductViewer(IProductDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void ShowProducts()
        {
            List<string> products = _dataSource.GetProducts();

            Console.WriteLine("\nProducts:");

            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }

            foreach (string product in products)
            {
                Console.WriteLine($"- {product}");
            }
        }
    }
}
