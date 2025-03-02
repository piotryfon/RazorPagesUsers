﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesUsers.Data;
using RazorPagesUsers.UserModel;

namespace RazorPagesUsers.Pages.UserPages
{
    public class Details2Model : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Details2Model(ApplicationDbContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users
                .Include(u => u.Role).FirstOrDefaultAsync(m => m.Id == id);

            if (User == null)
            {
                return NotFound();
            }
        
            return Page();
        }
    }
}
