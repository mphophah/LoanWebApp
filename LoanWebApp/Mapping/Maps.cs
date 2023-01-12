using AutoMapper;
using LoanWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanWebApp
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Loan, LoanViewModel>().ReverseMap();
        }
    }
}
