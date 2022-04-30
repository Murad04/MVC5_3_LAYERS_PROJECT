using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5_3_LAYERS_PROJECT.Models.Entity;

namespace MVC5_3_LAYERS_PROJECT.Models.Classes
{
    public class Class1
    {
        public IEnumerable<Table_Kitab> KitabDeger { get; set; }
        public IEnumerable<Table_Hakkimizda> HakkimizdaDeger { get; set; }
    }
}