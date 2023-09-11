// See https://aka.ms/new-console-template for more information
using Generics.Entidades;
using Generics.Servicios;

//Console.WriteLine("Hello, World!");

//RepositorioPersona Repositorio = new RepositorioPersona();

//var Persona1 = new Persona() { Id = 2, nombre = "Carlos", Edad = 34 };


//Repositorio.GuardarPersona(Persona1);
//var persona2 = Repositorio.ObtenerPersona(2);

//Console.WriteLine($"{persona2.nombre} {persona2.Edad}");	


var repositorioGenerico =new RepositorioGenerico<Persona>();

repositorioGenerico.Entidad = new Persona() {nombre = "Sadra Lopes", Edad = 22, UserCreador="ddfs" };
repositorioGenerico.GuardarObjeto();
//Persona persona = repositorioGenerico.Entidad;


var RepositorioDoc= new RepositorioGenerico<Documento>();

RepositorioDoc.GuardarObjeto();


//Console.WriteLine(persona.nombre);



//var Person4 = repositorioGenerico.ObtenerObjeto(20);


//Console.WriteLine(Person4.nombre);


Console.ReadKey();