using EspacioCalculadora;

Calculadora Operaciones = new Calculadora();
float a;

Operaciones.num1 = 6;
Operaciones.num2 = 3;
Operaciones.Multiplicar();
a = Operaciones.result;
Console.WriteLine("Resultado de Multiplicar = " +a);


Operaciones.Dividir();
a = Operaciones.result;
Console.WriteLine("Resultado de Dividir = " +a);