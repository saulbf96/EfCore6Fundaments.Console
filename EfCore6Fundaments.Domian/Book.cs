using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore6Fundaments.Domian
{
    public  class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public Decimal BasePrice { get; set; }

        //propiedad de navegacion  y la relacion de muchos libros a un author 
        public  Author Author { get; set; }
        public int AuthorId { get; set; }
          

        //constructor 
        public override string ToString()
        {
            return $"{this.BookId} {this.Title}{this.PublishDate} {this.BasePrice.ToString("C")}";
        }


    }
}
