using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookStoreRazor_Temp.Data;
using BookStoreRazor_Temp.Models;

namespace BookStoreRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set;  }
        public IndexModel(ApplicationDbContext db) 
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList=_db.Categories.ToList();   
        }
    }
}
