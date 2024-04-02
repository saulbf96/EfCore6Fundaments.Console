using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore6Fundaments.Domian
{
    public  class Author
    {
        //constructor 
        //public Author() 
        //{
        //    Books = new List<Book>();
        //}
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relacion de Uno  Muchos un autor puede escribir muchos libros 
        public List<Book> Books { get; set;}

        

        //Constructo
        public override string ToString()
        {
            return $" {this.AuthorId} {this.FirstName}{this.LastName}";
        }
    }
}
