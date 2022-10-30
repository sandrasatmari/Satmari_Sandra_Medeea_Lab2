﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Satmari_Sandra_Medeea_Lab2.Data.Satmari_Sandra_Medeea_Lab2Context _context;

        public IndexModel(Satmari_Sandra_Medeea_Lab2.Data.Satmari_Sandra_Medeea_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Author = await _context.Authors.ToListAsync();
            }
        }
    }
}
