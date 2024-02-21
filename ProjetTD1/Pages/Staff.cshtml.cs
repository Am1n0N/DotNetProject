using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetTD1.Models;

namespace ProjetTD1.Pages
{
    public class StaffModel : PageModel
    {
        private MyDbContext context = new MyDbContext();
        public List<Staff> workers { get; set; }

      
        public void OnGet()
        {
            workers = context.Staffs.Include(a =>a.Store).Include(a =>a.Manager)
                .Include(a =>a.Orders).ThenInclude(a =>a.OrderItems).ThenInclude(a =>a.Product)
                .ToList();
        }
    }
}
