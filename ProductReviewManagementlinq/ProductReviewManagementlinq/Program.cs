using System;
using System.Data;

namespace ProductReviewManagementlinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Product Review Management");
            ProductReviewManagement productReview = new ProductReviewManagement();
            ProductDataTable productDataTable = new ProductDataTable();
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                 new ProductReview() { ProductID = 1, UserID = 1, Rating = 1, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 2, UserID = 2, Rating = 1, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 3, UserID = 3, Rating = 1, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 4, UserID = 4, Rating = 4, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 5, UserID = 5, Rating = 2, Review = "nice", IsLike = false },
                 new ProductReview() { ProductID = 6, UserID = 6, Rating = 2, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 7, UserID = 7, Rating = 2, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 8, UserID = 8, Rating = 2, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 9, UserID = 9, Rating = 3, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 10, UserID = 10, Rating = 3, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 11, UserID = 11, Rating = 1, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 12, UserID = 12, Rating = 5, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 13, UserID = 13, Rating = 3, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 14, UserID = 14, Rating = 2, Review = "very bad", IsLike = false },
                 new ProductReview() { ProductID = 15, UserID = 15, Rating = 2, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 16, UserID = 16, Rating = 2, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 17, UserID = 17, Rating = 2, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 18, UserID = 18, Rating = 2, Review = "average", IsLike = true },
                 new ProductReview() { ProductID = 19, UserID = 19, Rating = 3, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 20, UserID = 20, Rating = 3, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 21, UserID = 21, Rating = 2, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 22, UserID = 22, Rating = 2, Review = "bad", IsLike = false },
                 new ProductReview() { ProductID = 23, UserID = 23, Rating = 2, Review = "good", IsLike = true },
                 new ProductReview() { ProductID = 24, UserID = 24, Rating = 4, Review = "average", IsLike = true },
                 new ProductReview() { ProductID = 25, UserID = 25, Rating = 2, Review = "average", IsLike = true },
            };

            int option = 0;
            do
            {
                Console.WriteLine("1: For Add Product Review");
                Console.WriteLine("2: For Display the Product Review");
                Console.WriteLine("3: For Retrieve the Top three Review ");
                Console.WriteLine("4: For Retrive who's rating is greater than three");
                Console.WriteLine("5: For Retrive count of Review Present");
                Console.WriteLine("6: For Retrive ProductId And Review");
                Console.WriteLine("7: For Skip Top Five Records");
                Console.WriteLine("8: For Retrive UserId And Review");
                Console.WriteLine("9: For Add Product Review In Data Table");
                Console.WriteLine("10: For Display The Data Table Product Review");
                option = int.Parse(Console.ReadLine()); 
                switch(option)
                {
                    case 1:
                        productReview.AddProductReviewManagement();
                        break;
                    case 2:
                        productReview.DisplayProductReviewList(productReviewList);
                        break;
                    case 3:
                        productReview.RetrieveTopThreeRecords(productReviewList);
                        break;
                    case 4:
                        productReview.SelectedRecords(productReviewList);
                        break;
                    case 5:
                        productReview.RetrieveProductID(productReviewList);
                        break;
                    case 6:
                        productReview.RetrieveProductIDAndReview(productReviewList);
                        break;
                    case 7:
                        productReview.SkipTopFive(productReviewList);
                        break;
                    case 8:
                        productReview.RetrieveUserIDAndReview(productReviewList);
                        break;
                    case 9:                        
                        productDataTable.AddProductReviewInDataTable();
                        break;
                    case 10:
                        productDataTable.DisplayDataTable();
                        break;
                    case 11:
                        productReview.IsLikeValueIsTrue(productReviewList);
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (option != 0);
        }
    }
}