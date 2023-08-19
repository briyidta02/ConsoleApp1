namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

            Console.WriteLine("ingrese base y altura del rectangulo");

            
           

            }

        }
    }
