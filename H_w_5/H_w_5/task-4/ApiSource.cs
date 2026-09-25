using System.Collections.Generic;

namespace H_w_5.task_4
{
    public class ApiSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string>
            {
                "API Product 1",
                "API Product 2",
                "API Product 3"
            };
        }
    }
}
