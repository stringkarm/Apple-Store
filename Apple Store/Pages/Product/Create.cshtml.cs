using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Apple_Store.Data;
using Apple_Store.Models;

namespace Apple_Store.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly Apple_Store.Data.Apple_StoreContext _context;

        public CreateModel(Apple_Store.Data.Apple_StoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Products Products { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Products);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
