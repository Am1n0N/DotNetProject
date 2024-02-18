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
        public void OnGet()
        {
            //afficher productName, Marque(nom), CategoryName,, NBCommandesPasses
            Products = context.Products.Include(a =>a.Brand).Include(a =>a.Category).Include(a =>a.OrderItems).ToList();
            //Ajouter une colonne à la page produits qui permet d'afficher pour chaque produit la qté commandée use sum
            

        }
    }
}
