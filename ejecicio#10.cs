using System;
class Persona
{
  static void Npersona(string nombre, int edad) 
{
  Console.WriteLine(nombre + " su edad es " + edad);
  
  if (edad>=18)
  
  Console.Write("Por lo tanto usted es mayor de edad.");
}

static void Main(string[] args)
{
  Npersona("Victor", 18);
}
  
}