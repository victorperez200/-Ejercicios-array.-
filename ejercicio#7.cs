using System;
 
 class posible

{                              
           
    public static void Main(string[] args)
    {
 
        string nom = "";
        
        Console.Clear();
        Console.WriteLine("Introduzca su nombre: ");
        
        nom = Console.ReadLine();
    
    
        for (int i = 0; i < nom.Length; i++)
        
        {
           Console.WriteLine(nom[i]); 
        }      
          
    }
    
       
}  