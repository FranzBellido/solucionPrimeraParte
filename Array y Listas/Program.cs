// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//string[] arregloSTR=new string[5];


//arregloSTR[0] = "elemento0";
//arregloSTR[1] = "elem 1";
//arregloSTR[2] = "elemento0";
//arregloSTR[3] = "elem 1";
//arregloSTR[4] = "elemento0";


//for (int i = 0; i < arregloSTR.Length; i++) {

//	Console.WriteLine(arregloSTR[i]);

//}


//string[] array2 =   {" 0 ","1","2" };


List<string> listaPaices = new List<string>();

listaPaices.Add("Mexico");
listaPaices.Add("Bolivia");
listaPaices.Add("brasil");

//foreach (string item in listaPaices) { 

//	Console.WriteLine(item);
//}

List<string> Listapais2 = new List<string>();

//Listapais2.AddRange(listaPaices);

//Listapais2.Clear();
//Listapais2.First();


List<Persona> listaPersona = new();


listaPersona.Add(new Persona() {Edad=20,Nombre="Carlos" });
var persona1 = new Persona() { Edad = 33, Nombre = "Sandro" };
listaPersona.Add(persona1);


var ListaFitrada= listaPersona.Where(p=>p.Edad==20).ToList();


Persona pCarlos = listaPersona.Where(p => p.Nombre == "Carlos" && p.Edad>18).First();


Console.WriteLine(pCarlos.Nombre);

var listaMayores =listaPersona.Where(p=>p.Edad>=18);

List<string> nombre = listaPersona.Where(p => p.Nombre == "Carlos").Select(n => n.Nombre).ToList();
string SQlCon = "Select nombre from Persoma where nombre='Carlos'";


listaPersona.Where(x=>x.Nombre.ToLower()=="carlos");

public class Persona {

    public int Edad { get; set; }
    public string Nombre { get; set; }

}








