using SnakeLaddersSimulator.Model;
namespace SnakeLaddersSimulator.IOperations
{
    public  interface IBoardOperations
    {
        Board CreateBoard(int boardSize, List<Snake> snakePositionList, List<Ladder> ladderPositionList);
    }
}
