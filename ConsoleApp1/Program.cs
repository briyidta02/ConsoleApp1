using System;
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
            Console.WriteLine("5. Add Conversion");
            Console.WriteLine("6. Add Temperature ");
            Console.WriteLine("7.  Volumen ");
            Console.WriteLine("8.  Numero Divisible");
            Console.WriteLine("9. totalporcentajes");
            Console.WriteLine("10. IdentifyTriangle");
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
                      case "5":
     double conversion = AddConversion();
        Console.WriteLine(" Los metros son  " +  metros);
        Console.WriteLine(" Los metros son  " +  yardas); 
        Console.WriteLine(" Los metros son  " +  pies);
        Console.WriteLine(" Los metros son  " +  plgadas);
                    break;
                case "6":
     double farenheir = AddTemperature();
        Console.WriteLine(" La Temperatura es  " + farenheir);
                    break;
                 case "7":
     double volumen = Volumen();
        Console.WriteLine(" el algoritmo de un cilindro es " + volumen);
                    break;
             case "8":
         
        Console.WriteLine(" el algoritmo de un cilindro es " + volumen);
                    break;
                   case "9":
     double totalporcentajes = totalporcentajes();
        Console.WriteLine("porcentaje grupo de mujeres" + porcentajemujeres);
       Console.WriteLine("porcentaje grupo de hombres" + porcentajehombres);
                    break;
            case "10":
            string triangleResult = identifyTriangle();
            Console.WriteLine($"The triangulo is [triangleResult]");
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

public static double AddConvcersion()
{
    // ejercicio 5 


    Console.WriteLine("ingrese valor ingresado en centimetros");
    string valor = Console.ReadLine();
    int centimetros = Int32.Parse(valor);
    double metros = centimetros * 0.01;
    double yardas = centimetros * 0.0109;
    double pies = centimetros * 0.032;
    double pulgadas = centimetros * 0.393;

    Console.WriteLine("centimetros a metros" + metros);
    Console.WriteLine("centimetros a yardas" + yardas);
    Console.WriteLine("centimetros a pies" + pies);
    Console.WriteLine("centimetros a pulgadas" + pulgadas);

}
    public static double AddTemperature()

{

    // ejercicio 6
    Console.WriteLine("ingrese temperatura en celsius");
    string temperatura = Console.ReadLine();
    int celsius = Int32.Parse(temperatura);

    double farenheir = (celsius * 1.8) + 32;
    Console.WriteLine("temperatura farenheit" + farenheir);
}

          public static double AddVolumen()
         // ejercicio 7 

{
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
    return volumen;
}
public static string NumeroDivisible()
{
    // ejercicio 8 

    Console.WriteLine("ingrese un primer numero");
    string numerouno = Console.ReadLine();
    int divisibleuno = Int32.Parse(numerouno);
    Console.WriteLine("ingrese un segundo numero");
    string numerodos = Console.ReadLine();
    int divisibledos = Int32.Parse(numerodos);


    if (divisibledos % divisibleuno == 0)
    {
        Console.WriteLine("es divisible");
    } else {
        Console.WriteLine("no es divisible");
    }
    return NumeroDivisible;
}


           public static void double totalporcentajes ()
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
// ejercicio 10

public static string IdentifyTriangle()
{ 
    string triangleResult = "";

Console.WriteLine("ingrese el valor del lado 1");
string input9 = Console.ReadLine();
float lado1 = float.Parse(input9);
Console.WriteLine("ingrese el valor del lado 2");
string input10 = Console.ReadLine();
float lado2 = float.Parse(input10);
Console.WriteLine("ingrese el valor del lado 3");
string input11 = Console.ReadLine();
float lado3 = float.Parse(input11);


if (lado1 != lado2 && lado2 != lado3)
{
    triangleResult = "Es un triangulo escaleno";
        }
if ((lado1 != lado2 && lado2 != lado3)) || (lado1 == lado3 && !lado3 !=lado2) ||(lado2 == lado3 && lado3 != lado1))
 {
    triangleResult = "Es un triangulo isoceles";
}
if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Es un triangulo Equilatero");
}
return triangleResult;
 
}

}

    