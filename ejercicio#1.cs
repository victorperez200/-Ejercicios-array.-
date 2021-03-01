using System;
 
public class Suma_Aritmetica
{
    public static void Main()
    {
 
        int[] numeros = new int[4];
        int suma;
       
        
        for (int i=0; i<=3; i++)   
        {

           Console.Write("Introducir numero : ", i+1);
           numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
 
        suma = 0;  
        for (int i=0; i<=3; i++)
         suma += numeros[i];
            
      
        {
        for (int i=0; i<=3; i++)  
         {
        
        Console.WriteLine("Los numeros ingresados son: {0}",  numeros[i]);
        
         }
        Console.WriteLine("La media aritmetica es igual a: {0}", suma/4);
        Console.ReadKey();
        }
        
        
    }
}