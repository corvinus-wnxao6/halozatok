using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HajosTeszt.TarotModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HajosTeszt.Controllers
{
    [Route("api/tarotcontroller")]
    [ApiController]
    public class TarotController : ControllerBase
    {
        // GET: api/<TarotController>
        [HttpGet]
        public IEnumerable<Wnxao6> Get()
        {
            SzamhaloContext context = new SzamhaloContext();
            return context.Wnxao6s.ToList();
        }

        // GET api/<TarotController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            SzamhaloContext context = new SzamhaloContext();
            var keresettjoslat = (from x in context.Wnxao6s
                                  where x.SkTarot == id
                                  select x.Tarotszoveg).FirstOrDefault();
            return keresettjoslat;
        }

        [HttpGet]
        [Route("joslatok/count")]
        public int R5()
        {
            SzamhaloContext context = new SzamhaloContext();
            int joslatokszama = context.Wnxao6s.Count();

            return joslatokszama;

        }

        // POST api/<TarotController>
        [HttpPost]
        public void Post([FromBody] Wnxao6 UjTarot)
        {
            SzamhaloContext context = new SzamhaloContext();
            context.Wnxao6s.Add(UjTarot);
            context.SaveChanges();
        }

        // PUT api/<TarotController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TarotController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SzamhaloContext context = new SzamhaloContext();
            var torlendojoslat = (from k in context.Wnxao6s
                                  where k.SkTarot == id
                                  select k).FirstOrDefault();
            context.Remove(torlendojoslat);
            context.SaveChanges();
        }
    }
}
