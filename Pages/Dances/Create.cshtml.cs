#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using gendarazorpages.Data;

namespace gendarazorpages.Pages.Dances
{
    public class CreateModel : PageModel
    {
        private readonly gendarazorpages.Data.gendarazorpagesContext _context;

        public CreateModel(gendarazorpages.Data.gendarazorpagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dances Dances { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dances.Add(Dances);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
