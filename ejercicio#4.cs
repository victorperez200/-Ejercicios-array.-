using System;

namespace num_mayor
{
    class Program
    
    //Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos.
    
    {
        static void Main(string[] args)
        {
            double[] num = new double[10];
            double mayor = -99999;
            Console.WriteLine("Introduzca sus diez números: ");
            for (int i = 0; i < 10; i++)
            {
                num[i] = double.Parse(Console.ReadLine());
                if (num[i] > mayor)
                {
                    mayor = num[i];
                }
            }
            Console.WriteLine($"De los números ingresados el mayor es: {mayor}");
        }
    }
}