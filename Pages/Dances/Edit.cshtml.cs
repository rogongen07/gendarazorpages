#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gendarazorpages.Data;

namespace gendarazorpages.Pages.Dances
{
    public class EditModel : PageModel
    {
        private readonly gendarazorpages.Data.gendarazorpagesContext _context;

        public EditModel(gendarazorpages.Data.gendarazorpagesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dances).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DancesExists(Dances.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DancesExists(int id)
        {
            return _context.Dances.Any(e => e.ID == id);
        }
    }
}
