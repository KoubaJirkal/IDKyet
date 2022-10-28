using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EfcDbInit.Data;
using EfcDbInit.Models;

namespace IDKyet.Pages
{
    public class EditModel : PageModel
    {
        private readonly EfcDbInit.Data.ApplicationDbContext _context;

        public EditModel(EfcDbInit.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Summs Summs { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Summs == null)
            {
                return NotFound();
            }

            var summs =  await _context.Summs.FirstOrDefaultAsync(m => m.Id == id);
            if (summs == null)
            {
                return NotFound();
            }
            Summs = summs;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {


            _context.Attach(Summs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SummsExists(Summs.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SummsExists(int id)
        {
          return _context.Summs.Any(e => e.Id == id);
        }
    }
}
