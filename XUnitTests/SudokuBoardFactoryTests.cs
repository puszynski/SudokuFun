using SudokuLibrary;
using System;
using Xunit;

namespace XUnitTests
{
    public class SudokuBoardFactoryTests
    {
        [Fact]
        public void CreateNewEmptyBoard()
        {
            //Arrange
            int[,] expectedResult = new int[,] {
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

            //Act
            var builder = new SudokuBoardBuilder();
            var result = builder.NewEmptyBoard();

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SetDisplayFormat()
        {
            //Arrange
            var correctSudokuArray = new int[,] { // TO MUSI BYÆ JAKO MOCK _board Z BUILDERA
                { 8,3,5,4,1,6,9,2,7},
                { 2,9,6,8,5,7,4,3,1},
                { 4,1,7,2,9,3,6,5,8},
                { 5,6,9,1,3,4,7,8,2},
                { 1,2,3,6,7,8,5,4,9},
                { 7,4,8,5,2,9,1,6,3},
                { 6,5,2,7,8,1,3,9,4},
                { 9,8,1,3,4,5,2,7,6},
                { 3,7,4,9,6,2,8,1,5}
            };

            var sudokuToDisplay = new string[,] {
                { "8","3","5"," ","4","1","6"," ","9","2","7"},
                { "2","9","6"," ","8","5","7"," ","4","3","1"},
                { "4","1","7"," ","2","9","3"," ","6","5","8"},
                { " "," "," "," "," "," "," "," "," "," "," "},
                { "5","6","9"," ","1","3","4"," ","7","8","2"},
                { "1","2","3"," ","6","7","8"," ","5","4","9"},
                { "7","4","8"," ","5","2","9"," ","1","6","3"},
                { " "," "," "," "," "," "," "," "," "," "," "},
                { "6","5","2"," ","7","8","1"," ","3","9","4"},
                { "9","8","1"," ","3","4","5"," ","2","7","6"},
                { "3","7","4"," ","9","6","2"," ","8","1","5"}
            };

            //Act
            var builder = new SudokuBoardBuilder();
            var result = builder.SetDisplayFormat();

            //Asser
            Assert.Equal(sudokuToDisplay, result);
        }
    }
}
