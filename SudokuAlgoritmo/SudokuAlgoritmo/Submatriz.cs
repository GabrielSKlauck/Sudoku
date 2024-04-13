using System;
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
        public static List<int> numerosDisponiveis = new List<int>();

        public Submatriz(string local) { 
            this.localizacao = local;
            for (int i = 1; i < 10; i++)
            {
                numerosDisponiveis.Add(i);
            }
            InitializeSubmatriz();
        }

        private static void InitializeSubmatriz()
        {
            Random random = new Random();
            int aleatorioI;
            int aleatorioJ;
            int numAleatorio;

            for (int i = 0; i < 3; i++)
            {
                aleatorioI = random.Next(0,3);
                aleatorioJ = random.Next(0,3);
                numAleatorio = numerosDisponiveis[random.Next(numerosDisponiveis.Count())];
                submatriz[aleatorioI, aleatorioJ] = numAleatorio;
                numerosDisponiveis.Remove(numAleatorio);               
            }
        }

        public string Display()
        {                    
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(submatriz[i, j] + " - ");
                }
                Console.Write("|");
                
            }
            Console.WriteLine();
            return "";
        }
    }
}
