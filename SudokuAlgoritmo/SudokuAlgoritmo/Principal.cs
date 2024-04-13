using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuAlgoritmo
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            Sudoku sudoku = new Sudoku();
            sudoku.Display();
        }
    }
}
