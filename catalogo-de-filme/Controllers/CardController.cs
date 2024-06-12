using Microsoft.AspNetCore.Mvc;
using catalogo_de_filme.Models;
using System.Collections.Generic;


namespace catalogo_de_filme.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            var cards = new List<CardModel>
            {
                new CardModel {Id = 1, Title = "Card 1", Description = "Descrição do Card", ImageUrl = "~/logoSpfc.png"},
                new CardModel {Id = 2, Title = "Card 2", Description = "Descrição do Card", ImageUrl = "~/logoSpfc.png"},
                new CardModel {Id = 3, Title = "Card 3", Description = "Descrição do Card", ImageUrl = "~/logoSpfc.png"}
            };
            return View(cards);
        }
    }
}
