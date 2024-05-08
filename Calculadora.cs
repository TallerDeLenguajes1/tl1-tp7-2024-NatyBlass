using System.Dynamic;

namespace EspacioCalculadora //no es necesario usar un namespace
{

    public class Calculadora
    {
        private double dato;

        //declaro un constructor
        public Calculadora(int valorInicial)
        {
            dato = valorInicial;
        }
        public Calculadora()
        {
            dato = 0;
        }

        public double resultado{get=> dato;}

        //metodos: funciones dentro una clase
        public void Suma(double num1)
        {
            dato = dato + num1;
        }

        public void Resta(double num1)
        {
           dato = dato - num1;
        }

        public void Multiplicar(double num1)
        {
            dato = dato * num1;
        }

        public void Dividir(double num1)
        {
            if (num1 != 0)
            {
                dato = dato / num1;
            }
            else
            {
                Console.WriteLine("La operacion no puede realizarse");
            }
            
        }

        public void Limpiar()
        {
            dato = 0;
        }


    }




}