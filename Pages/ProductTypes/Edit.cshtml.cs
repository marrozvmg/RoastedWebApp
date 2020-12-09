using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoastedWebApp.Data;
using RoastedWebApp.Models;

namespace RoastedWebApp.Pages.ProductTypes
{
    public class EditModel : PageModel
    {
        private readonly RoastedWebApp.Data.RoastedWebAppContext _context;

        public EditModel(RoastedWebApp.Data.RoastedWebAppContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProductType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeExists(ProductType.ID))
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

        private bool ProductTypeExists(int id)
        {
            return _context.ProductType.Any(e => e.ID == id);
        }
    }
}
