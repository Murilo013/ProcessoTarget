using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace codigo;

class Program {

    //Ex 2 -------------------------------------
    static string ex2Fibonacci()
    {
        Console.WriteLine("----- Ex 02 -----");
        Console.Write("Insira um valor para a verificação: ");
        int valor = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 0;
        bool loop = true;


        while (loop == true)
        {
            if (valor == c)
            {
                return $"O número {valor} pertence a sequencia";
            }
            else
            {
                if (valor > c)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                else
                {
                    loop = false;
                }
            }
        }
        return $"O número {valor} não pertence a sequencia";
    }

    //    Ex 5 -------------------------------------

    static int[] InverterArray(int[]arraynum)
    {
        int troca;
        int inicio = 0;

        for (int i = arraynum.Length -1 ; inicio < i; i--)
        {
            troca = arraynum[i];
            arraynum[i] = arraynum[inicio];
            arraynum[inicio] = troca; 
            inicio++;
        }
        return arraynum;
    }



    static void Main(string[] args)
    {
        Console.WriteLine(ex2Fibonacci());

        Console.WriteLine("\n----- Ex 05 -----");

        Console.Write("Array original -->");
        int[] arrayoriginal = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        foreach (int elemento in arrayoriginal)
        {
            Console.Write($" / {elemento} ");
        }

        Console.WriteLine("\n");

        Console.Write("Array invertido -->");
        foreach (int elemento in InverterArray(arrayoriginal)){
            Console.Write($" / {elemento} ");
        }
    }
}

