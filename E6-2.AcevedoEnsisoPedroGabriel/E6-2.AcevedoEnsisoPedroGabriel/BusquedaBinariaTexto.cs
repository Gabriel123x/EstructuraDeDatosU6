using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_2.AcevedoEnsisoPedroGabriel
{
    class BusquedaBinariaTexto
    {
        private string[] vectorTexto;//aqui tenemos el segundo ejemplo de busqueda binaria dnde buscamos algun texto que exista en un arreglo
        public void Cargar()//introducimos 10 cadenas de texto al arreglo
        {
            Console.WriteLine("Ejemplo 2 busqueda binaria en un arreglo de cadenas de texto");
            Console.WriteLine("Ingrese 10 cadenas");
            string linea;
            vectorTexto = new string[10];
            for (int i = 0; i < vectorTexto.Length; i++)
            {
                Console.Write("Ingrese elemento " + (i + 1) + ": ");
                linea = Console.ReadLine();
                vectorTexto[i] = linea;
            }
        }
        private void MetodoBurbuja()//aqui utilizaremos un metodo burbuja para ordenar el arreglo ya que el vector debe estar ordenado para que la busqueda binaria funcione
        {
            string text;//este metodo burbuja fue cambiado para que pueda ordenar las palabras de un arreglo de cadenas de texto
            for (int a = 1; a < vectorTexto.Length; a++)
            {
                for (int b = vectorTexto.Length - 1; b >= a; b--)
                {
                    if (Convert.ToInt32(vectorTexto[b - 1][0]) > Convert.ToInt32(vectorTexto[b][0]))//en esta parte donde se comparan los textos comparamos el valor numerico de el primer caracter ya que este nos da su valor en codigo ASCII
                    {
                        text = vectorTexto[b - 1];
                        vectorTexto[b - 1] = vectorTexto[b];
                        vectorTexto[b] = text;
                    }
                }
            }
        }
        public void Binario(string texto)//aqui se pone el Texto que se busca
        {
            MetodoBurbuja();//primero ordenamos el arreglo ya que es necesario para que la busqueda binaria funcione
            int inferior = 0, superior = vectorTexto.Length - 1;//aqui indicamos los limites del vectro superior e inferior
            int medio = 0;//este valor es con el que dividimos el vector en dos
            bool found = false;//variable booleana con la que indicamos cuando encontramos el valor buscado
            while (inferior <= superior && found == false)
            {
                medio = (inferior + superior) / 2;//aqui le damos el valor al punto medio al iniciar se le da el valor de la longitud del arreglo entre dos para dividir el arreglo en dos partes
                if (vectorTexto[medio] == texto)//aqui cuando comparamos si un texto es igual al que buscamos lo hacemos sin transformarlo a numerico ya que el mismo texto nos indicara si son iguales
                    found = true;
                if (Convert.ToInt32(vectorTexto[medio][0]) > Convert.ToInt32(texto[0]))//al igual que en metodo burbuja podemos comparar si un texto es mayor a otro usando su valor en el codigo ASCII
                    superior = medio - 1;
                else//si es menor inferior sera igual a lo que vale el punto medio +1
                    inferior = medio + 1;
            }
            if (found == false)//si no se encontro la cadena....
            {
                Console.Write("\nEl elemento {0} no esta en el arreglo", texto);
            }
            else//si es que si lo enocontramos....
            {
                Console.Write("\nEl elemento {0} esta en el arreglo", texto);//imprimimos que si se encontro la cadena...
            }
        }
    }
}
