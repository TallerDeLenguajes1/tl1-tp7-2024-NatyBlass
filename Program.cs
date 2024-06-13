using System.Runtime.CompilerServices;
using DatosEmpleados;

Empleados Empleado = new Empleados();
int c = 0;

Console.WriteLine("==========DATOS DEL EMPLEADO==========");

Console.WriteLine("Nombre: ");
Empleado.Nombre = Console.ReadLine();

Console.WriteLine("Apellido: ");
Empleado.Apellido = Console.ReadLine();

while (c != 1)
{
    Console.WriteLine("Fecha de Nacimiendo (formato: yyyy-MM-dd): ");
    string fecAux = Console.ReadLine();
    DateTime fecNac;
    if (DateTime.TryParse(fecAux, out fecNac))
        {
            Empleado.FecNac = fecNac;
            c = 1;
        }
    else
        {
            Console.WriteLine("La fecha ingresada no es valida. Por favor, intente nuevamente.");
            c = 0;
        }
}

Console.Write("Estado Civil: S - Soltero || C - Casado || H - Con Hijos");
string estadoCiv = Console.ReadLine();
Empleado.EstadoCiv = char.Parse(estadoCiv);

c = 0;

while (c != 1)
{
    Console.WriteLine("Fecha de Ingreso a la Empresa (formato: yyyy-MM-dd): ");
    string fecAux = Console.ReadLine();
    DateTime fecIng;
    if (DateTime.TryParse(fecAux, out fecIng))
        {
            Empleado.IngresoEmpresa = fecIng;
            c = 1;
        }
    else
        {
            Console.WriteLine("La fecha ingresada no es valida. Por favor, intente nuevamente.");
            c = 0;
        }
}

c = 0;

Console.WriteLine("Ingrese su Sueldo Basico: ");
string Aux = Console.ReadLine();
int sueldo = int.Parse(Aux);
Empleado.SueldoBasico = sueldo;

while (c != 1)
{
    Console.WriteLine("Ingrese su Cargo (numero): ");
    Console.WriteLine("1 - Auxiliar");
    Console.WriteLine("2 - Administrativo");
    Console.WriteLine("3 - Ingeniero");
    Console.WriteLine("4 - Especialista");
    Console.WriteLine("5 - Investigador");

    int cargoAux = int.Parse(Console.ReadLine()) - 1; //esta forma me evita crear muchas variables! 

    if (cargoAux < 5 && cargoAux >= 0)
    {
        switch (cargoAux)
        {
            case 0:
                Empleado.Cargo = Cargos.Auxiliar;
                break;
            case 1:
                Empleado.Cargo = Cargos.Administrativo;
                break;
            case 2:
                Empleado.Cargo = Cargos.Ingeniero;
                break;
            case 3:
                Empleado.Cargo = Cargos.Especialista;
                break;
            case 4:
                Empleado.Cargo = Cargos.Investigador;
                break;
        }
        c = 1;
    }
    else
    {
        Console.WriteLine("La opcion ingresada no es valida. Por favor, intente nuevamente.");
            c = 0;
    }
}

Console.WriteLine("======================================");
Console.WriteLine("LOS DATOS INGRESADOS SON: ");
Console.WriteLine("Nombre: " +Empleado.Nombre);
Console.WriteLine("Apellido: " +Empleado.Apellido);
Console.WriteLine("Fecha de Nacimiento: "+Empleado.FecNac);
Console.WriteLine("Estado Civil: "+Empleado.EstadoCiv);
Console.WriteLine("Ingreso a la Empresa: "+Empleado.IngresoEmpresa);
Console.WriteLine("Sueldo Basico:$"+Empleado.SueldoBasico);
Console.WriteLine("Cargo: " +Empleado.Cargo);





