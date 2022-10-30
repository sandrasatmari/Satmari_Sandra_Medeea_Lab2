using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Satmari_Sandra_Medeea_Lab2.Data;
using Satmari_Sandra_Medeea_Lab2.Models;

namespace Satmari_Sandra_Medeea_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Satmari_Sandra_Medeea_Lab2.Data.Satmari_Sandra_Medeea_Lab2Context _context;

        public CreateModel(Satmari_Sandra_Medeea_Lab2.Data.Satmari_Sandra_Medeea_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Authors.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
