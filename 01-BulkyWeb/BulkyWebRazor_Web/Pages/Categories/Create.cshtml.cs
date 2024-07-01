using BulkyWebRazor_Web.Data;
using BulkyWebRazor_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Web.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(Category obj) 
        { 
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
