using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BarApi.Models
{
    public class Beer
    {
        public string Name {get; set;}
        public long BrandId {get;set;}
        public long Id {get;set;}

    }
}