using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProduitsPT.Data;
using ProduitsPT.Models;

namespace ProduitsPT.Pages.Products
{
    public class SetPricesModel : PageModel
    {
        private readonly ProduitsDBontext _context;

        public SetPricesModel(ProduitsDBontext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Product.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            foreach (var postedProduct in Products)
            {
                var productInDb = await _context.Product.FindAsync(postedProduct.Id);
                if (productInDb != null)
                {
                    productInDb.Price = postedProduct.Price;
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    foreach (var product in Products)
        //    {
        //        _context.Attach(product).State = EntityState.Modified;
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToPage("./Index");
        //}
    }

}
