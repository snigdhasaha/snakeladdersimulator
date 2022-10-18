using SnakeLaddersSimulator.IOperations;
using SnakeLaddersSimulator.Model;

namespace SnakeLaddersSimulator.Operations
{
    public class BoardOperations : IBoardOperations
    {
        private ICellOperations cellOperations;
        public BoardOperations(ICellOperations cellOperations)
        {
            this.cellOperations = cellOperations;
        }

        public Board CreateBoard(int boardSize, List<Snake> snakePositionList, List<Ladder> ladderPositionList)
        {            
            return new Board(
                cellOperations.CreateCells(boardSize),
                ladderPositionList,
                snakePositionList                
            );
        }       
    }
}
