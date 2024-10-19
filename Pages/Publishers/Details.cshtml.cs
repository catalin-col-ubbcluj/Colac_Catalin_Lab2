using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Colac_Catalin_Lab2.Data;
using Colac_Catalin_Lab2.Models;

namespace Colac_Catalin_Lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Colac_Catalin_Lab2.Data.Colac_Catalin_Lab2Context _context;

        public DetailsModel(Colac_Catalin_Lab2.Data.Colac_Catalin_Lab2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.Id == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
