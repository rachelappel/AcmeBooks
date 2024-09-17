namespace AcmeBooksAPI.Services
{
    public class StaffPickService
    { 
        // get 3 employees who are in "Bookstore Associates" positions
        // select a random book for each of them
        // compare books to see if there are dups
        // if so note the duplicate and pick another 
        
        public void WeeklyPick(int employeeId, string[] ISBNs)
        {
            foreach (var ISBN in ISBNs)
            {
                Console.WriteLine(ISBN);
            }
        }
    }


    
}