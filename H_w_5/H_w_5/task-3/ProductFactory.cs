using H_w_5.task_2;
using System;

namespace H_w_5.task_3
{
    public class ProductFactory
    {
        public static IProductDataSource Create(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("recource type cant be empty!.");
            }

            switch (type.Trim().ToLower())
            {
                case "database":
                    return new DatabaseSource();

                case "api":
                    return new ApiSource();

                case "file":
                    return new FileSource();

                default:
                    throw new ArgumentException($"'{type}' recouce data is invalid!");
            }
        }
    }
}
