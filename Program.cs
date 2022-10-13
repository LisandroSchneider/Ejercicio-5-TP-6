using System;

namespace Ejercicio_n_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int n1,n2;
            string dato1,dato2;
            

        //solicitar dato

            Console.WriteLine("digite el primer numero");
            dato1 = Console.ReadLine();
            n1 = Convert.ToInt32(dato1);

            Console.WriteLine("digite el segundo numero");
            dato2 = Console.ReadLine();
            n2 = Convert.ToInt32(dato2);

            //verificador
            if(n1<n2)
            {
                Console.WriteLine("{0} es mayor que: {1}",n2,n1);
            }
            else
            {
                Console.WriteLine("{0} es mayor que: {1}",n1,n2);
            }
        }
    }
}
