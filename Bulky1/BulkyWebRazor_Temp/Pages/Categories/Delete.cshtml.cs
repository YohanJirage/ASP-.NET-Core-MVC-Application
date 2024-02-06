using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class DeleteModel : PageModel

    {
        private ApplicationDbContext _context;
        [BindProperty]
        public Category Cat { get; set; }
        public DeleteModel (ApplicationDbContext _db)
        {
            _context = _db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id > 0)
            {
                Cat = _context.categories.Find(id);

            }
        }
        public IActionResult OnPost()
        {
            if(Cat != null)
            {
                _context.categories.Remove(Cat);
                _context.SaveChanges();
                TempData["success"] = "Category Is Deleted";
            }
            return RedirectToPage("Index");
        }
    }
}
