

namespace Bank.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public int PostId { get; set; }
        public string Title { get; set; }
        public Post Post { get; set; }

  
    }
}
