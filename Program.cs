﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVector2
{
    class PruebaVector2
    {
        private float[] alturas;
        private float promedio;

        public void Cargar() 
        {
            alturas=new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese la altura de la persona:");
                string linea = Console.ReadLine();
                alturas[f] = float.Parse(linea);
            }
        }
    
        public void CalcularPromedio() 
        {
            float suma;
            suma=0;
            for(int f=0; f < 5; f++) 
            {
                suma=suma+alturas[f];
            }
            promedio=suma/5;
            Console.WriteLine("Promedio de alturas:"+promedio);
        }

        public void MayoresMenores() 
        {
            int may,men;
            may=0;
            men=0;
            for(int f = 0; f < 5; f++) 
            {
                if (alturas[f] > promedio) 
                {
	                may++;
                }
                else
                {
                    if (alturas[f] < promedio) 
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
            PruebaVector2 pv2 = new PruebaVector2();
            pv2.Cargar();
            pv2.CalcularPromedio();
            pv2.MayoresMenores();
        }
    }
}