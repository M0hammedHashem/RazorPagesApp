using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorAppData.Data;
using RazorAppModels;

namespace RazorApp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<Category> Categories { get; set; }
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Categories = _context.Categories.OrderBy(c=>c.DisplayOrder).ToList();
        }
    }
}
