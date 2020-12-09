using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RoastedWebApp.Data;
using RoastedWebApp.Models;

namespace RoastedWebApp.Pages.ProductTypes
{
    public class DeleteModel : PageModel
    {
        private readonly RoastedWebApp.Data.RoastedWebAppContext _context;

        public DeleteModel(RoastedWebApp.Data.RoastedWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductType ProductType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductType = await _context.ProductType.FirstOrDefaultAsync(m => m.ID == id);

            if (ProductType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductType = await _context.ProductType.FindAsync(id);

            if (ProductType != null)
            {
                _context.ProductType.Remove(ProductType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
