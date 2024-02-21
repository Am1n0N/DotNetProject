using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetTD1.Models;

namespace ProjetTD1.Pages
{
    public class ProduitsModel : PageModel
    {
        private MyDbContext context = new MyDbContext();
        public List<Product> Products { get; set; }

        public List<Store> Stores { get; set; }
     
        public void OnGet()
        {
           
            Products = context.Products.Include(a =>a.Brand).Include(a =>a.Category).Include(a =>a.OrderItems)
                .Include(a =>a.Stocks).ThenInclude(st => st.Store)
                .ToList();

            Stores = context.Stores.ToList();
            
        }
    }
}
