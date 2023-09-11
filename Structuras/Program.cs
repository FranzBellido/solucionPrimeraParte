// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

//var a = new StructPointer();

//var b = a;

//a.X = 100;

//Console.WriteLine(b.X);




//public struct StructPointer
//{


//    public StructPointer(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public int X { get; set; } = 1;
//    public int Y { get; set; }
//}

//public record  Pointint(int x, int y)
//{

//    public int X { get; set; } = 1;
//    public int Y { get; set; }
//} 


var persona = new Persona("javier", 22);

Console.WriteLine(persona.nombre);




var person2 = Operaciones.AumentaEdad(persona);
Console.WriteLine(persona.edad);

Console.WriteLine(person2.edad);


public static class Operaciones
{

    public static Persona AumentaEdad(Persona persona)
    {

        return persona with { edad = persona.edad + 1 };
    }

}



public record Persona(string nombre, int edad) 
{

    public int MyProperty { get; set; }
    public void metodo1() { 
    
        }

}

