using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuLibrary
{
    public class SudokuDirector
    {
        SudokuBoardBuilder _builder;

        public SudokuDirector(SudokuBoardBuilder builder)
        {
            _builder = builder;
            _builder.NewEmptyBoard();
            //TODO other operations
        }

        public string[] GetResult()
        {
            return _builder.GetDisplayFormat();
        }
    }
}
