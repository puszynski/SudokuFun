using SudokuLibrary;
using System;
using Xunit;

namespace XUnitTests
{
    public class SudokuBoardFactoryTests
    {
        public SudokuBoardEasyBuilder _sudokuBoardEasyBuilder;

        public SudokuBoardFactoryTests()
        {
            _sudokuBoardEasyBuilder = new SudokuBoardEasyBuilder();
        }

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
            var builder = new SudokuBoardEasyBuilder();
            var result = builder.NewEmptyBoard();

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SetDisplayFormat()
        {
            //Arrange

            // TODO MOCK _board
            var correctSudokuArray = new int[,] {
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
            
            var sudokuToDisplayOption2 = new string[] {
                "835 416 927",
                "296 857 431",
                "417 293 658",
                "           ",
                "569 134 782",
                "123 678 549",
                "748 529 163",
                "           ",
                "652 781 394",
                "981 345 276",
                "374 962 815"
            };

            //Act
            var builder = new SudokuBoardEasyBuilder();            
            var result = builder.SetDisplayFormat();

            //Asser
            Assert.Equal(sudokuToDisplay, result);
        }
    }
}
