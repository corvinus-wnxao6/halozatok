using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HajosTeszt.wwwroot
{
    public class BoatController : Controller
    {
        public IActionResult Index()
        {
            return View();
            [HttpGet]
            [Route("questions/{sorszám}")]
            public ActionResult M2(int sorszám)
            {
                HajostesztContext context = new HajostesztContext();
                var kérdés = (from x in context.Questions
                              where x.QuestionId == sorszám
                              select x).FirstOrDefault();

                if (kérdés == null) return BadRequest("Nincs ilyen sorszámú kérdés");

                return new JsonResult(kérdés);
            }
    }
}
