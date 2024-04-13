﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuAlgoritmo
{
    public class Submatriz
    {
        public string localizacao { get; set; }
        public int[,] submatriz = new int[3,3];

        public Submatriz(string local) { 
            this.localizacao = local;
        }

        public string Display()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(this.submatriz[i, j] + " - ");
                }
                
            }
            Console.WriteLine();
            return "";
        }
    }
}