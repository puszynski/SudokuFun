using SudokuLibrary;
using System;

namespace SudokuConsoleDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Sudoku board is displey below");

            var easyBuilder = new SudokuBoardEasyBuilder();
            var director = new SudokuDirector(easyBuilder);
            
            var sudokuArray = director.GetResult();

            DisplaySudokuArray(sudokuArray);
            Console.ReadLine();
        }

        static void DisplaySudokuArray(string[] arrayToDisplay)
        {
            foreach (var line in arrayToDisplay)
            {
                Console.WriteLine(line);
            }
        }
    }
}
