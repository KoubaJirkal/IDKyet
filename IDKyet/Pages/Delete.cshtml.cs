using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EfcDbInit.Data;
using EfcDbInit.Models;

namespace IDKyet.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly EfcDbInit.Data.ApplicationDbContext _context;

        public DeleteModel(EfcDbInit.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Summs Summs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Summs == null)
            {
                return NotFound();
            }

            var summs = await _context.Summs.FirstOrDefaultAsync(m => m.Id == id);

            if (summs == null)
            {
                return NotFound();
            }
            else 
            {
                Summs = summs;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Summs == null)
            {
                return NotFound();
            }
            var summs = await _context.Summs.FindAsync(id);

            if (summs != null)
            {
                Summs = summs;
                _context.Summs.Remove(Summs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
