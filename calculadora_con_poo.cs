using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_poo
{
    class Calculadora
    {
        //atributos
        public double valor1;
        public double valor2;
        public int opcion;
        public bool salir = false;
        public double sumar()
        {
            return this.valor1 + this.valor2;
        }
        public double restar()
        {
            return this.valor1 - this.valor2;
        }
        public double multiplicar()
        {
            return this.valor1 * this.valor2;
        }
        public double dividir()
        {
            return this.valor1 / this.valor2;
        }
        public void obtener_datos()
        {
            Console.WriteLine("Ingresa el numero de tu opcion");
            this.opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor 1");
            this.valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor 2");
            this.valor2 = double.Parse(Console.ReadLine());
        }

        public void menu_opciones()
        {
            Console.WriteLine("Calculadora con POO");
            Console.WriteLine("Selecciona una opcion!");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
        }
        public void ejecutar()
        {
            switch (this.opcion)
            {
                case 1:
                    double suma = this.sumar();
                    Console.WriteLine($"La suma es {suma}");
                    break;
                case 2:
                    double resta = this.restar();
                    Console.WriteLine($"La resta es {resta}");
                    break;
                case 3:
                    double multiplicacion = this.multiplicar();
                    Console.WriteLine($"La multi es {multiplicacion}");
                    break;
                case 4:
                    double division = this.dividir();
                    Console.WriteLine($"La division es {division}");
                    break;
            }
        }
        public void salir_programa()
        {
            Console.WriteLine("Deseas salir del programa?");
            Console.WriteLine("1 - SI, 2 - No");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 1)
            {
                this.salir = true;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            while (!calculadora.salir)
            {
                calculadora.menu_opciones();
                calculadora.obtener_datos();
                calculadora.ejecutar();
                calculadora.salir_programa();
            }
           
        }
    }
}
