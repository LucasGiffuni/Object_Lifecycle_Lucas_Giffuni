//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
           
            int count = 0;

            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");

            Train t3 = new Train("Runaway Train");


            Console.WriteLine(t1 == t2); 
            Console.WriteLine(t2 == t3);
            //Retorna False debido a que, por mas de que su "Identificador" sea igual, son instancias distintas
            //por lo tanto, son objetos diferentes, apesar de compartir un "Identificador".
            while( false /*count < 1000000*/){ 
                //Llega a crear hasta 30mil instancias antes de que el compilador empiece 
                //de nuevo con la creación de las instancias.

                //En conclusión, depende del tamaño de los objetos (y probablemente de la memoria asignada al proyecto)
                //la cantidad de instancias maximas que podemos crear.
                new Train("a");
                count ++;
            }
        }
    }
}