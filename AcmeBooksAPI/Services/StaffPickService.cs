namespace AcmeBooksAPI.Services
{
    // init only setters (editor's picks)
    // params collection
    // pattern matching (match by genre)
    public class StaffPickService
    { 
        // get 3 employees who are in "Bookstore Associates" positions
        // select a random book for each of them
        // compare books to see if there are dups
        // if so note the duplicate and pick another 
        public void WeeklyPick(int employeeId, params string[] ISBNs)
        {
            foreach (var ISBN in ISBNs)
            {
                Console.WriteLine(ISBN);
            }
        }
        
        public void PickFromGenre(string Genre)
        {
            throw new NotImplementedException();
        }

        public void AutoPickAll(DateTime weekOf)
        {
            
        }
        
    }


    
}