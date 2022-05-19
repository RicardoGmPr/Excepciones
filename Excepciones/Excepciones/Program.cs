using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Ingresa el número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el número 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1/num2);
            Console.ReadKey();
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
            }
            finally
            {

            }
        }
    }
}
