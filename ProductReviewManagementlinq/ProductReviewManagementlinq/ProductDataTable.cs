using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementlinq
{
    public class ProductDataTable
    {
        DataTable dataTable = new DataTable();
        public ProductDataTable()
        {
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(int));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(string));
        }
        public void AddProductReviewInDataTable()
        {
            dataTable.Rows.Add(1, 1, 5, "Good", "true");
            dataTable.Rows.Add(2, 1, 4, "Good", "true");
            dataTable.Rows.Add(3, 2, 7, "Nice", "false");
            dataTable.Rows.Add(4, 2, 2, "bad", "true");
            dataTable.Rows.Add(5, 3, 8, "Nice", "true");
            dataTable.Rows.Add(6, 4, 9, "Nice", "true");
            dataTable.Rows.Add(7, 5, 2, "bad", "true");
            dataTable.Rows.Add(8, 5, 7, "nice", "false");
            dataTable.Rows.Add(9, 5, 5, "Good", "true");
            dataTable.Rows.Add(10, 6, 4, "Good", "true");
            dataTable.Rows.Add(11, 7, 5, "Good", "true");
            dataTable.Rows.Add(12, 8, 2, "bad", "false");
            dataTable.Rows.Add(13, 8, 7, "Good", "false");
            dataTable.Rows.Add(14, 9, 6, "Good", "true");
            dataTable.Rows.Add(15, 10, 8, "Nice", "true");
            dataTable.Rows.Add(16, 11, 4, "avarage", "true");
            dataTable.Rows.Add(17, 11, 3, "bad", "true");
            dataTable.Rows.Add(18, 12, 1, "bad", "false");
            dataTable.Rows.Add(19, 13, 7, "Good", "true");
            dataTable.Rows.Add(20, 14, 2, "bad", "true");
            dataTable.Rows.Add(21, 15, 6, "Good", "true");
            dataTable.Rows.Add(22, 16, 4, "Good", "false");
            dataTable.Rows.Add(23, 17, 9, "avarage", "true");
            dataTable.Rows.Add(24, 18, 5, "Good", "true");
            dataTable.Rows.Add(25, 19, 7, "Nice", "false");
            dataTable.Rows.Add(31, 10, 5, "Good", "true");
            dataTable.Rows.Add(32, 10, 4, "Good", "true");
            dataTable.Rows.Add(33, 10, 7, "Nice", "false");
            dataTable.Rows.Add(34, 10, 2, "bad", "true");
            dataTable.Rows.Add(35, 10, 8, "Nice", "true");
            dataTable.Rows.Add(36, 10, 9, "Nice", "true");
            Console.WriteLine("Product Review is Added in DataTable");
            Console.WriteLine();
        }
        public void DisplayDataTable()
        {
            foreach (var table in dataTable.AsEnumerable())
            {
                Console.WriteLine("\nProductID: " + table.Field<int>("ProductID"));
                Console.WriteLine("UserID: " + table.Field<int>("UserId"));
                Console.WriteLine("Rating: " + table.Field<int>("Rating"));
                Console.WriteLine("Review: " + table.Field<string>("Review"));
                Console.WriteLine("IsLike: " + table.Field<string>("IsLike"));
            }
        }
        public void IsLikeValueIsTrue()
        {
            var Product = dataTable.AsEnumerable().Where(x => x.Field<string>("IsLike") == "true");
            int count = Product.Count();
            if (count > 0)
            {
                foreach (var table in Product)
                {
                    Console.WriteLine("\nProductID: " + table.Field<int>("ProductID"));
                    Console.WriteLine("UserID: " + table.Field<int>("UserId"));
                    Console.WriteLine("Rating: " + table.Field<int>("Rating"));
                    Console.WriteLine("Review: " + table.Field<string>("Review"));
                    Console.WriteLine("IsLike: " + table.Field<string>("IsLike"));
                }
            }
            else
            {
                Console.WriteLine("Product Review Does not Found!");
            }
        }
        public void RetreveDataContainsNiceReview()
        {
            var Product = dataTable.AsEnumerable().Where(x => x.Field<string>("Review") == "Nice");
            int count = Product.Count();
            if (count > 0)
            {
                foreach (var table in Product)
                {
                    Console.WriteLine("\nProductID: " + table.Field<int>("ProductID"));
                    Console.WriteLine("UserID: " + table.Field<int>("UserId"));
                    Console.WriteLine("Rating: " + table.Field<int>("Rating"));
                    Console.WriteLine("Review: " + table.Field<string>("Review"));
                    Console.WriteLine("IsLike: " + table.Field<string>("IsLike"));
                }
            }
            else
            {
                Console.WriteLine("Product Review Does not Found!");
            }
        }

        public void RetrieveDataOfSpecificUserId()
        {
            var Product = dataTable.AsEnumerable().Where(x => x.Field<int>("UserId") == 10).OrderBy(x => x.Field<int>("Rating"));
            int count = Product.Count();
            if (count > 0)
            {
                foreach (var table in Product)
                {
                    Console.WriteLine("\nProductID: " + table.Field<int>("ProductID"));
                    Console.WriteLine("UserID: " + table.Field<int>("UserId"));
                    Console.WriteLine("Rating: " + table.Field<int>("Rating"));
                    Console.WriteLine("Review: " + table.Field<string>("Review"));
                    Console.WriteLine("IsLike: " + table.Field<string>("IsLike"));
                }
            }
            else
            {
                Console.WriteLine("Product Review Does not Found!");
            }
        }
    }
}
