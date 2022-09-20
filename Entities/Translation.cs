using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Translation
    {
        public long Id { get; set; }
        public int Id_Languaje { get; set; }
        public string Key { get; set; }
        public string translation { get; set; }
    }
}
