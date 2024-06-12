using catalogo_de_filme.Models;
using Microsoft.AspNetCore.Mvc;

namespace catalogo_de_filme.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            var cards = new List<Card>
            {
                new Card {Id = 1, Title = "Card 1", Description = "Descrição do Card", ImageUrl = ""},
                new Card {Id = 2, Title = "Card 2", Description = "Descrição do Card", ImageUrl = ""},
                new Card {Id = 3, Title = "Card 3", Description = "Descrição do Card", ImageUrl = ""}
            };
            return View(cards);
        }
    }
}
