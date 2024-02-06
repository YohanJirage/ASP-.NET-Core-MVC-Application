using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Category> categoryList { get; set; } 

        public IndexModel(ApplicationDbContext _db)
        {
            _context = _db;
        }
        public void OnGet()
        {
            categoryList = _context.categories.ToList();
        }
    }
}
