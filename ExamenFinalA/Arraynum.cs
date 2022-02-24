using System;
using System.Collections;

namespace ExamenFinalA
{
    class Arraynum
    {
        static void Main(string[] args)
        {
            ArrayList mainList = new ArrayList();



            mainList.Add(5);
            mainList.Add(4);
            mainList.Add(0);
            mainList.Add(4);
            mainList.Add(5);

            foreach (var num in mainList)
            {
                Console.WriteLine(" \n Lista de numeros: " + num);
            }
        }

    }
}
