using Microsoft.AspNetCore.Mvc;

namespace TelerikAspNetCoreApp.tiket._2022121901.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
           
        }



        public JsonResult biblio_read(string text)
        {

            var list = new List<Biblio>();

            list.Add(new Biblio() { BiblioId = 1, Title = "Biblio 1" });
            list.Add(new Biblio() { BiblioId = 2, Title = "Biblio 2" });
            list.Add(new Biblio() { BiblioId = 3, Title = "Biblio 3" });

            if (!string.IsNullOrEmpty(text))
            {
                list = list.Where(p => p.Title.Contains(text)).ToList();
            }

            return Json(list.ToList());

        }


    }


    public partial class Biblio
    {
        public int BiblioId { get; set; }
        public string Title { get; set; }

    }
}
