namespace AcmeBooksAPI.Services
{
    public class Pricing
    {
        /// <summary>
        /// Calculates the price of a given number of books based on the price per book and any applicable discounts.
        /// </summary>
        /// <param name="numberOfBooks">The number of books to calculate the price for.</param>
        /// <param name="pricePerBook">The price per book.</param>
        /// <returns>The calculated price after applying any discounts.</returns>
        public decimal CalculatePrice(int numberOfBooks, decimal pricePerBook)
        {
            decimal discount = numberOfBooks switch
            {
                > 50 => 0.20M,
                > 25 => 0.15M,
                >= 11 => 0.10M,
                _ => 0
            };

            decimal totalPrice = numberOfBooks * pricePerBook;
            decimal discountAmount = totalPrice * discount;
            return totalPrice - discountAmount;
        }
    }
}