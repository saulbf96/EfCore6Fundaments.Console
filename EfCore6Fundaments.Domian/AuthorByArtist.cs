﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore6Fundaments.Domain
{
    public  class AuthorByArtist
    {
        public string Artist { get; set; }
        public string? Author { get; set; }
    }
}
