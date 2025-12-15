using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Apple_Store.Data;
using Apple_Store.Models;

namespace Apple_Store.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly Apple_Store.Data.Apple_StoreContext _context;

        public IndexModel(Apple_Store.Data.Apple_StoreContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
