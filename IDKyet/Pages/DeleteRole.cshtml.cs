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
    public class DeleteRoleModel : PageModel
    {
        private readonly EfcDbInit.Data.ApplicationDbContext _context;

        public DeleteRoleModel(EfcDbInit.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Role Role { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Roles == null)
            {
                return NotFound();
            }

            var summs = await _context.Roles.FirstOrDefaultAsync(m => m.RoleID == id);

            if (summs == null)
            {
                return NotFound();
            }
            else
            {
                Role = summs;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Roles == null)
            {
                return NotFound();
            }
            var summs = await _context.Roles.FindAsync(id);

            if (summs != null)
            {
                Role = summs;
                _context.Roles.Remove(Role);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
