
using EfCore6Fundaments.Data;
using EfCore6Fundaments.Domain;
using EfCore6Fundaments.Domian;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hola Bienvenido a EfCore 6 Fundaments ");

//Aqui si existe la DB no lo crea pero si no existe si lo crea 

//using (PubContext pubContext = new PubContext())
//{
//    pubContext.Database.EnsureCreated();
//}

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
//EagerLoadingBooksWithAuthor()
//projections();
//ExplicitLoadCollection();
//LazyLoadBooksFromAuthor();
//FilterUsingDataRelated();
//ModifyingRelatedDataWhenTracked();
//CascadeDeleteInActionWhenTraked();
//ConnectExistingArtistAndCover();
//CreateNewCoverWithExistingArtist();
//CreateNewCoverAndArtistTogether();
//RetrieveAnArtistWithTheirCovers();
//UnAssignAnArtistFromAACover();
// ReassignACover();

//AddArtistWithPortada();
//SearchArtistCover();
//GetAllBooksWithTheirCovers();
//SimpleRawSql();

//-------------------------Metodos -------------------------------

//Creando metodos 


//----------------------query with raw sql 


//void SimpleRawSql()
//{
//    PubContext _context = new PubContext();
//    var authors = _context.Authors.FromSqlRaw("SELECT FirstName FROM  Authors").ToList();
//}

// obtener todos los librsos  sus portadas one to one 

//void GetAllBooksWithTheirCovers()
//{
   
//    var booksAndCovers = _context.Books.Include(b => b.Cover).ToList();
//    booksAndCovers.ForEach(book =>
//    Console.WriteLine(book.Title + (book.Cover == null ? ": No cover yet" : ":" + book.Cover.DesignIdeas)));
//}
////Agregamos artista con portada 

//void SearchArtistCover()
//{

   
//    var artistWithCovers = _context.Artists
//        .Include(a => a.Covers)
//        // .ThenInclude(ac => ac.Cover)
//        .FirstOrDefault(a => a.ArtistId == 5);

//    if (artistWithCovers != null)
//    {
//        Console.WriteLine($"Artista: {artistWithCovers.ArtistId},{artistWithCovers.FirstName},{artistWithCovers.LastName}");

//        foreach (var artist in artistWithCovers.Covers)
//        {
//            Console.WriteLine($"-Portada: {artist.CoverId},{artist.DesignIdeas},{artist.DigitalOnly}");
//        }

//    }
//    else
//    {
//        Console.WriteLine("No encontrado");
//    }

//}

//void AddArtistWithPortada()
//{

//    //buscamos el contesto de datos 
   

//    var addArtist = new Artist {  FirstName = "Frnacisco", LastName = "Roman Roman" };

//    var AddCover = new Cover { DesignIdeas="Diseño de perros",DigitalOnly= true };


//    addArtist.Covers.Add(AddCover);
//    _context.Artists.Add(addArtist);
//    _context.SaveChanges();

//    Console.WriteLine("Listo agregado ");

//    //Ahora mostramos ese artista con su portada 
    

//}

////Reasignacion de cover 

//void ReassignACover()
//{
//    PubContext _context = new PubContext();
//    var coverWithartist4 = _context.Covers
//        .Include( c => c.Artists.Where(a=> a.ArtistId==4))
//        .FirstOrDefault(c => c.CoverId==5);
//    coverWithartist4.Artists.RemoveAt(0);
//    var artist3 = _context.Artists.Find(3);
//    coverWithartist4.Artists.Add(artist3);
//    _context.ChangeTracker.DetectChanges();

//}

////Un Asignar un artista a partir de una portada

//void UnAssignAnArtistFromAACover()
//{
//    PubContext _context = new PubContext();
//    var coverWithartist = _context.Covers
//        .Include(c => c.Artists
//        .Where(a => a.ArtistId == 1))
//        .FirstOrDefault( c => c.CoverId == 1);

//    coverWithartist.Artists.RemoveAt(0);
//    _context.ChangeTracker.DetectChanges();

//    var debugview = _context.ChangeTracker.DebugView.ShortView;
//    _context.SaveChanges();
//}

////recuperar todos los artistas con portadas 

//void RetrieveAllArtistWithTheirCovers()
//{
//    PubContext _context = new PubContext();
//    var artistWithCovers = _context.Artists.Include( a => a.Covers ).ToList();
//}

////recuperar un artista con su portada

//void RetrieveAnArtistWithTheirCovers()
//{
//    PubContext _context = new PubContext();
//    var artistWithCover = _context.Artists.Include(a => a.Covers)
//        .FirstOrDefault(a => a.ArtistId == 1);
//}

////crear nuevo cover y artista juntos 

//void CreateNewCoverAndArtistTogether()
    
//{
//    PubContext _context = new PubContext();
//    var newArts = new Artist { FirstName = "Kir", LastName = "Takiro" };

//    var newCover = new Cover { DesignIdeas = "We like Birds!" };

//    //addd 

//    newArts.Covers.Add(newCover);
//    _context.Artists.Add(newArts);
//    _context.SaveChanges();

//    Console.WriteLine("Listo Agregado");

//}
////crear new cover con artist existentes

//void CreateNewCoverWithExistingArtist()
//{
//    PubContext _context = new PubContext();
//    var artistA = _context.Artists.Find(1);
//    var cover = new Cover { DesignIdeas = "Author has provided a photo" };
//    cover.Artists.Add(artistA);
//    _context.Covers.Add(cover);
//    _context.SaveChanges();
//}

////conectando existencias artistas con cover 

//void ConnectExistingArtistAndCover()
//{
//    PubContext _context = new PubContext();
//    //Buscamos el artista
//    var artistaA = _context.Artists.Find(1);
//    var coverA = _context.Covers.Find(1);

//    //add
//    coverA.Artists.Add(artistaA);

//    //save
//    _context.SaveChanges();

//    Console.WriteLine("Ready");
//}

////cascade delete  in action when traked

//void CascadeDeleteInActionWhenTraked()
//{
//    PubContext _context = new PubContext();
//    var author = _context.Authors.Include(a => a.Books)
//        .FirstOrDefault(a => a.AuthorId == 2);
//    _context.Authors.Remove(author);

//    var state = _context.ChangeTracker.DebugView.ShortView;
//    _context.SaveChanges();

//    Console.WriteLine($"autor{author.FirstName} eliminado");
//}

////modifying related  data 

//void ModifyingRelatedDataWhenTracked()
//{
//    PubContext pubContext = new PubContext();
//    var author = pubContext.Authors.Include(a => a.Books)
//        .FirstOrDefault(a => a.AuthorId == 5);
//    author.Books[0].BasePrice = (decimal)12.00;


//    //pubContext.ChangeTracker.DetectChanges();
//    var newContext = new PubContext();
//    newContext.Books.Update(author.Books[0]);

//    var _state = pubContext.ChangeTracker.DebugView.ShortView;
//}

////filtrar  usando  datos relacionados 

//void FilterUsingDataRelated()
//{
//    PubContext _context = new PubContext();

//    var author = _context.Authors
//        .Where( a => a.Books.Any(b =>b.PublishDate.Year >=2010))
//        .ToList();
//}
////requiere la configuración de la carga diferida en la aplicación


//void LazyLoadBooksFromAuthor()
//{
//    PubContext context = new PubContext();

//    var author = context.Authors.FirstOrDefault(a => a.LastName == "vazquez");
//    foreach (var b in author.Books)
//    {
//        Console.WriteLine(b.Title);
//    }

//}

////carga de datos relacionados para objetos que ya están en memoria

//void ExplicitLoadCollection()
//{
//    PubContext _context = new PubContext();

//    var author = _context.Authors.FirstOrDefault(
//        a => a.LastName == "Basilio");
//    _context.Entry(author).Collection(a => a.Books).Load();

//}

////proyectar datos relacionados en las consultas

//void projections ()
//{
//    PubContext _context = new PubContext();

//    var tiposDesconocidos = _context.Authors
//        .Select(a => new
//        {
//            Authorid = a.AuthorId,
//            Name = a.FirstName.First() + ""+ a.LastName,
//            Books = a.Books/*.Where(
//                b => b.PublishDate.Year < 2023)
//            .Count()*/
//        })    
//        .ToList();

//    var debugView = _context.ChangeTracker.DebugView.ShortView;
//}


////carga rápida de datos relacionados en las consultas


//void EagerLoadingBooksWithAuthor()
//{
//    PubContext _context = new PubContext();
//    // var authors = _context.Authors.Include(a => a.Books).ToList();
//    var pubDateStart = new DateTime(2020, 11, 1);
//    var authors = _context.Authors.
//        Include(a => a.Books
//        .Where(b => b.PublishDate >= pubDateStart)
//        .OrderBy(b => b.Title))
//        .ToList();
//    authors.ForEach(a =>
//    {
//        Console.WriteLine($"{a.LastName}({a.Books.Count})");
//        a.Books.ForEach(b => Console.WriteLine("" + b.Title));
//    });
//}


////Agregar nuevo libro  a existente author pero via book 

//void AddnewBookToExistingAuthorViaBook()
//{
//    PubContext context = new PubContext();
//    var book = new Book
//    {
//        Title = "Herecules",
//        PublishDate = DateTime.Now,
//        AuthorId = 5
//    };

//    //search book
//   // book.Author = context.Authors.Find(5); //known id for hugh  howey 
//    context.Books.Add(book);
//    context.SaveChanges();
//}

////add new book to exist author 

//void AddNewBookToExitingAuthorInMemory()
//{
//    PubContext _context = new PubContext();
//    var author = _context.Authors.FirstOrDefault( a => a.LastName == "");

//    //validaton 
//    if (author != null)
//    {
//        author.Books.Add(new Book
//        {
//            Title = "Los avengers",
//            PublishDate = new DateTime(1996, 11, 12)
            
//        }) ;
//        _context.Authors.Add(author);

//    }
//    _context.SaveChanges();
//}

////InsertNewAuthorWithNewBook
//void InsertNewAuthorWithNewBook()
//{
//    PubContext pubContext = new PubContext();
//    var author = new Author { FirstName = "Isidoro", LastName = "Rugal" };
//    author.Books.Add(new Book
//    {
//        Title = "Sql for begin",
//        PublishDate = new DateTime(2020, 2, 1),
//    });
//    pubContext.Authors.Add(author);
//    pubContext.SaveChanges();

//}

////Insertar autores con List

//void InsertarAutorConList()
//{
//    using PubContext _context = new PubContext();
//    var autor = new Author[]
//    {
//         new Author {FirstName = "Adriana",LastName = "Catalan"},
//         new Author {FirstName = "Felipe ",LastName="Calderon"}

          
//    };
//    _context.AddRange(autor);
//    _context.SaveChanges();
//    Console.WriteLine("Listo");
    
    
//}

////Insertar autores con Range 

//void InsertarAutoresRange()
//{
//    PubContext _context = new PubContext();

//    Console.WriteLine("Se esta Iniciando la Agregacion primero agrega tres nombre y despues los tres apellidos ");

//    string autor1, autor2, autor3;
//    string apellido1, apellido2,apellido3;
//    Console.WriteLine("Agregar nombres");
//    autor1 = Console.ReadLine();
//    autor2 = Console.ReadLine();
//    autor3 = Console.ReadLine();
//    Console.WriteLine("Escribir apellidos ");
//    apellido1 = Console.ReadLine();
//    apellido2 = Console.ReadLine();
//    apellido3 = Console.ReadLine();
//    _context.Authors.AddRange(
//        new Author { FirstName = autor1, LastName = apellido1 },
//        new Author { FirstName = autor2, LastName = apellido2 },
//        new Author { FirstName = autor3, LastName = apellido3 }

//        ) ;

//    _context.SaveChanges();
//    Console.WriteLine("Listo se agregaron con exito");
//}

////Eliminar Un author
//void EliminarAutor()
//{
//    PubContext _DbContext = new PubContext();

//    var eliminarAutor = _DbContext.Authors.Find(1);
//    if(_DbContext != null)
//    {
//        _DbContext.Authors.Remove(eliminarAutor);
//        _DbContext.SaveChanges();
//    }
//}


////Cordenada Recuperar y actualizar 

//void  RecuperarActualizar()
//{
//    //buscamos el author a editar o actualizar 
//    PubContext _context = new PubContext();
//    var autor = BuscarEseAutor(3);
//    if (autor?.FirstName=="Luis")
//    {
//        autor.FirstName = "Oscar";
//        GuardarEseAutor(autor);
//    }
    


    
//}

//Author BuscarEseAutor(int autorId)
//{
//    using var DbContext = new PubContext();
//    return DbContext.Authors.Find(autorId);

//}
//void GuardarEseAutor (Author autor)
//{
//    using var otroDbContext = new PubContext();
//    otroDbContext.Authors.Update(autor);
//    otroDbContext.SaveChanges();
//}


////Editando Autores

//void EditarAuthores()
//{
//    PubContext _context = new PubContext();
//    var autor = _context.Authors.FirstOrDefault(a => a.FirstName == "Leonardo" && a.LastName == "Romero");

//    if (autor != null)
//    {
//        autor.FirstName = "Alma";
//        autor.LastName = "vazquez";
//        _context.SaveChanges();
//    }

//    var mostrarAuthor = _context.Authors.ToList();
//    foreach (var item in mostrarAuthor)
//    {
//        Console.WriteLine($"Nombre: {item.FirstName}Apellido: {item.LastName}");

//    }
     
//}

////ordenar autores

//void SortAuthors()
//{
//    PubContext _context = new PubContext();
//    var autorPorApellido = _context.Authors
//        .OrderBy(a => a.LastName)
//        //.OrderBy(a => a.FirstName).ToList();
//        //.ThenBy(a => a.FirstName).ToList();
//        //.OrderByDescending(a => a.FirstName).ToList();
//        .ThenBy(a => a.FirstName).ToList();

//    autorPorApellido.ForEach(a=> Console.WriteLine($"{a.LastName},{a.FirstName}"));
//}


////saltar y tomar para paginación 
// void GetSkip(){
//    var groupSize = 1;
//    for (int i = 0; i<3; i++)
//    {
//        PubContext _context = new PubContext();
//        var autor = _context.Authors.Skip(groupSize * i).Take(groupSize).ToList();
//        Console.WriteLine($"Group{i}:");
//        foreach (var item in autor)
//        {
//            Console.WriteLine($"{item.FirstName},{item.LastName}");
//        }
//    }
//}

////Buscar por id
//void BuscarID(){
//    PubContext pubContext = new PubContext();
//    var autorId = pubContext.Authors.Find(2);
//}
////Filtrado filtrado seguro de queris por defecto
//void QueryFilters()
//{
//    //Buscar por algo que contenga una palabra 
//    using PubContext _context = new PubContext();

//    //var autores = _context.Authors.Where(s => s.FirstName == "Leonardo").ToList();
//    //Console.WriteLine(autores);   

//    var autores = _context.Authors.
//        Where(a => EF.Functions.Like(a.LastName, "L")).ToList();

    


//}




////Agregar autores con libros 


//async Task    AddAutoresConLibros(string nombreAutor,string apellidoAutor,string titulo,Decimal precio , DateTime publicacion )
//{

//    var autor = new Author
//    {
//        FirstName = nombreAutor,LastName = apellidoAutor,
//    };
//    autor.Books.Add(new Book
//    {
//        Title = titulo,BasePrice = precio,PublishDate = publicacion,
//    });
//    //Guardamos 
//    using var context = new PubContext();
//    await context.Authors.AddAsync(autor);
//    await context.SaveChangesAsync();
        

//}

////Agregar autores

//void AddAutores(string nombre , string apellido)
//{
//    //entrada 
//    var autor = new Author { FirstName = nombre,LastName=apellido };
//    //proceso 
//    using var context = new PubContext();
//    context.Authors.Add(autor);
//    //salida
//    context.SaveChanges();
//}
    



////Mostrar todos lo autores
//void GetAutores()
//{
//    //entrada 
//    using var context = new PubContext();
//    //proceso 
//    //Busco los authores 
//    var autores = context.Authors.ToList();
//    //salida 
//    //Muestro los autores
//    foreach (var autor in autores)
//    {
//        Console.WriteLine($"{autor.FirstName}{autor.LastName} ");
//        //foreach(var book in autor.Books)
//        //{
//        //    Console.WriteLine ($"*{book.Title}{book.BasePrice}{book.PublishDate}");
//        //}
//    }
//}

