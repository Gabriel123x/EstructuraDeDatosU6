using System;
using System.Collections;//resulta c# ya tiene una libreria de tabla hash
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_3.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1 usando clase hashtable de c#");
            Hashtable miTabla = new Hashtable();//El primer ejemplo lo realizaremos con la tabla hash que nos proporciona c#
            // Usando Add()
            Console.WriteLine("Agregamos los siguientes elementos a la tabla hash");
            miTabla.Add("A", "manzana");//cuando usamos el metodo add el primer elemento que se pone es nuestra llave y el segundo es lo que queremos agregar a la lista
            miTabla.Add("D", "durazno");
            miTabla.Add("B", "banana");
            miTabla.Add("C", "coco");
            PrintCollection(miTabla);//imprimimos lo que hay en nuestra tabla hash.....
            Console.WriteLine();

            // Usando la propiedad Count
            Console.WriteLine("Imprimimos la cantidad de elementos que hay en nuestra tabla");
            Console.WriteLine("Count: {0}\n", miTabla.Count);//usando la propiedad count podemos apreciar cuantos elementos estan en nuestra tabla

            // Usando ContainsKey()
            Console.Write("Checamos si hay un elemento en la tabla cuya llave sea D: ");
            Console.WriteLine(miTabla.ContainsKey("D"));//usando el metodo containskey podemos ver si hay algun elemento en la tabala con la llave D
            Console.Write("Checamos si hay un elemento en la tabla cuya llave sea S: ");
            Console.WriteLine(miTabla.ContainsKey("S") + "\n");//usando el metodo containskey podemos ver si hay algun elemento en la tabala con la llave S

            // Usando ContainsValue()
            Console.Write("Checamos si hay un elemento en la tabla cuyo texto sea banana: ");
            Console.WriteLine(miTabla.ContainsValue("banana"));//usando el metodo containsvalue podemos ver si hay algun elemento en la tabala con el valor de banana
            Console.Write("Checamos si hay un elemento en la tabla cuyao texto sea mango: ");
            Console.WriteLine(miTabla.ContainsValue("mango") + "\n");//usando el metodo containsvalue podemos ver si hay algun elemento en la tabala con el valor de mango

            // Usando Remove()
            Console.WriteLine("Quitamos el elemento de la tabla que tiene la llave B");
            miTabla.Remove("B");//usando el metodo remove quitamos un elemento de la tabla que tenga la llave introducida en esta sobrecarga
            PrintCollection(miTabla);
            Console.WriteLine();

            // Usando la propiedad Keys
            Console.WriteLine("Imprimimos todas las llaves de nuestra tabla");
            foreach (string key in miTabla.Keys)//la propiedad keys contiene todas las llaves que hay en la tabla
                Console.WriteLine(key);

            // Usando la propiedad Values()
            Console.WriteLine();
            Console.WriteLine("Imprimimos todos los valores de los elementos en nuestra tabla");
            foreach (string val in miTabla.Values)//la propiedad values contiene todos los valores en nuestra tabla
                Console.WriteLine(val);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejemplo 2 usando clase MetodoHash creada");
            Console.WriteLine("Primero creamos un arreglo de 8 elementos y los metimos en la tabla hash dandoles llaves lo que se imprime a continuacion son las colisiones que hubo...");
            MetodoHash Prueba = new MetodoHash(8);//instanciamos clase con un arreglo de tamaño 8
            string[] Elementos = { "22", "95", "75", "80", "77", "90", "33", "45" };
            Prueba.FuncionHash(Elementos, Prueba.array);

            Console.WriteLine("\n Imprimimos como quedo la tabla hash con sus llaves");
            Prueba.Mostrar();//lo que hase la tabal hash en este caso es asignarle una llave a cada elemento del arreglo si dos elementos del arreglo tienen la misma llave entonces ocurre una colision y la llave del elemento que hiso colision se cambia hasta que la llave ya no haga colision con otra llave

            Console.WriteLine("\n Buscamos el elemento 90 en el arreglo");
            string Buscar = Prueba.BuscarClave("90");//aqui se hace la busqueda el metodo regresa el elemento buscado si lo encuentra de no ser asi regresara un valor nulo...
            if (Buscar == null)//usamos el valor nulo que regresa el metodo buscar clave para indicar que no encontramos nuestro elemento
            {
                Console.WriteLine("El elemento " + Buscar + " No se encuentra en la tabla");
            }

            Console.WriteLine("\n Buscamos el elemento 100 en el arreglo");
            Buscar = Prueba.BuscarClave("100");//aqui se hace la busqueda el metodo regresa el elemento buscado si lo encuentra de no ser asi regresara un valor nulo...
            if (Buscar == null)//usamos el valor nulo que regresa el metodo buscar clave para indicar que no encontramos nuestro elemento
            {
                Console.WriteLine("El elemento No se encuentra en la tabla");
            }
            Console.ReadKey();
        }
        public static void PrintCollection(IEnumerable myCollection)//metodo que usamos para imprimir los elementos de una coleccion en este caso es la coleccion de la tabla hash genereda por la clase hashtable de c#
        {
            foreach (DictionaryEntry de in myCollection)
                Console.WriteLine("Key: {0} Value: {1}", de.Key, de.Value);
        }
    }
}
