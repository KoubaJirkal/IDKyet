using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EfcDbInit.Data;
using EfcDbInit.Models;

namespace IDKyet.Pages
{
    public class CreateModel : PageModel
    {
        private readonly EfcDbInit.Data.ApplicationDbContext _context;

        public CreateModel(EfcDbInit.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Summs Summs { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Summs.Add(Summs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
