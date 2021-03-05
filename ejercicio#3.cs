using System;
 
public class orden_contrario
{                              
           
    public static void Main()
    
           /*Un programa que almacene en un array el número de días que tiene cada mes (1=enero, 12=diciembre) 
           y muestre en pantalla el número de días que tiene ese mes.*/
    {
 
        int[] mes = new int[13];
        int dia;
        for (int i=1; i<=12; i++)   
        
        {
           
           Console.WriteLine("Introducir los dias del mes {0}:", i);
           mes[i] = Convert.ToInt32(Console.ReadLine());
        }
           
          Console.WriteLine("Ingrese el mes que desea saber cuantos dias tiene: ");
          dia = Convert.ToInt32(Console.ReadLine());
          
        {
            Console.Write(" Este mes tiene: {0} dias",  mes[dia]);     
        }

            Console.ReadKey();
    }
}  