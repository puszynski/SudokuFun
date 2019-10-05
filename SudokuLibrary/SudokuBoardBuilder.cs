using SudokuLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuLibrary
{
    public abstract class SudokuBoardBuilder
    {
        private int[,] _board;

        public virtual int[,] NewEmptyBoard()
        {
            _board = new int[,] {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            return _board;
        }

        public abstract void GenerateRandomValues();
        public abstract void CleanRandomValues(EDifficultyLevel level);

        public string[] GetDisplayFormat()
        {
            var stringsArray = CastBoardToStringArray();
            var result = new string[11];

            //Add spaces
            for (int i = 0; i < 9; i++)
            {
                var temp = "";

                if (i == 3 || i == 7)
                    result[i] = "           ";

                for (int j = 0; j < 9; j++)
                {
                    if (j == 3 || j == 7)
                        temp += " ";

                    temp += stringsArray[i, j];
                }

                result[i] = temp;
            }

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        if (j == 3 || j == 7 || i == 3 || i == 7)
            //        {
            //            result[i, j] = " ";
            //        }

            //        else if (j < 3)
            //        {
            //            if (i < 3)
            //                result[i, j] = stringsArray[i, j];
            //            else if (i > 3 && i < 7)
            //                result[i + 1, j] = stringsArray[i, j];
            //            else
            //                result[i + 2, j] = stringsArray[i, j];
            //        }

            //        else if (j > 3 && j < 7)
            //        {
            //            if (i < 3)
            //                result[i, j + 1] = stringsArray[i, j];
            //            else if (i > 3 && i < 7)
            //                result[i + 1, j + 1] = stringsArray[i, j];
            //            else
            //                result[i + 2, j + 1] = stringsArray[i, j];
            //        }

            //        else if (j > 8)
            //        {
            //            if (i < 3)
            //                result[i, j + 2] = stringsArray[i, j];
            //            else if (i > 3 && i < 7)
            //                result[i + 1, j + 2] = stringsArray[i, j];
            //            else
            //                result[i + 2, j + 2] = stringsArray[i, j];
            //        }
            //    }
            //}

            return result;
        }

        private string[,] CastBoardToStringArray()
        {
            var temp = new string[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    temp[i, j] = _board[i, j].ToString();
                }
            }

            return temp;
        }
    }
}
