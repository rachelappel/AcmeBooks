namespace AcmeBooksAPI.Services
{
    public class Schedule
    {
        private Dictionary<int, List<DateOnly>> weeklySchedule
            = new Dictionary<int, List<DateOnly>>();
        
        // collection expression 
        private readonly List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 2, Name = "Robert Johnson" },
            new Employee { Id = 4, Name = "Alice Glastonbury" },
            new Employee { Id = 6, Name = "Michael Brown" },
            new Employee { Id = 7, Name = "Patricia Wilson" },
            new Employee { Id = 9, Name = "Laura Taylor" },
            new Employee { Id = 10, Name = "Matthew Moore" }
        };

        public Dictionary<int, List<DateOnly>> CreateSchedule()
        {

            List<DateOnly> dates = new List<DateOnly>();
            var id = 0;
            foreach (var e in employees)
            {
                id = e.Id;
                dates.Add(DateOnly.FromDateTime(DateTime.Today).AddDays(1));
            }
                
            weeklySchedule.Add(id, dates);
            return weeklySchedule;
        }
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

