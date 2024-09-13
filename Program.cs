using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Quantas pessoas você quer cadrastras");
            int quantidade = int.Parse(Console.ReadLine());

            
            string[] nomes = new string[quantidade];
            int[] idades = new int[quantidade];


            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write("Poderia me falar seu NOME Por favor: ");
                nomes[i] = Console.ReadLine();
           
                Console.Write("Poderia me falar sua IDADE: ");
                idades[i] = int.Parse(Console.ReadLine());

            }
             
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"{nomes[i]} {idades[i]} ");
            }    
              
        }    
    }
}