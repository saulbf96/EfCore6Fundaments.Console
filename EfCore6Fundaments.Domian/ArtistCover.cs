using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore6Fundaments.Domain
{
    public  class ArtistCover
    {
        //siempre que se agreguen  muchos a muchos se asiga esta clase 

        public int ArtistId { get; set; }
        public int CoverId { get; set; }
    }
}
