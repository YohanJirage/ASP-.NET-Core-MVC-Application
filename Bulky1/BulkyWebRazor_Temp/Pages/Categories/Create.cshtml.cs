using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext  _context;
        [BindProperty]
        public Category? Cat { get; set; }

        public CreateModel (ApplicationDbContext _db)
        {
            _context = _db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost( )
        {
            if(Cat != null )
            {
                _context.categories.Add(Cat);
                _context.SaveChanges();
                TempData["success"] = "Category Is Created";

            }
            
            return RedirectToPage("Index");

        }
    }
}
