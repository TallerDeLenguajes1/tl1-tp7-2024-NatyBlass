namespace DatosEmpleados
{

    public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
    public class Empleados
    {
        private string nombre;
        private string apellido;
        private DateTime fecNac;
        private char estadoCiv;
        private DateTime ingresoEmpresa;
        private double sueldoBasico;
        private Cargos cargo;
    

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FecNac { get => fecNac; set => fecNac = value; }
        public char EstadoCiv { get => estadoCiv; set => estadoCiv = value; }
        public DateTime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public int CalculadoraDeAntiguedad(DateTime fechaIng)
        {
            DateTime fechaActual = DateTime.Today; // DateTime.Today me brinda la fecha actual
            int antiguedadAños = fechaActual.Year - fechaIng.Year; 
            int antiguedadMeses = fechaActual.Month - fechaIng.Month;
            //Modificaciones para solucionar errores
            if (fechaActual.Month < fechaIng.Month || (fechaActual.Month == fechaIng.Month && fechaActual.Day <= fechaIng.Day))
            {
                antiguedadAños--;
            }
            
            if (fechaActual.Day > fechaIng.Day)
            {
                antiguedadMeses++;
            }

            if (antiguedadMeses > 12)
            {
                antiguedadMeses -= 12;
                antiguedadAños++;
            }

            return antiguedadAños;
        }

        public int CalculadoraDeEdad(DateTime fecNac)
        {
            DateTime fechaActual = DateTime.Today;
            TimeSpan diferencia = fechaActual - fecNac;
            int edad = diferencia.Days / 365; // para solucionar errores en los calculos de edad

            return edad;
        }

        public int CalculadoraDeJubilacion(DateTime fecNac)
        {
            int edad = CalculadoraDeEdad(fecNac);
            int añosParaJubilarse = 65 - edad;

            return añosParaJubilarse;
        }

        public double CalculadoraDeSalario(double sueldoBasico, Cargos cargo, char estadoCiv, int antiguedad)
        {
            double salario, adicional;

            if (antiguedad <= 20 && antiguedad >= 0)
            {
                adicional = (sueldoBasico * antiguedad) / 100;
            }
            else
            {
                adicional = (sueldoBasico * 25) / 100;
            }

            if (cargo == Cargos.Especialista || cargo == Cargos.Ingeniero)
            {
                adicional = adicional + (adicional * 50) / 100;
            }

            if(estadoCiv == 'C' || estadoCiv == 'c')
            {
                adicional = adicional + 150000;
            }

            salario = sueldoBasico + adicional;

            return salario;
        }



    }
    

}