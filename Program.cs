using System.ComponentModel;
using EspacioCalculadora;

Calculadora Operaciones = new Calculadora();

    string opcAux, num1Aux, num2Aux; 
    int opc;
    double num1;

    Console.WriteLine("================MENU================");
    Console.WriteLine(" 1 - SUMA");
    Console.WriteLine(" 2 - RESTA");
    Console.WriteLine(" 3 - PRODUCTO");
    Console.WriteLine(" 4 - DIVISION");
    Console.WriteLine(" 5 - LIMPIAR");
    Console.WriteLine("===================================");
    Console.WriteLine("Ingrese una Opcion : ");
    opcAux = Console.ReadLine();
    opc = int.Parse(opcAux);
    
    Console.WriteLine("Ingrese un numero: ");
    num1Aux = Console.ReadLine();

    num1 = double.Parse(num1Aux);


