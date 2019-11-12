using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Skladiste.Data;
using Skladiste.Models;

namespace Skladiste.Controllers
{
    [Authorize]
    public class IzlazController : Controller
    {
        ApplicationDbContext _db;
        [BindProperty]
        public Artikal artikal { get; set; }

        public IzlazController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int id)
        {

            artikal = _db.Artikal.FirstOrDefault(m => m.Id == id);
            return View(artikal);

        }

        [HttpPost, ActionName("Index")]

        public IActionResult Index(int id, [Bind("Izlaz")] decimal izlaz)
        {

            {
                var artikli = _db.Artikal.ToList();

                var artikal = _db.Artikal.FirstOrDefault(x => x.Id == id);

                if (artikal == null)
                {
                    return BadRequest();
                }

                artikal.Kolicina -= izlaz;
                _db.Update(artikal);
                _db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
        }
    }
}