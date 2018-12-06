using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_3.AcevedoEnsisoPedroGabriel
{
    class MetodoHash
    {
        public string[] array;
        int size;
        public MetodoHash(int tama)
        {
            size = tama;
            array = new string[tama];//le damos tamaño al arreglo
            for(int i = 0; i < array.Length; i++)//llenamos el arreglo con valores temporales -1
            {
                array[i] = "-1";
            }
        }
        public void FuncionHash(string[] CadenaArray, string[] Arreglo)//metodo con el que le damos llaves a los valores de un arreglo
        {
            for (int i = 0; i < CadenaArray.Length; i++)
            {
                string Elemento = CadenaArray[i];
                int IndiceArray = int.Parse(Elemento) % 7;
                Console.WriteLine("El indice es: " + IndiceArray + " Para el elemento: " + Elemento);
                while(array[IndiceArray] != "-1")
                {
                    IndiceArray++;
                    Console.WriteLine("Ocurrio una colision en el indice: " + (IndiceArray - 1) + " Cambiar al indice: " + IndiceArray);
                    IndiceArray %= size;
                }
                array[IndiceArray] = Elemento;
            }
        }
        public void Mostrar()//metodo con el que mostramos la tabla hash generada
        {
            int incremento = 0, j;
            for(int i = 0; i < 1; i++)
            {
                incremento += 8;
                for(j = 0; j < 71; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for(j = incremento - 8; j < incremento; j++)
                {
                    Console.Write(string.Format("|  {0}" + " ", j));
                }
                Console.WriteLine("|");
                for(int n = 0; n <71; n++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for (j = incremento - 8; j < incremento; j++)
                {
                    if (array[j].Equals("-1"))
                    {
                        Console.Write("|   ");
                    }
                    else
                    {
                        Console.Write(string.Format("|  {0}" + " ", array[j]));
                    }
                }
                Console.WriteLine(" | ");
                for (j = 0; j < 71; j++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
        public string BuscarClave(string Elemento)//metodo con el que buscamos si un elemento existe en la tabla hash usando su clave
        {
            int IndiceArray = int.Parse(Elemento) % 7;
            int contador = 0;
            while(array[IndiceArray] != "-1")
            {
                if(array[IndiceArray] == Elemento)
                {
                    Console.WriteLine("El elemento " + Elemento + " Fue encontrado en el indice " + IndiceArray);
                    return array[IndiceArray];
                }
                IndiceArray++;
                IndiceArray %= size;
                contador++;
                if(contador > 7)
                {
                    break;
                }
            }
            return null;
        }
    }
}
