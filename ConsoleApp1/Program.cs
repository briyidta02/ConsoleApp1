using System;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
        //ejercicio 1
            
                Console.WriteLine("ingrese un numero");
            string input = Console.ReadLine();
            int a = Int32.Parse(input);
            Console.WriteLine( a + 1);

           //ejercicio 2

          Console.WriteLine("numero aleatorio");
         
            Random rnd = new Random();
            int num = rnd.Next(0,200);
            double resultado = (num * 30) / 100;

            double resultadosuma = resultado + num;
           
            Console.Write(num);
            Console.WriteLine("mas el aumento del 30 % es " + resultadosuma );
         
            // ejercicio 3

            Console.WriteLine("ingrese la base del rectangulo");
            string abajo = Console.ReadLine();
            int area = Int32.Parse(abajo);
            Console.WriteLine("ingrese la altura del rectangulo");
            string altura = Console.ReadLine();
            int variable = Int32.Parse(altura);

            int solucion = area * variable;
         
            Console.WriteLine("El area del rectangulo es" + solucion);

            int perimetro = area * 2 + variable * 2;

            Console.WriteLine("El perimetro del rectangulo es" + perimetro);

          
        
            // ejercicio 4 

           
            Console.WriteLine("ingrese el radio de un cilindro");
            string circulo= Console.ReadLine();
           Console.WriteLine("ingrese la altura de un cilindro");
            string alturaejercicio = Console.ReadLine();
            int respuesta = Int32.Parse(circulo);
            int definitiva = Int32.Parse(alturaejercicio);
            double volumen = Math.PI * (Math.Pow(respuesta,2) * definitiva);
            Console.WriteLine("el algoritmo de un cilindro es" + volumen);
            
            // ejercicio 5 


            Console.WriteLine("ingrese valor ingresado en centimetros");
            string valor = Console.ReadLine();
            int centimetros = Int32.Parse(valor);
            double metros = centimetros * 0.01;
            double yardas = centimetros * 0.0109;
            double pies = centimetros * 0.032;
            double pulgadas = centimetros * 0.393;

            Console.WriteLine("centimetros a metros" + metros);
            Console.WriteLine("centimetros a yardas"  + yardas);
            Console.WriteLine("centimetros a pies" + pies);
            Console.WriteLine("centimetros a pulgadas" + pulgadas);

             */
            // ejercicio 6
            Console.WriteLine("ingrese temperatura en celsius");
            string temperatura = Console.ReadLine();
            int celsius = Int32.Parse(temperatura);

            double farenheir = (celsius * 1.8) + 32;
            Console.WriteLine("temperatura farenheit" + farenheir);




        }

    }
    }
