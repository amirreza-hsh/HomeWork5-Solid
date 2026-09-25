using H_w_5.task_2;
using System.Collections.Generic;

namespace H_w_5.task_3
{
    public class FileSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string> { "File: Book", "File: Pen" };
        }
    }
}
