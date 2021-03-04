using System;
 
public class orden_contrario
{                              
           //aplicacion que almacena 5 valores y luego muestra el orden contrario de dichos valores.
    public static void Main()
    {
 
        float[] num = new float[5];
        for (int i=0; i<=4; i++)   
        {

           Console.WriteLine("Introducir numero : ", i+1);
           
           num[i] = Convert.ToInt32(Console.ReadLine());
        }
          
          for ( int i=4; i>=0; i--)
        {
            Console.Write(" | {0}",  num[i]);
            
        }
      
    }
}  