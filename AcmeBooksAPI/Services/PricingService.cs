using System.Security.Cryptography;
using AcmeBooksAPI.Models;

namespace AcmeBooksAPI.Services
{
    public class PricingService
    {
        private List<Book> weeklyDiscountBooks = new List<Book>();
        
        
        public PricingService(List<Book> weeklyDiscountBooks)
        {
            this.weeklyDiscountBooks = weeklyDiscountBooks;
        }
    
        public void CalculateAudiobookPricesWithDiscount(decimal discountPercentage)
        {
            // discounts for short audiobooks
            var audioBooks = 
                weeklyDiscountBooks.OfType<AudioBook>()
                    .Where(b => b.Language == Language.English &&  b.Length < 30);
            
            foreach (var audioBook in audioBooks)
            {
                decimal discountedPrice = audioBook.Price - (audioBook.Price * discountPercentage);
                audioBook.Price = discountedPrice;
            }
        }

        /// <summary>
        /// Calculates the price of a given number of books based on the price per book and any applicable discounts.
        /// </summary>
        /// <param name="numberOfBooks">The number of books to calculate the price for.</param>
        /// <param name="pricePerBook">The price per book.</param>
        /// <returns>The calculated price after applying any discounts.</returns>
        public decimal CalculateBulkPurchasePrice(int numberOfBooks, decimal pricePerBook)
        {
            decimal discount;
            switch (numberOfBooks)
            {
                case > 100:
                    discount = 0.22M;
                    break;
                case > 50 and < 100:
                    discount = 0.20M;
                    break;
                case > 25 and <=50:
                    discount = 0.15M;
                    break;
                case >= 11 and <=25:
                    discount = 0.10M;
                    break;
                default:
                    discount = 0;
                    break;
            }

            decimal totalPrice = numberOfBooks * pricePerBook;
            decimal discountAmount = totalPrice * discount;
            return totalPrice - discountAmount;
        }
    }
}