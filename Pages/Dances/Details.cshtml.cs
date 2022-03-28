#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using gendarazorpages.Data;

namespace gendarazorpages.Pages.Dances
{
    public class DetailsModel : PageModel
    {
        private readonly gendarazorpages.Data.gendarazorpagesContext _context;

        public DetailsModel(gendarazorpages.Data.gendarazorpagesContext context)
        {
            _context = context;
        }

        public Dances Dances { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dances = await _context.Dances.FirstOrDefaultAsync(m => m.ID == id);

            if (Dances == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
