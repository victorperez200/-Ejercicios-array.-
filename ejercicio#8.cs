using System;


namespace array
{
    class caltura
    {
        private float[] alturas;
        private float promedio;

        public void Cargar() 
        {
            alturas=new float[5];
            for (int v = 0; v < 5; v++)
            {
                Console.Write("Ingrese la altura de la persona:");
                string linea = Console.ReadLine();
                alturas[v] = float.Parse(linea);
            }
        }
    
        public void CalcularPromedio() 
        {
            float suma;
            suma=0;
            for(int v=0; v < 5; v++) 
            {
                suma=suma+alturas[v];
            }
            promedio=suma/5;
            Console.WriteLine("Promedio de alturas:"+promedio);
        }

        public void MayoresMenores() 
        {
            int may,men;
            may=0;
            men=0;
            for(int v = 0; v < 5; v++) 
            {
                if (alturas[v] > promedio) 
                {
	                may++;
                }
                else
                {
                    if (alturas[v] < promedio) 
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio:"+may);
            Console.WriteLine("Cantidad de personas menores al promedio:"+men);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            caltura pv2 = new caltura();
            pv2.Cargar();
            pv2.CalcularPromedio();
            pv2.MayoresMenores();
        }
    }
}
