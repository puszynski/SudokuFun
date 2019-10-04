using SudokuLibrary;
using System;

namespace SudokuConsoleDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Sudoku board is displey below");

            var sudokuBuilder = new SudokuBoardBuilder();
            sudokuBuilder.NewEmptyBoard();

            var sudokuArray = sudokuBuilder.NewEmptyBoard();

            DisplaySudokuArray(sudokuArray);
        }

        static void DisplaySudokuArray(int[,] arrayToDisplay)
        {

        }
    }
}
