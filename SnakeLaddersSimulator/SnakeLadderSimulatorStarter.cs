using SnakeLaddersSimulator.Model;
using SnakeLaddersSimulator.Operations;

namespace SnakeLaddersSimulator
{
    public static class SnakeLadderSimulatorStarter
    {        
        public static void Start(int simulatorRunTime, int boardSize, List<Snake> snakeList, List<Ladder> ladderList, string playerName)
        {
            if (IsValidConfig(simulatorRunTime, boardSize, snakeList, ladderList, playerName))
            {
                BoardOperations boardOperations = new BoardOperations(new CellOperations());
                Board board = boardOperations.CreateBoard(boardSize, snakeList, ladderList);
                PlayerOperations playerOperations = new PlayerOperations();
                List<SimulatorData> simulatorDataList = new List<SimulatorData>();

                for (int i = 0; i < simulatorRunTime; i++)
                {
                    Game game = new Game(board, playerOperations.CreatePlayer(playerName), new SimulatorOperations());
                    SimulatorData simulatorData = game.Play();
                    simulatorDataList.Add(simulatorData);
                }

                SimulatorOperations simulatorOperations = new SimulatorOperations();
                simulatorOperations.GetAllSimulatorData(simulatorDataList);
            }
        }

        public static bool IsValidConfig(int simulatorRunTime, int boardSize, List<Snake> snakeList, List<Ladder> ladderList, string playerName)
        {
            if(simulatorRunTime == 0)
            {
                Console.WriteLine("Please define simulator run time");
                return false;
            }
            if(boardSize != 100)
            {
                Console.WriteLine("Please set the board size to 100");
                return false;
            }
            if(snakeList == null || snakeList.Count ==0)
            {
                Console.WriteLine("Board doesn't have any snake");
                return false;
            }
            if(ladderList == null || ladderList.Count ==0)
            {
                Console.WriteLine("Board doesn't have any ladder");
                return false;
            }
            if (string.IsNullOrEmpty(playerName))
            {
                Console.WriteLine("Player name is missing in the config");
                return false;
            }
            if(CheckIfMultipleSnakeAtSameLocation(snakeList))
            {
                Console.WriteLine("Multiple snakes at the same location");
                return false;
            }
            if(CheckIfMultipleLadderAtSameLocation(ladderList))
            {
                Console.WriteLine("Multiple ladders at the same location");
                return false;
            }
            if(CheckIfSnakeAndLadderHasSameUpperCellPosition(snakeList, ladderList))
            {
                Console.WriteLine("Snake and ladder cannot be at the same location");
                return false;
            }
            if(CheckIfSnakeWithoutLowerOrUpperPosition(snakeList))
            {
                Console.WriteLine("Define snake with upper and lower cell position");
                return false;
            }
            if (CheckIfLadderWithoutLowerOrUpperPosition(ladderList))
            {
                Console.WriteLine("Define ladder with upper and lower cell position");
                return false;
            }
            return true;
        }

        private static bool CheckIfMultipleSnakeAtSameLocation(List<Snake> snakeList)
        {
            var snakeGroupByUpperCellCount = snakeList.GroupBy(x => x.UpperCellNumber).ToList().Count();
            if(snakeGroupByUpperCellCount < snakeList.Count)
            {
                return true;
            }
            return false;
        }
        private static bool CheckIfMultipleLadderAtSameLocation(List<Ladder> ladderList)
        {
            var snakeGroupByUpperCellCount = ladderList.GroupBy(x => x.LowerCellNumber).ToList().Count();
            if (snakeGroupByUpperCellCount < ladderList.Count)
            {
                return true;
            }
            return false;
        }
        private static bool CheckIfSnakeAndLadderHasSameUpperCellPosition(List<Snake> snakeList, List<Ladder> ladderList)
        {
            foreach(var snake in snakeList)
            {
                if(ladderList.Where(l=> l.UpperCellNumber == snake.UpperCellNumber).Any())
                    return true;
            }

            return false;
        }
        private static bool CheckIfSnakeWithoutLowerOrUpperPosition(List<Snake> snakes)
        {
            return snakes.Where(x => x.UpperCellNumber == 0 || x.LowerCellNumber == 0).Any();
        }
        private static bool CheckIfLadderWithoutLowerOrUpperPosition(List<Ladder> ladders)
        {
            return ladders.Where(x => x.UpperCellNumber == 0 || x.LowerCellNumber == 0).Any();
        }
    }
}
