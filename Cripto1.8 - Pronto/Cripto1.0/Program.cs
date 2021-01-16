using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int h = 0;
            int maisAlfabeto = 0;
            string[] alfabeto = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " ", "ç", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            List<int> index = new List<int>();
            int[] Cripto = {4,83,7,989,89432,2153,536,5620,650,6060,60650,52056,6,560,5606,2,62,60,108190,8,8214210,804,9110,10,089,1,80,42, 89,123,251,3484,753,4241111,10101001,17140,20,3012000};



            string resposta;

            Console.Write("Encripite (sem virgulas ou caracteres especiais): ");
            resposta = Console.ReadLine();
            resposta = resposta.ToLower();

            


           
            
                
            

            foreach (char a in resposta)
            {

                for (int i = 0; i < alfabeto.Length; i++)
                {
                    if (a.ToString() == alfabeto[maisAlfabeto])
                    {
                        index.Add(Array.IndexOf(alfabeto, alfabeto[maisAlfabeto]));
                        maisAlfabeto = 0;
                        break;
                    }
                    maisAlfabeto++;
                    
                }
            }


            for (int i = 0; i < index.Count; i++)
            {
                Console.Write("{0}",Cripto[index[h]]);
                h++;
                
            }








           
            
            
            
            
            
            
            
            Console.ReadLine();


           
            
           
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
    }
}
