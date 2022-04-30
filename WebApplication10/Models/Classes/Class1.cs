using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication10.Models.Entity;

namespace WebApplication10.Models.Classes
{
    public class Class1
    {
        public IEnumerable<Table_Kitab> KitabDeger { get; set; }
        public IEnumerable<Table_Hakkimizda> HakkimizdaDeger { get; set; }
    }
}