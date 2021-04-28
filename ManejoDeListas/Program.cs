using System;
using System.Collections.Generic;

namespace ManejoDeListas
{
    class Program
    {
        static void Main(string[] args)
        {
                    
             
            //Las listas son uno de los varios tipo de colección de datos

            //Creacion de una Lista
            List<int> numeros = new List<int>() {1,2,3,4,5,6,7,8,9};

            //Insertar un elemento en una lista vacía
            numeros.Add(1);

            //Insertar un elemento en la primera posición de una lista
            numeros.Insert(0,0); //primer valor indica la posicion donde quiero insertar un dato y la segunda posicion es el dato a insertar

            //Insertar un elemento en la última posición de una lista
            numeros.Insert(numeros.Count,2);
            //o usar add

            //Insertar un elemento a continuación de uno dado
            numeros.Insert(numeros.IndexOf(2) + 1,3);


            //Buscar elementos en una lista
            List<int> numerosEncontrados = numeros.FindAll(i => i < 3);
            Console.WriteLine("Buscar Elementos de una lista");
            foreach (var valores in numerosEncontrados)
            {
                Console.WriteLine(valores);
            }
            Console.WriteLine("*******************************************");
            Console.WriteLine("Buscar primer Elementos de una lista");

            int PrimerValor = numeros[0];
            Console.WriteLine("el primer elemento de la lista es: {0}",PrimerValor);
            Console.WriteLine("*******************************************");


            //Eliminar primer elemento de una lista
            Console.WriteLine("Eliminar primer elemento de una lista");
            numeros.Remove(numeros[0]);
           
            foreach (var valores in numeros)
            {
                Console.WriteLine(valores);
            }

            //Eliminar un elemento dada la posición
            Console.WriteLine("Eliminar elemento dada la posición");
            numeros.RemoveAt(2);

            foreach (var valores in numeros)
            {
                Console.WriteLine(valores);
            }


            //Eliminar un elemento dado
            Console.WriteLine("Eliminar elemento dado");
            numeros.Remove(2);

            foreach (var valores in numeros)
            {
                Console.WriteLine(valores);
            }
        }
    }
}
