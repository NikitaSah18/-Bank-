using System;

namespace Bank.Models
{
    public class NumberOfContract
    {
        public int Id { get; set; }
        public int StatementId { get; set; }
        public DateTime dateOfcontract { get; set; }
        public int EmployeeId { get; set; }
        public int ChartNumber { get; set; }

        public Statement Statement { get; set; }

        public Employee Employee { get; set; }
    

  

    }
}
