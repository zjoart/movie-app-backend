using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using firstnetapp.Data;
using firstnetapp.Models;

namespace firstnetapp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly firstnetapp.Data.firstnetappContext _context;

        public IndexModel(firstnetapp.Data.firstnetappContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
