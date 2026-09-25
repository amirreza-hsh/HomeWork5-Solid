using H_w_5.task_2;
using System.Collections.Generic;

namespace H_w_5.task_3
{
    public class DatabaseSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string> { "DB: Laptop", "DB: Mobile", "DB: Mouse" };
        }
    }
}
