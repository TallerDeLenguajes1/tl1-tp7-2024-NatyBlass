using System.Dynamic;

namespace EspacioCalculadora //no es necesario usar un namespace
{

    public class Calculadora
    {
        private double dato = 0;
        public float resultado{get=> dato;}

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
            dato = dato / num1;
        }

        public void Limpiar()
        {
            dato = 0;
        }


    }




}