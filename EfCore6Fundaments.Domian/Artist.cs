using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore6Fundaments.Domain
{
    public  class Artist
    {

        //constructor 
        public Artist() 
        {
            Covers = new List<Cover>();
        }
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //asignacion de many to many cover 
        public List<Cover> Covers { get; set; } 

        //constructor override
        public override string ToString()
        {
            return $"{this.ArtistId},{this.FirstName},{this.LastName}";
        }
    }
}
