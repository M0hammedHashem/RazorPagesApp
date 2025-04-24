using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorAppData.Data;
using RazorAppModels;

namespace RazorApp.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public Category Category { get; set; }
        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            Category = _context.Categories.Find(id);
        }
        public IActionResult OnPost() {

            _context.Categories.Remove(Category);
            _context.SaveChanges();
            TempData["Success"] = "Category Deleted Successfully";

            return RedirectToPage("index");
        }
    }
}
