using Microsoft.Extensions.Hosting;
using System.Security.Cryptography.X509Certificates;

namespace Bank.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public int postId { get; set; }

        public Post Post { get; set; }

  
    }
}
