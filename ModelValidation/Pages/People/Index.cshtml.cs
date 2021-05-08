using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ModelValidation.Data;
using ModelValidation.Models;

namespace ModelValidation.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly ModelValidation.Data.ModelValidationContext _context;

        public IndexModel(ModelValidation.Data.ModelValidationContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
