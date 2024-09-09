namespace AcmeBooksAPI.Services
{
    public class PricingService
    {
        /// <summary>
        /// Calculates the price of a given number of books based on the price per book and any applicable discounts.
        /// </summary>
        /// <param name="numberOfBooks">The number of books to calculate the price for.</param>
        /// <param name="pricePerBook">The price per book.</param>
        /// <returns>The calculated price after applying any discounts.</returns>
        public decimal CalculatePrice(int numberOfBooks, decimal pricePerBook)
        {
            decimal discount;
            switch (numberOfBooks)
            {
                case > 50:
                    discount = 0.20M;
                    break;
                case > 25:
                    discount = 0.15M;
                    break;
                case >= 11:
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