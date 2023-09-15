﻿using System;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
      Console.WriteLine("select an option");
            Console.WriteLine("1. Add Number");
            Console.WriteLine("2. Random Number");
            Console.WriteLine("3. perimeter");
            Console.WriteLine("4. Radio Cilindro");
            Console.WriteLine("6. Add Temperature ");
          
            string userResponse = Console.ReadLine();

            switch (userResponse)
            {
                case "1":
                    int result = AddNumber();
        Console.WriteLine($"the result is {result}");
                    break;
                case "2":
                    Random aleatorio = new Random();
        float resAleatorio = aleatorio.Next(0, 200);
        RandomNumber(resAleatorio);
                    break;
                case "3":
                    int resultado = AddPerimetro();
        Console.WriteLine($"the resultado is {resultado}");
                    break;
                case "4":
                    double volumen = RadioCilindro();
        Console.WriteLine("El volumen es " + volumen);
                    break;
                case "6":
     double farenheir = AddTemperature();
        Console.WriteLine(" La Temperatura es  " + farenheir);
                    break;
              
            }

}
public static int AddNumber()
{

    Console.WriteLine("ingrese un numero");
    int n1 = int.Parse(Console.ReadLine());
    n1++;
    return n1;
}
public static void RandomNumber(float resAleatorio)
{

    //ejercicio 2

    Console.WriteLine("Su numero aleatorio es" + resAleatorio);
    float porcentaje = ((resAleatorio * 30) / 100);
    float numaumentado = ((resAleatorio + porcentaje));
    Console.WriteLine("Su numero aumentado en un 30% es:" + numaumentado);

}
public static int AddPerimetro()
{

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
    return perimetro;
}
public static double RadioCilindro()

{

    // ejercicio 4 
    int radio, altura;
    double volumen;

    Console.WriteLine("Ingrese el radio del cilindro ");
    radio = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la altura del cilindro");
    altura = int.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine("Ingrese un valor para radio mayor a 0");
        radio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un valor para altura mayor a 0");
        altura = int.Parse(Console.ReadLine());
    } while (radio < 0 || altura < 0);


    double areaB = Math.PI * (Math.Pow(radio, 2));

    volumen = Math.Round(areaB * altura, 2);
    Console.WriteLine("El Volumen del area es " + volumen);
    return volumen;

}
public static double AddTemperature()
{

    // ejercicio 6
    Console.WriteLine("ingrese temperatura en celsius");
    string temperatura = Console.ReadLine();
    int celsius = Int32.Parse(temperatura);

    double farenheir = (celsius * 1.8) + 32;
    Console.WriteLine("temperatura farenheit" + farenheir);
    return farenheir;
}
      

    }
}


        /*
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

                public static double AddTemperature()
        {

            // ejercicio 6
            Console.WriteLine("ingrese temperatura en celsius");
            string temperatura = Console.ReadLine();
            int celsius = Int32.Parse(temperatura);

            double farenheir = (celsius * 1.8) + 32;
            Console.WriteLine("temperatura farenheit" + farenheir);
        }

        
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
Private static void doble totalporcentajes ()
    {
    // ejercicio 9

    Console.WriteLine("ingrese cantidad de mujeres");
    string cantidadmujeres = Console.ReadLine();
    int totalmujeres = Int32.Parse(cantidadmujeres);
    Console.WriteLine("ingrese cantidad  de hombres");
    string cantidadhombres = Console.ReadLine();
    int totalhombres = Int32.Parse(cantidadhombres);

    double totalgrupo = totalmujeres + totalhombres;

    double porcentajemujeres = (totalmujeres / totalgrupo) * 100;
    double porcentajehombres = (totalhombres / totalgrupo) * 100;


    Console.WriteLine("porcentaje grupo de mujeres" + porcentajemujeres);
    Console.WriteLine("porcentaje grupo de hombres" + porcentajehombres);
}
*//
        }
    }

}

    