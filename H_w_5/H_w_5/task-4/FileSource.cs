using System.Collections.Generic;

namespace H_w_5.task_4
{
    public class FileSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string>
            {
                "File Product 1",
                "File Product 2",
                "File Product 3"
            };
        }
    }
}
