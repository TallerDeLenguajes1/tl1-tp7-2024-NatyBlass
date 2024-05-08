using System.ComponentModel;
using EspacioCalculadora;

Calculadora Operaciones = new Calculadora();

    string opcAux, num1Aux, contAux; 
    int opc;
    double num1;
    int continuar = 1;

    while (continuar != 0)
    {
         Console.WriteLine("================MENU================");
        Console.WriteLine(" 1 - SUMA");
        Console.WriteLine(" 2 - RESTA");
        Console.WriteLine(" 3 - PRODUCTO");
        Console.WriteLine(" 4 - DIVISION");
        Console.WriteLine(" 5 - LIMPIAR");
        Console.WriteLine(" 0 - SALIR");
        Console.WriteLine("===================================");
        Console.WriteLine("Ingrese una Opcion : ");
        opcAux = Console.ReadLine();
        opc = int.Parse(opcAux);
        
        Console.WriteLine("Ingrese un numero: ");
        num1Aux = Console.ReadLine();
        num1 = double.Parse(num1Aux);
        switch (opc)
        {
            case 1: 
                Operaciones.Suma(num1);
                break;
            
            case 2: 
                Operaciones.Resta(num1);
                break;

            case 3: 
                Operaciones.Multiplicar(num1);
                break;

            case 4: 
                Operaciones.Dividir(num1);
                break;

            case 5: 
                Operaciones.Limpiar();
                break;
            default:
                Console.WriteLine("Ingreso una opcion no valida");
                break;
        }

        Console.WriteLine("Resultado de las operaciones = " +Operaciones.resultado);

        Console.WriteLine("¿Desea Realizar otra Operacion?");
        Console.WriteLine("0  = NO || 1 = SI");
        contAux = Console.ReadLine();
        continuar = int.Parse(contAux);

    }

    Console.WriteLine("Saliendo...");




