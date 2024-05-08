using System.Dynamic;

namespace EspacioCalculadora //no es necesario usar un namespace
{

    public class Calculadora
    {
        private float x;
        private float y;
        private float resultado;

        public float num1{get => x; set => x = value;}
        public float num2{get => y; set => y = value;}
    
        public float result{get=> resultado;}

        //metodos: funciones dentro una clase
        public void Suma()
        {
            resultado = num1 + num2;
        }

        public void Resta()
        {
            resultado = num1 - num2;
        }

        public void Multiplicar()
        {
            resultado = num1 * num2;
        }

        public void Dividir()
        {
            resultado = num1 / num2;
        }




    }




}