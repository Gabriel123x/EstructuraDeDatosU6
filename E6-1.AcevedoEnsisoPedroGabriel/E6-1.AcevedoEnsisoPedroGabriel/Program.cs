using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_1.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Busqueda(object[] arreglo, object dato)//metodo con el que realizamos la busqueda secuencial
        {//se introduce un arreglo y el dato que se busca
            bool encontrado = false;
            foreach(var i in arreglo)//la busqueda secuencial simplemente recorre todos los elementos de un arreglo 
            {
                if (i == dato)//se recorren los datos y si lo encontramos cambiamos el estado de encontrado a verdadero
                    encontrado = true;
            }
            if(encontrado == true)//si se encontro el dato imprimimos que los encontramos de no ser asi imprimimos el mensaje apropiado
                Console.WriteLine("\nEl elemento {0} esta en el arreglo", dato);
            else
                Console.WriteLine("\nEl elemento {0} no esta en el arreglo", dato);

        }
        static void BusquedaConPosicion(int[] arreglo, int dato)//en la busqueda tambien aveces es necesario conocer la posicion donde se encuentra el dato
        {
            int posicion = 0;//variable con la que guardamos la posicion de la variable encontrada
            bool encontrado = false;
            for (int i = 0; i < arreglo.Length; i++)//recorremos los datos de uno por uno
            {
                if (arreglo[i] == dato)
                {
                    encontrado = true;//si encontramos el dato indicamos que encontramos el dato cambiendo el valor de esta variable encontrado
                    posicion = i + 1;//y le damos el valor de la posicion donde se encuentra ese dato
                }
            }
            if (encontrado == true)//si se encontro el dato imprimimos que los encontramos de no ser asi imprimimos el mensaje apropiado
                Console.WriteLine("\nEl elemento {0} esta en el arreglo en la posicion {1}", dato, posicion);
            else
                Console.WriteLine("\nEl elemento {0} no esta en el arreglo", dato);
        }
        static void Main(string[] args)
        {
            int[] Numeros = { 1, 2, 3, 4, 5, 21, 3, -1, 8 };
            string[] Nombres = { "Pedro", "Pablo", "Mariana", "Esteban" };
            Console.WriteLine("Ejemplo 1 busqueda de Pedro y pedro en arreglo con los elementos:");
            foreach (var i in Nombres)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Busqueda(Nombres, "Pedro");//a este metodo se le pone el arreglo como primer parametro de entrada y el segundo parametro es el elemento que buscamos
            Busqueda(Nombres, "pedro");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejemplo 2 busqueda del umero 3 y 100 en arreglo con los elementos:");
            foreach (var i in Numeros)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            BusquedaConPosicion(Numeros, 3);//en el ejemplo 2 no solo buscamos el numero indicado sino tambien buscamos en que posicion se encuentra
            BusquedaConPosicion(Numeros, 100);
            Console.ReadKey();
        }
    }
}
