
using EfCore6Fundaments.Data;
using EfCore6Fundaments.Domian;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hola Bienvenido a EfCore 6 Fundaments ");

//Aqui si existe la DB no lo crea pero si no existe si lo crea 

using (PubContext pubContext = new PubContext())
{
    pubContext.Database.EnsureCreated();
}

//LLamando metodos


/*Console.WriteLine("Escribe el nombre del author ");
string primerNombre = Console.ReadLine();
Console.WriteLine("Escribe el apellido");
string apellidoAutor = Console.ReadLine();
AddAutores(primerNombre, apellidoAutor);*/
//GetAutores();
//GetSkip();


//Agregamos autores con libros 
/*
Console.WriteLine("Agregando autor con libros ");
Console.WriteLine("escribe nombre del autor ");
string nombre = Console.ReadLine();
Console.WriteLine("Escribe  el apellido");
string apellidoAutor = Console.ReadLine();
Console.WriteLine("Escribe el titulo");
string titulos = Console.ReadLine();
Console.WriteLine("escribe el precio");
Decimal precios = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Escribe la publicacion ");
DateTime publi =  Convert.ToDateTime(Console.ReadLine());
await AddAutoresConLibros(nombre,apellidoAutor,titulos,precios,publi);

Console.WriteLine("Deseas ver os autores con libros ");

string rest = Console.ReadLine();
if ( rest == "si")
{
    using var context = new PubContext();
    var autor = await context.Authors.Include(a => a.Books).ToArrayAsync();
    foreach(var autorLibro in autor)
    {
        Console.WriteLine($"{autorLibro.FirstName} {autorLibro.LastName}");
        foreach(var libos in autorLibro.Books)
        {
            Console.WriteLine($"{libos.Title}  {libos.BasePrice}{libos.PublishDate}");
        }
    }
}
else
{
    Console.WriteLine("Saliendo");
}

 */
//QueryFilters();
//SortAuthors();
//EditarAuthores();
//InsertarAutoresRange();
//InsertarAutorConList();
//InsertNewAuthorWithNewBook();
//AddNewBookToExitingAuthorInMemory()





//-------------------------Metodos -------------------------------

//Creando metodos 


//Agregar nuevo libro  a existente author pero via book 

void AddnewBookToExistingAuthorViaBook()
{
    PubContext context = new PubContext();
    var book = new Book
    {
        Title = "Herecules",
        PublishDate = DateTime.Now,
        AuthorId = 5
    };

    //search book
   // book.Author = context.Authors.Find(5); //known id for hugh  howey 
    context.Books.Add(book);
    context.SaveChanges();
}

//add new book to exist author 

void AddNewBookToExitingAuthorInMemory()
{
    PubContext _context = new PubContext();
    var author = _context.Authors.FirstOrDefault( a => a.LastName == "");

    //validaton 
    if (author != null)
    {
        author.Books.Add(new Book
        {
            Title = "Los avengers",
            PublishDate = new DateTime(1996, 11, 12)
            
        }) ;
        _context.Authors.Add(author);

    }
    _context.SaveChanges();
}

//InsertNewAuthorWithNewBook
void InsertNewAuthorWithNewBook()
{
    PubContext pubContext = new PubContext();
    var author = new Author { FirstName = "Isidoro", LastName = "Rugal" };
    author.Books.Add(new Book
    {
        Title = "Sql for begin",
        PublishDate = new DateTime(2020, 2, 1),
    });
    pubContext.Authors.Add(author);
    pubContext.SaveChanges();

}

//Insertar autores con List

void InsertarAutorConList()
{
    using PubContext _context = new PubContext();
    var autor = new Author[]
    {
         new Author {FirstName = "Adriana",LastName = "Catalan"},
         new Author {FirstName = "Felipe ",LastName="Calderon"}

          
    };
    _context.AddRange(autor);
    _context.SaveChanges();
    Console.WriteLine("Listo");
    
    
}

//Insertar autores con Range 

void InsertarAutoresRange()
{
    PubContext _context = new PubContext();

    Console.WriteLine("Se esta Iniciando la Agregacion primero agrega tres nombre y despues los tres apellidos ");

    string autor1, autor2, autor3;
    string apellido1, apellido2,apellido3;
    Console.WriteLine("Agregar nombres");
    autor1 = Console.ReadLine();
    autor2 = Console.ReadLine();
    autor3 = Console.ReadLine();
    Console.WriteLine("Escribir apellidos ");
    apellido1 = Console.ReadLine();
    apellido2 = Console.ReadLine();
    apellido3 = Console.ReadLine();
    _context.Authors.AddRange(
        new Author { FirstName = autor1, LastName = apellido1 },
        new Author { FirstName = autor2, LastName = apellido2 },
        new Author { FirstName = autor3, LastName = apellido3 }

        ) ;

    _context.SaveChanges();
    Console.WriteLine("Listo se agregaron con exito");
}

//Eliminar Un author
void EliminarAutor()
{
    PubContext _DbContext = new PubContext();

    var eliminarAutor = _DbContext.Authors.Find(1);
    if(_DbContext != null)
    {
        _DbContext.Authors.Remove(eliminarAutor);
        _DbContext.SaveChanges();
    }
}


//Cordenada Recuperar y actualizar 

void  RecuperarActualizar()
{
    //buscamos el author a editar o actualizar 
    PubContext _context = new PubContext();
    var autor = BuscarEseAutor(3);
    if (autor?.FirstName=="Luis")
    {
        autor.FirstName = "Oscar";
        GuardarEseAutor(autor);
    }
    


    
}

Author BuscarEseAutor(int autorId)
{
    using var DbContext = new PubContext();
    return DbContext.Authors.Find(autorId);

}
void GuardarEseAutor (Author autor)
{
    using var otroDbContext = new PubContext();
    otroDbContext.Authors.Update(autor);
    otroDbContext.SaveChanges();
}


//Editando Autores

void EditarAuthores()
{
    PubContext _context = new PubContext();
    var autor = _context.Authors.FirstOrDefault(a => a.FirstName == "Leonardo" && a.LastName == "Romero");

    if (autor != null)
    {
        autor.FirstName = "Alma";
        autor.LastName = "vazquez";
        _context.SaveChanges();
    }

    var mostrarAuthor = _context.Authors.ToList();
    foreach (var item in mostrarAuthor)
    {
        Console.WriteLine($"Nombre: {item.FirstName}Apellido: {item.LastName}");

    }
     
}

//ordenar autores

void SortAuthors()
{
    PubContext _context = new PubContext();
    var autorPorApellido = _context.Authors
        .OrderBy(a => a.LastName)
        //.OrderBy(a => a.FirstName).ToList();
        //.ThenBy(a => a.FirstName).ToList();
        //.OrderByDescending(a => a.FirstName).ToList();
        .ThenBy(a => a.FirstName).ToList();

    autorPorApellido.ForEach(a=> Console.WriteLine($"{a.LastName},{a.FirstName}"));
}


//saltar y tomar para paginación 
 void GetSkip(){
    var groupSize = 1;
    for (int i = 0; i<3; i++)
    {
        PubContext _context = new PubContext();
        var autor = _context.Authors.Skip(groupSize * i).Take(groupSize).ToList();
        Console.WriteLine($"Group{i}:");
        foreach (var item in autor)
        {
            Console.WriteLine($"{item.FirstName},{item.LastName}");
        }
    }
}

//Buscar por id
void BuscarID(){
    PubContext pubContext = new PubContext();
    var autorId = pubContext.Authors.Find(2);
}
//Filtrado filtrado seguro de queris por defecto
void QueryFilters()
{
    //Buscar por algo que contenga una palabra 
    using PubContext _context = new PubContext();

    //var autores = _context.Authors.Where(s => s.FirstName == "Leonardo").ToList();
    //Console.WriteLine(autores);   

    var autores = _context.Authors.
        Where(a => EF.Functions.Like(a.LastName, "L")).ToList();

    


}




//Agregar autores con libros 


async Task    AddAutoresConLibros(string nombreAutor,string apellidoAutor,string titulo,Decimal precio , DateTime publicacion )
{

    var autor = new Author
    {
        FirstName = nombreAutor,LastName = apellidoAutor,
    };
    autor.Books.Add(new Book
    {
        Title = titulo,BasePrice = precio,PublishDate = publicacion,
    });
    //Guardamos 
    using var context = new PubContext();
    await context.Authors.AddAsync(autor);
    await context.SaveChangesAsync();
        

}

//Agregar autores

void AddAutores(string nombre , string apellido)
{
    //entrada 
    var autor = new Author { FirstName = nombre,LastName=apellido };
    //proceso 
    using var context = new PubContext();
    context.Authors.Add(autor);
    //salida
    context.SaveChanges();
}
    



//Mostrar todos lo autores
void GetAutores()
{
    //entrada 
    using var context = new PubContext();
    //proceso 
    //Busco los authores 
    var autores = context.Authors.ToList();
    //salida 
    //Muestro los autores
    foreach (var autor in autores)
    {
        Console.WriteLine($"{autor.FirstName}{autor.LastName} ");
        //foreach(var book in autor.Books)
        //{
        //    Console.WriteLine ($"*{book.Title}{book.BasePrice}{book.PublishDate}");
        //}
    }
}


