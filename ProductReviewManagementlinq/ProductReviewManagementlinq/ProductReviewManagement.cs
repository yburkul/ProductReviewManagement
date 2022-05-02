using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementlinq
{
    public class ProductReviewManagement
    {
        List<ProductReview> ProductReviewList;
        public ProductReviewManagement()
        {
            ProductReviewList = new List<ProductReview>();
        }
        public void AddProductReviewManagement()
        {
            ProductReviewList.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 2, UserID = 2, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 3, UserID = 3, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 4, UserID = 4, Rating = 4, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 5, UserID = 5, Rating = 2, Review = "nice", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 6, UserID = 6, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 7, UserID = 7, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 8, UserID = 8, Rating = 2, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 9, UserID = 9, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 10, UserID = 10, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 11, UserID = 11, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 12, UserID = 12, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 13, UserID = 13, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 14, UserID = 14, Rating = 2, Review = "very bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 15, UserID = 15, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 16, UserID = 16, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 17, UserID = 17, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 18, UserID = 18, Rating = 2, Review = "average", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 19, UserID = 19, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 20, UserID = 20, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 21, UserID = 21, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 22, UserID = 22, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 23, UserID = 23, Rating = 2, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 24, UserID = 24, Rating = 4, Review = "average", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 25, UserID = 25, Rating = 2, Review = "average", IsLike = true });
            Console.WriteLine("Product Review is Added");
        }
        public void DisplayProductReviewList(List<ProductReview> ProductsReviewList)
        {
            foreach (var ProductReview in ProductReviewList)
            {
                Console.WriteLine("Product ID: {0}, \nUser ID: {1}, \nRating: {2}, \nReview: {3}, " +
                    "\nIs Like: {4} \n", ProductReview.ProductID, ProductReview.UserID, ProductReview.Rating, ProductReview.Review,
                     ProductReview.IsLike);
            }
        }
        public void RetrieveTopThreeRecords(List<ProductReview> ProductReviewList)
        {
            var recordedData = (from productReviews in ProductReviewList orderby productReviews.Rating descending select productReviews).Take(3).ToList();

            foreach(var recordedRecord in recordedData)
            {
                Console.WriteLine("Product ID: {0}, \nUser ID: {1}, \nRating: {2}, \nReview: {3}, " +
                    "\nIs Like: {4} \n", recordedRecord.ProductID, recordedRecord.UserID, recordedRecord.Rating, recordedRecord.Review,
                     recordedRecord.IsLike);
            }
        }
        public void SelectedRecords(List<ProductReview> ProductReview)
        {
            var recordedData = from productReviews in ProductReview
                               where (productReviews.ProductID == 1 ||
                                     productReviews.ProductID == 4 ||
                                     productReviews.ProductID == 9) && (productReviews.Rating > 3)
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.ProductID + " " + "UserId:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike :- " + list.IsLike);
            }
        }
        public void RetrieveProductID(List<ProductReview> ProductReview)
        {
            var recordedData = ProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("Count of records by ProductID: ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "--->" + "Count: " + list.Count);

            }
        }
        public void RetrieveProductIDAndReview(List<ProductReview> ProductReview)
        {
            var recordedData = (from list in ProductReview select new { list.ProductID, list.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ToString());
            }
        }
        public void SkipTopFive(List<ProductReview> ProductReview)
        {
            var recordedData = (from list in ProductReview orderby list.Rating ascending select list).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.ProductID + " " + "UserId:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike :- " + list.IsLike);
            }
        }
    }
}