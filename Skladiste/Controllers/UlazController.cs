using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Skladiste.Data;
using Skladiste.Models;

namespace Skladiste.Controllers
{
    [Authorize]
    public class UlazController : Controller
    {
        ApplicationDbContext _db;
        [BindProperty]
        public Artikal artikal { get; set; }

        public UlazController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int id)
        {

            artikal = _db.Artikal.FirstOrDefault(m => m.Id == id);
            return View(artikal);
        }

        [HttpPost, ActionName("Index")]

        public IActionResult Index(int id, [Bind("Ulaz")] decimal ulaz)
        {

            {
                var artikli = _db.Artikal.ToList();

                var artikal = _db.Artikal.FirstOrDefault(x => x.Id == id);

                if (artikal == null)
                {
                    return BadRequest();
                }

                artikal.Kolicina += ulaz;
                _db.Update(artikal);
                _db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }






        }

    }
}