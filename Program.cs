using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de listas
            List<int> lista = new List<int>();
            List<int> lista2 = new List<int>();

            //Añadir a la lista
            lista.Add(2);
            lista2.Add(5); 

            // Para comparar usamos el CompareTo 


            if (lista == lista2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintas");
            }

            Console.ReadLine();
        }
    }
}
