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
    public class RoleModel : PageModel
    {
        private readonly EfcDbInit.Data.ApplicationDbContext _context;

        public RoleModel(EfcDbInit.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Role> Roles { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Roles != null)
            {
                Roles = await _context.Roles.ToListAsync();
            }
        }
    }
}
