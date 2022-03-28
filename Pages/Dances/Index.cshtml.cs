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
    public class IndexModel : PageModel
    {
        private readonly gendarazorpages.Data.gendarazorpagesContext _context;

        public IndexModel(gendarazorpages.Data.gendarazorpagesContext context)
        {
            _context = context;
        }

        public IList<Dances> Dances { get;set; }

        public async Task OnGetAsync()
        {
            Dances = await _context.Dances.ToListAsync();
        }
    }
}
