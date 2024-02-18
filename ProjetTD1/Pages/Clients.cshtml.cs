using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetTD1.Models;

namespace ProjetTD1.Pages
{
    public class ClientsModel : PageModel
    {
        private MyDbContext context = new MyDbContext();
        public List<Customer> Customers { get; set; }
        public void OnGet()
        {
            Customers = context.Customers.Include(a =>a.Orders).ToList();
            
        }
    }
}
