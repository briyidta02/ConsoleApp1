﻿using System;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("4 radioCilindro!");
            Console.WriteLine("6 Add Temperatura");
                    Console.WriteLine($"the resultado is {resultado}");
                    Console.WriteLine("El volumen es " + volumen);
                    break;
        //ejercicio 1
            
        }

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

            
            // ejercicio 6
            Console.WriteLine("ingrese temperatura en celsius");
            string temperatura = Console.ReadLine();
            int celsius = Int32.Parse(temperatura);

            double farenheir = (celsius * 1.8) + 32;
            Console.WriteLine("temperatura farenheit" + farenheir);

         
            // ejercicio 7 



            Console.WriteLine("ingrese el radio de un cilindro");
            string circulo = Console.ReadLine();
            Console.WriteLine("ingrese la altura de un cilindro");
            string alturaejercicio = Console.ReadLine();
            int respuesta = Int32.Parse(circulo);
            int definitiva = Int32.Parse(alturaejercicio);
            
            if (respuesta > 0 || definitiva > 0)
            {
                Console.WriteLine("es positivo");
            }
            else
            {

                Console.WriteLine("es negativo");
            }
            double volumen = Math.PI * (Math.Pow(respuesta, 2) * definitiva);
            Console.WriteLine("el algoritmo de un cilindro es" + volumen);
               
            // ejercicio 8 

            Console.WriteLine("ingrese un primer numero");
            string numerouno = Console.ReadLine();
            int divisibleuno = Int32.Parse(numerouno);
            Console.WriteLine("ingrese un primer numero");
            string numerodos = Console.ReadLine();
            int divisibledos = Int32.Parse(numerodos);


            if (divisibledos % divisibleuno == 0 )
                    {
                Console.WriteLine("es divisible");
            }else {
                Console.WriteLine("no es divisible");
            }
            */
            // ejercicio 9

            Console.WriteLine("ingrese cantidad de mujeres");
            string cantidadmujeres = Console.ReadLine();
            int totalmujeres = Int32.Parse(cantidadmujeres);
            Console.WriteLine("ingrese cantidad de hombres");
            string cantidadhombres = Console.ReadLine();
            int totalhombres = Int32.Parse(cantidadhombres);

            double totalgrupo = totalmujeres + totalhombres;

            double porcentajemujeres = (totalmujeres / totalgrupo) * 100;
            double porcentajehombres = (totalhombres / totalgrupo) * 100;


            Console.WriteLine("porcentaje grupo de mujeres" + porcentajemujeres);
            Console.WriteLine("porcentaje grupo de hombres" + porcentajehombres);


        }
    }

}

    