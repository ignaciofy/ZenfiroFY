﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Languaje
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Translation> Translations { get; set; }
    }
}
