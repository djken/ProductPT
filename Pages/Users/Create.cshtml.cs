using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProduitsPT.Models;

namespace ProduitsPT.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly ProduitsPT.Data.ProduitsDBontext _context;

        public CreateModel(ProduitsPT.Data.ProduitsDBontext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid || _context.Users == null || User == null)
            //  {
            //return Page();
            //}

            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
