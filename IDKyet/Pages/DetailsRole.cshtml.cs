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
    public class DetailsRoleModel : PageModel
    {
        private readonly EfcDbInit.Data.ApplicationDbContext _context;

        public DetailsRoleModel(EfcDbInit.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Role Roles { get; set; }

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
                Roles = summs;
            }
            return Page();
        }
    }
}
