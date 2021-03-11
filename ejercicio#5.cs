using System;

namespace nombres
{
    /*Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez,
    y se mostrará en pantalla la lista de los nombres que se han introducido cuando se pulse Intro sin teclear nada.*/
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] nom = new string[100];
            Console.WriteLine("Introduzca los nombres: ");
            for (int i = 0; i < 100; i++)
            {
                nom[i] = Console.ReadLine();
                if (nom[i] == "") break;
            }
            Console.WriteLine("Los nombres registrados son: ");
            for(int v = 0; v < nom.Length; v++)
            {
                if (nom[v] == "") { break; }
                else { Console.WriteLine($"\t{nom[v]}"); }
            }
        }
    }
}