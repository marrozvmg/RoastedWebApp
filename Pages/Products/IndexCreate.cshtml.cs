using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RoastedWebApp.Data;
using RoastedWebApp.Models;

namespace RoastedWebApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly RoastedWebApp.Data.RoastedWebAppContext _context;

        public IndexModel(RoastedWebApp.Data.RoastedWebAppContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
