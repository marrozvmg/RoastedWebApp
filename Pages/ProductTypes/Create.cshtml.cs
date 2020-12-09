using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RoastedWebApp.Data;
using RoastedWebApp.Models;

namespace RoastedWebApp.Pages.ProductTypes
{
    public class CreateModel : PageModel
    {
        private readonly RoastedWebApp.Data.RoastedWebAppContext _context;

        public CreateModel(RoastedWebApp.Data.RoastedWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProductType ProductType { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductType.Add(ProductType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
