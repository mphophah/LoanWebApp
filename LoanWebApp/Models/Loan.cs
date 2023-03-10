using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanWebApp.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        public string LoanType { get; set; }
        public string Amount { get; set; }
        public DateTime LoanDateCreated { get; set; }
    }
}
