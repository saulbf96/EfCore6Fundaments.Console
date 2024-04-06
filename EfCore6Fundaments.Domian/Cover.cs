using EfCore6Fundaments.Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore6Fundaments.Domain
{
    public class Cover
    {
        //constructor 
        //Aqui solo se hace con lor artistas 
        public Cover() {

            Artists = new List<Artist>();
        }
        public int CoverId { get; set; }
        public string DesignIdeas { get; set; }
        public bool DigitalOnly { get; set; }
        //Agregamos las relacion de muchos a muchos con Artista 

        public List<Artist> Artists { get; set; }


        //Agregando relacion de uno a uno 
        //considerando que el padre es book 

        public Book Book { get; set; }
        public int BookId { get; set; }
    

        //constructor override
        public override string ToString()
        {
            return $"{this.CoverId},{this.DesignIdeas},{this.DigitalOnly}";
        }


    }
}
