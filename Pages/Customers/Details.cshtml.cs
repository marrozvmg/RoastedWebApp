using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RoastedWebApp.Data;
using RoastedWebApp.Models;

namespace RoastedWebApp.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly RoastedWebApp.Data.RoastedWebAppContext _context;

        public DetailsModel(RoastedWebApp.Data.RoastedWebAppContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
