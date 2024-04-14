using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuAlgoritmo
{
    public class Sudoku
    {
        public Object[,] grade = new Object[3, 3];

        public Sudoku()
        {
     
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("entrou");
                    Submatriz m = new Submatriz("m"+i+j);
                    grade[i,j] = m;
                }
            }
        }

        public void Display()
        {
            Submatriz m;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m = (Submatriz)grade[i,j];
                    Console.Write(m.Display());

                }
                Console.WriteLine("======================================");
            }
        }
    }
}
