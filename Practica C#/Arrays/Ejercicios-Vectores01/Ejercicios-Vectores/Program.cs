using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 1:
            Dado el vector {10,20,5,15,30,20}
            1. Informar el vector de la forma: "Índice: X, 
            Valor: Y"
            2. Sumar el vector e informar el total
            3. Informar el contenido de las posiciones 
            impares (por ejemplo, las posiciones 1,3,5,etc)
            4. Informar el mayor número
            5. Informar cuántas veces aparece el número 20*/

            /*int[] vec;
            vec = new int[6];
            vec[0] = 10;
            vec[1] = 20;
            vec[2] = 5;
            vec[3] = 15;
            vec[4] = 30;
            vec[5] = 20;*/

            //esto es equivalente a:

            /*int[] vec = {10,20,5,15,30,20};
            int n;  //  este es mi indice
            int suma = 0;// la suma de los vectores
            int contador = 0; // contar las veces que aparece un numero
            int maximo = vec[0];// es el vec[0] ya que inicia con el

            for(n= 0; n< vec.Length; n++)
            {
                if(n % 2 == 1)
                {
                    Console.WriteLine("en el indice: " + n + "  se encuentra el numero: "+vec[n]);
                }

                suma += vec[n];//sumo con el vector anterior y lo guardo en suma

                if(vec[n] > maximo)
                {
                    maximo = vec[n];
                }

                if( vec[n] == 20)
                {
                    contador++;
                }
            }
            Console.WriteLine("LA SUMA DE TODOS LOS VECTORES ES: "+ suma);
            Console.WriteLine("EL MAYOR NUMERO ES: "+ maximo);
            Console.WriteLine("La cantidad de veces que se repite el 20 es: "+ contador);
            Console.ReadKey();*/
        }
    }
}
