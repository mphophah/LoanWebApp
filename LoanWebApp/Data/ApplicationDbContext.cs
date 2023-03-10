using LoanWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanWebApp
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Loan> Loans { get; set; }

        public DbSet<LoanWebApp.Models.LoanViewModel> LoanViewModel { get; set; }

        //public DbSet<LoanWebApp.Models.LoanViewModel> LoanViewModel { get; set; }

    }
}
