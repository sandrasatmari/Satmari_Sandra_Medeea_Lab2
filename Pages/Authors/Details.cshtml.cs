using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Satmari_Sandra_Medeea_Lab2.Data;
using Satmari_Sandra_Medeea_Lab2.Models;

namespace Satmari_Sandra_Medeea_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Satmari_Sandra_Medeea_Lab2.Data.Satmari_Sandra_Medeea_Lab2Context _context;

        public DetailsModel(Satmari_Sandra_Medeea_Lab2.Data.Satmari_Sandra_Medeea_Lab2Context context)
        {
            _context = context;
        }

      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }

            var author = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
