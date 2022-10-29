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
    public class ChampionsModel : PageModel
    {
        private readonly EfcDbInit.Data.ApplicationDbContext _context;

        public ChampionsModel(EfcDbInit.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Role> Roles { get; set; } = default!;
        public IList<Champions> Champions { get; set; } = default!;



        public async Task OnGetAsync()
        {
            if (_context.Champions != null)
            {
                Champions = await _context.Champions.ToListAsync();
            }
            if (_context.Roles != null)
            {
                Roles = await _context.Roles.Include(b => b.Champions).ToListAsync();

            }
        }
    }
}
