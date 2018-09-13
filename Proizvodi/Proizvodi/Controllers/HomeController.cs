using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proizvodi.Models;

namespace Proizvodi.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ProizvodiContext db;

        public HomeController(ProizvodiContext _db)
        {
            db = _db;
        }

        public JsonResult VratiProizvodeJson()
        {
            List<Proizvod> listaProizvoda = new List<Proizvod>();

            using (SqlConnection konekcija = new SqlConnection(Konekcija.cnnProizvodi))
            {
                using (SqlCommand komanda = new SqlCommand("SELECT * FROM Proizvod",konekcija))
                {
                    try
                    {
                        konekcija.Open();
                        using (SqlDataReader dr = komanda.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Proizvod p = new Proizvod
                                {
                                    Id = dr.GetInt32(0),
                                    Naziv = dr.GetString(1),
                                    Opis = dr.GetString(2),
                                    Kategorija = dr.GetString(3),
                                    Proizvodjac = dr.GetString(4),
                                    Cena = dr.GetDecimal(5)
                                };

                                listaProizvoda.Add(p);
                            }
                        }

                        return Json(listaProizvoda);
                    }
                    catch (Exception)
                    {

                        return Json("Greska");
                    }
                }
            }
        }

        public IActionResult Index()
        {
            return View(db.Proizvod.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
