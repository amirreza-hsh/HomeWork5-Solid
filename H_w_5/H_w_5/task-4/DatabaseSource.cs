using System.Collections.Generic;

namespace H_w_5.task_4
{
    public class DatabaseSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string>
            {
                "Database Product 1",
                "Database Product 2",
                "Database Product 3"
            };
        }
    }
}
