using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Colac_Catalin_Lab2.Data;
using Colac_Catalin_Lab2.Models;

namespace Colac_Catalin_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Colac_Catalin_Lab2.Data.Colac_Catalin_Lab2Context _context;

        public CreateModel(Colac_Catalin_Lab2.Data.Colac_Catalin_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var authors = _context.Set<Author>()
                .Select(a => new
                {
                    Id = a.Id,
                    FullName = $"{a.FirstName} {a.LastName}"
                })
                .ToList();

            ViewData["AuthorId"] = new SelectList(authors, "Id", "FullName");
            ViewData["PublisherId"] = new SelectList(_context.Set<Publisher>(), "Id", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
