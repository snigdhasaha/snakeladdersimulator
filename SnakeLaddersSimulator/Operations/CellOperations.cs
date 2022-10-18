using SnakeLaddersSimulator.IOperations;
using SnakeLaddersSimulator.Model;

namespace SnakeLaddersSimulator.Operations
{
    public class CellOperations : ICellOperations
    {        
        public List<Cell> CreateCells(int boardSize)
        {            
            if(boardSize <= 0)
            {
                throw new Exception("Board size cannot be zero");
            }
            else
            {
                List<Cell> cellList = new List<Cell>();
                for (int i = 0; i < boardSize; i++)
                {
                    cellList.Add(new Cell { CellNumber = i });
                }
                return cellList;
            }            
        }
    }
}
