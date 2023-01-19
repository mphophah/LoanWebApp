using AutoMapper;
using LoanWebApp.Models;
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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(LoanViewModel model)
        {
            var Load_add = _mapper.Map<Loan>(model);

            _db.Loans.Add(Load_add);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var loanData = _db.Loans.Find(id);
            var model = _mapper.Map<LoanViewModel>(loanData);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(LoanViewModel model)
        {
            var loanData = _mapper.Map<Loan>(model);
            _db.Loans.Update(loanData);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var loanData = _db.Loans.Find(id);
            _db.Loans.Remove(loanData);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var loanData = _db.Loans.Find(id);
            var model = _mapper.Map<LoanViewModel>(loanData);
            return View(model);
        }
    }
}
