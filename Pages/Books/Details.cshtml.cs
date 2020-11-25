using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sorea_Stefania_Lab8.Data;
using Sorea_Stefania_Lab8.Models;

namespace Sorea_Stefania_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Sorea_Stefania_Lab8.Data.Sorea_Stefania_Lab8Context _context;

        public DetailsModel(Sorea_Stefania_Lab8.Data.Sorea_Stefania_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
