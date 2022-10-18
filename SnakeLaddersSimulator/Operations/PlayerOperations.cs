using SnakeLaddersSimulator.IOperations;
using SnakeLaddersSimulator.Model;

namespace SnakeLaddersSimulator.Operations
{
    public class PlayerOperations : IPlayerOperations
    {
        public Player CreatePlayer(string name)
        {
            return new Player { 
                Name = name, 
                CellPosition = 0
            };
        }
    }
}
