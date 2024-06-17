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


//EMPLEADOS EN ARREGLO

DatosEmpleados.Empleados [] infEmpleados = new DatosEmpleados.Empleados[3];

infEmpleados[0] = new DatosEmpleados.Empleados();
infEmpleados[0].Nombre = "Juan";
infEmpleados[0].Apellido = "Martinez";
infEmpleados[0].FecNac = new DateTime(1980, 10, 20);
infEmpleados[0].EstadoCiv = 'C';
infEmpleados[0].IngresoEmpresa = new DateTime(2010, 5, 12);
infEmpleados[0].SueldoBasico = 2500000;
infEmpleados[0].Cargo = DatosEmpleados.Cargos.Ingeniero;

infEmpleados[1] = new DatosEmpleados.Empleados();
infEmpleados[1].Nombre = "Maria";
infEmpleados[1].Apellido = "Lopez";
infEmpleados[1].FecNac = new DateTime(1990, 7, 15);
infEmpleados[1].EstadoCiv = 'S';
infEmpleados[1].IngresoEmpresa = new DateTime(2015, 3, 8);
infEmpleados[1].SueldoBasico = 1800000;
infEmpleados[1].Cargo = DatosEmpleados.Cargos.Auxiliar;

infEmpleados[2] = new DatosEmpleados.Empleados();
infEmpleados[2].Nombre = "Pedro";
infEmpleados[2].Apellido = "Garcia";
infEmpleados[2].FecNac = new DateTime(1975, 12, 2);
infEmpleados[2].EstadoCiv = 'C';
infEmpleados[2].IngresoEmpresa = new DateTime(2005, 11, 1);
infEmpleados[2].SueldoBasico = 3200000;
infEmpleados[2].Cargo = DatosEmpleados.Cargos.Especialista;


double totalSalarios = 0;

foreach (DatosEmpleados.Empleados empleado in infEmpleados)
{
    Console.WriteLine("Nombre y Apellido: " + empleado.Nombre + " " + empleado.Apellido);
    Console.WriteLine("Edad: " + empleado.CalculadoraDeEdad(empleado.FecNac) + " años");
    Console.WriteLine("Antiguedad: " + empleado.CalculadoraDeAntiguedad(empleado.IngresoEmpresa) + " años");
    Console.WriteLine("Cargo: " + empleado.Cargo);
    Console.WriteLine("Sueldo: $" + empleado.CalculadoraDeSalario(empleado.SueldoBasico, empleado.Cargo, empleado.EstadoCiv, empleado.CalculadoraDeAntiguedad(empleado.IngresoEmpresa)));
    Console.WriteLine("----------------------");

    empleado.CalculadoraDeAntiguedad(empleado.IngresoEmpresa);
    empleado.CalculadoraDeJubilacion(empleado.FecNac);

    totalSalarios += empleado.CalculadoraDeSalario(empleado.SueldoBasico, empleado.Cargo, empleado.EstadoCiv, empleado.CalculadoraDeAntiguedad(empleado.IngresoEmpresa));
}
Console.WriteLine("Monto total a pagar de salarios: $" + totalSalarios);

int edadJubilatoria = 65;
DatosEmpleados.Empleados empleadoMasProximo = null;

