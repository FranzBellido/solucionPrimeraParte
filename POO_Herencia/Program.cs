// See https://aka.ms/new-console-template for more information
using POO_Herencia.Contratos;
using POO_Herencia.Entidades;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Programacion Orientada a objetos!");


//var moto= new Moto();

//moto.Encender();

//var t1= new triangulo();

//t1.Id2=3;

//var circulo2 = new triangulo();

//if (circulo2 is IEntidad)
//{
//	Console.WriteLine(" implementa IEntidad");

//}
//else {
//	Console.WriteLine("no implementa interfas ientidad");

//}

var resultadoSuma = Calculadora.suma(3, 5);

Console.WriteLine(resultadoSuma);

var resultadoResta = Calculadora.resta(5, 3);

Console.WriteLine(resultadoResta);

public static class Calculadora {
  
   public static int suma(int x, int y) {

        return  x+y;
     
    }

    public static int resta(int x, int y)
    {
        return x-y;
    }

}





//var miAuto = new Auto("toyota", "2000");

//miAuto.Encender();

//miAuto.Encender(20);





//var miCuadrado = new Cuadrado();
//miCuadrado.ObtenerArea();
//miCuadrado.ObtenerPerimetro();

//Pieza.Construir(12);