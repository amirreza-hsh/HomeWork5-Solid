using System;
using System.Collections.Generic;
using System.Text;

namespace H_w_5.task_2
{
    public class DatabaseProductDataSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Laptop (from DB)", "Mouse (from DB)" };
        }
    }

    public class ApiProductDataSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Keyboard (from API)", "Monitor (from API)" };
        }
    }

    public class FileProductDataSource : IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Headset (from File)", "Webcam (from File)" };
        }
    }

}
