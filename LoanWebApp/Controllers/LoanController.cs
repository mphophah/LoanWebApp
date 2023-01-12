using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanWebApp.Controllers
{
    public class LoanController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper; 

        public LoanController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var listLoans = _db.Loans.ToList();
            return View(listLoans);
        }

    }
}
