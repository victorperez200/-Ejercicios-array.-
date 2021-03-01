using System;

namespace Tabla
{
    //permita ingresar valores enteros por teclado y nos muestre la tabla de multiplicar de dicho valor.
        class TMultiplicacion
    {
        public void Valor()
        {
            int valor;
            string linea;
            do
            {
                Console.Write("Ingrese un valor [-1 para finalizar]:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                
                if (valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }

        public void Calcular(int v)
        {
            for(int i=v;i<=v*10;i=i+v) 
            {
                Console.Write(i+"|");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TMultiplicacion tm = new TMultiplicacion();
            tm.Valor();
        }
    }
}