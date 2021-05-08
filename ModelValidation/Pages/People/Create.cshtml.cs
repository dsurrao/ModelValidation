using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ModelValidation.Data;
using ModelValidation.Models;

namespace ModelValidation.Pages.People
{
    public class CreateModel : PageModel
    {
        private readonly ModelValidation.Data.ModelValidationContext _context;

        public CreateModel(ModelValidation.Data.ModelValidationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        [Required]
        public string Name { get; set; }

        [BindProperty]
        public Person Person { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Person.Name = Name;

            ModelState.Clear();

            if (!TryValidateModel(Person))
            {
                return Page();
            }

            _context.Person.Add(Person);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
