using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuAlgoritmo
{
    public class Submatriz
    {
        public string localizacao { get; set; }
        public static int[,] submatriz = new int[3, 3];
        public static List<int> numerosDisponiveis = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static SortedList<string, int> posicaoInviolavel = new SortedList<string, int>();

        public Submatriz(string local) { 
            this.localizacao = local;           
            InitializeSubmatriz();
        }

        private static void InitializeSubmatriz()
        {
            
            Random random = new Random();
            int aleatorioI, aleatorioJ, numAleatorio;

            for (int i = 0; i < 3; i++)
            {
                do {
                    aleatorioI = random.Next(0, 3);
                    aleatorioJ = random.Next(0, 3);
                } while (posicaoInviolavel.ContainsKey(aleatorioI+""+aleatorioJ));

                numAleatorio = numerosDisponiveis[random.Next(numerosDisponiveis.Count)];
                posicaoInviolavel.Add(aleatorioI+""+aleatorioJ, numAleatorio);
                numerosDisponiveis.Remove(numAleatorio);
            }
        }

        public string Display()
        {                    
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(j != 2)
                    {
                        Console.Write(submatriz[i, j] + " - ");
                    }
                    else
                    {
                        Console.Write(submatriz[i, j] + " ");
                    }
                    
                }
                Console.Write("|| ");
                
            }
            Console.WriteLine();
            return "";
        }
    }
}
