using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_2.AcevedoEnsisoPedroGabriel
{
    class BusquedaBinaria
    {
        private int[] vectorNumerico;
        
        public void Cargar()
        {
            Console.WriteLine("Ejemplo 1 busqueda binaria en un arreglo de numeros");
            Console.WriteLine("Ingrese 10 Numeros");
            string linea;
            vectorNumerico = new int[10];
            for (int i = 0; i < vectorNumerico.Length; i++)
            {
                Console.Write("Ingrese elemento " + (i + 1) + ": ");
                linea = Console.ReadLine();
                vectorNumerico[i] = int.Parse(linea);
            }
        }
        private void MetodoBurbuja()//aqui utilizaremos un metodo burbuja para ordenar el arreglo ya que el vector debe estar ordenado para que la busqueda binaria funcione
        {
            int t;
            for (int a = 1; a < vectorNumerico.Length; a++)
            {
                for (int b = vectorNumerico.Length - 1; b >= a; b--)
                {
                    if (vectorNumerico[b - 1] > vectorNumerico[b])
                    {
                        t = vectorNumerico[b - 1];
                        vectorNumerico[b - 1] = vectorNumerico[b];
                        vectorNumerico[b] = t;
                    }
                }
            }
        }
        public void Binario(int num)//aqui se pone el numero que se esta buscando
        {
            MetodoBurbuja();//primero ordenamos el arreglo ya que es necesario para que la busqueda binaria funcione
            int inferior = 0, superior = vectorNumerico.Length - 1;//aqui indicamos los limites del vectro superior e inferior
            int medio = 0;//este valor es con el que dividimos el vector en dos
            bool found = false;//variable booleana con la que indicamos cuando encontramos el valor buscado
            while (inferior <= superior && found == false)
            {
                medio = (inferior + superior) / 2;//aqui le damos el valor al punto medio al iniciar se le da el valor de la longitud del arreglo entre dos para dividir el arreglo en dos partes
                if (vectorNumerico[medio] == num)//si encontramos que el valor del vector actual es igual al numero buscado indicamos que lo encontramos
                    found = true;
                if (vectorNumerico[medio] > num)//si es mayor superior sera igual a lo que vale el punto medio -1
                    superior = medio - 1;
                else//si es menor inferior sera igual a lo que vale el punto medio +1
                    inferior = medio + 1;
            }
            if (found == false)//si no se encontro el numero....
            {
                Console.Write("\nEl elemento {0} no esta en el arreglo", num);
            }
            else//si es que si lo enocontramos....
            {
                Console.Write("\nEl elemento {0} esta en el arreglo", num);//imprimimos que si se encontro el numero...
            }
        }
        public void ImprimirNumerico()//metodo con el que inmprimimos el vector
        {
            foreach(var i in vectorNumerico)
            {
                Console.WriteLine(i);
            }
        }
    }
}
