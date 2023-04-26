using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BarApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeerController: ControllerBase
    {
        private Context _context;
        public BeerController(Context context){
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Beer> Get(){
            return _context.Beers.ToList();
        }
        [HttpPost]
        public Beer Post(Beer beer){
            _context.Beers.Add(beer);
            _context.SaveChanges();
            return beer;
        }

    }
}