using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile_For_Swicth
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Imprimir los numero del 1 al 10, uno abajo del otro

            /*int n = 1;
            while (n <= 10) 
            {
                Console.WriteLine(n);
                n++;
            }
            Console.ReadKey();
            */

            /***************************************************************************/

            //2. Imprimir los números del 1 al 10 salteando de a 2 uno abajo del otro.

            /*/int n = 1;
            while(n<=10)
            {
                Console.WriteLine(n);
                n += 2;
            }
            Console.ReadKey();*/

            /**************************************************************************/

            // 3. Imprimir los números del 10 al 1 uno abajo del otro.

            /*int n = 10;
            while (n>= 1) 
            {
                Console.WriteLine(n);
                n--;
            }*/

            /**************************************************************************/

            // 4. Imprimir los números del 1 al 10, sin imprimir números 2, 5 y 9, uno abajo del otro.

            /*int n = 1;
            while(n<=10)
            {
                if ((n != 2) && (n != 5) && (n != 9))
                {
                    Console.WriteLine(n);
                    
                }
                n++;
            }*/

            /**************************************************************************/

            //5. Imprimir los números del 1 al 30 sin imprimir números entre el 10 y el 20 uno abajo del otro.
            /*int n = 1;
            while (n <= 30)
            {
                if ((n <= 10) || (n >= 20))
                {
                    Console.WriteLine(n);
                }
                n++;
            }*/

            /**************************************************************************/

            //6. Imprimir la suma de los números del 1 al 10.

            /*int n= 1, suma=0;

            while (n <= 10)
            {
                suma += n;
                n++;
            }
            Console.WriteLine("La suma del 1 al 10 es igual a: " + suma);*/

            /**************************************************************************/

            //7. Imprimir la suma de los números pares del 1 al 25

            /*int n = 1;
            int suma = 0;
            while(n <= 25)
            {
                if(n % 2 == 0)
                {
                    suma += n;//equivale a suma = suma + n

                }
                n++;
            }
            Console.WriteLine("la suma de los pares es: " + suma);
            */

            // 8. Imprimir la multiplicación de los números impares que se encuentran entre - 10 y 10.

            int n = -10;
            int multi = 1;
            while (n <= 10) 
            {
                if (n % 2 != 0)
                {
                    multi *= n;
                }
                n++;
            }
            Console.WriteLine("la multiplicacion de los impares del -10 a: " + multi);
            
            Console.ReadKey();
        }
    }
}
