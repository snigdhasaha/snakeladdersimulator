using SnakeLaddersSimulator.IOperations;
using SnakeLaddersSimulator.Model;

namespace SnakeLaddersSimulator.Operations
{
    public class Game
    {
        private ISimulatorOperations _simulatorOperations;
        public Board _board;
        public Player _player;
        
        private int _totalRolls;
        private int _totalClimbs;
        private int _totalSlides;
        private int _totalUnluckyRoll;
        private int _totalLuckyRoll;
        private int _biggestClimb;
        private int _biggestSlide;
        private List<int> _singleTurnList;
        private List<int> _singleConsecutiveTurnList;
        private List<int[]> _allConsecutiveTurnList;
       
        public Game(Board board, Player player, ISimulatorOperations simulatorOperations)
        {
            _board = board;
            _player = player;
            _simulatorOperations = simulatorOperations;
            _totalRolls = 0;
            _totalClimbs = 0;
            _totalSlides = 0;
            _totalUnluckyRoll = 0;
            _totalLuckyRoll = 0;
            _biggestClimb = 0;
            _biggestSlide = 0;
            _singleTurnList = new List<int>();
            _allConsecutiveTurnList = new List<int[]>();
            _singleConsecutiveTurnList = new List<int>();
        }

        public SimulatorData Play()
        {           
            while(_player.CellPosition != _board.Cells.Count)
            {
                CalculatePlayerPosition(RollDice());                
            }
            int[] longestTurn = FindLongestTurn();
            
            return _simulatorOperations.CreateSimulatorData(_totalRolls, _totalClimbs, _totalSlides, _totalUnluckyRoll, _totalLuckyRoll, _biggestClimb, _biggestSlide, longestTurn);
        }
        private int RollDice()
        {
            Random random = new Random();     
            
            int diceValue = random.Next(Dice.MinValue, Dice.MaxValue);
            
            _totalRolls++;

            RecordSingleAndConsecutiveTurns(diceValue);
            
            return diceValue;
        }
        private void CalculatePlayerPosition(int diceValue)
        {
            int moveCellPosition = _player.CellPosition + diceValue;

            if (moveCellPosition <= _board.Cells.Count)
            {
                if(_player.CellPosition >=94 && moveCellPosition == _board.Cells.Count)
                {
                    _totalLuckyRoll++;
                }

                // Check 6 is rolled by the player
                if (diceValue == Dice.MaxValue - 1)
                {
                    _player.CellPosition = moveCellPosition;
                    
                    if (moveCellPosition == _board.Cells.Count)
                        return;
                    else
                    {
                        CalculatePlayerPosition(RollDice());
                    }
                }

                var snake = CaughtBySnake(_board.Snakes, moveCellPosition);               
                if (snake != null)
                {
                    _player.CellPosition = snake.LowerCellNumber;
                    _totalUnluckyRoll++;
                    CalculateTotalSlides(snake);
                    
                    return;
                }
                else
                {
                    var isLuckyRoll = _board.Snakes.Where(s => (moveCellPosition - s.UpperCellNumber) > 0 && (moveCellPosition - s.UpperCellNumber) <= 2).Any();
                    if(isLuckyRoll)
                    {
                        _totalLuckyRoll++;
                    }
                }

                var ladder = RideOnLadder(_board.Ladders, moveCellPosition);
                if (ladder != null)
                {
                    _player.CellPosition = ladder.UpperCellNumber;
                    _totalLuckyRoll++;
                    CalculateTotalClimbs(ladder);
            
                    return;
                }

                _player.CellPosition = moveCellPosition;
            }
            
        }

        private static Snake? CaughtBySnake(List<Snake> snakes, int position)
        {            
            try
            {
                var snake = snakes.Where(s => s.UpperCellNumber == position).SingleOrDefault();
                return snake;
            }
            catch
            {
                throw new Exception("More than one snake in the same position");
            }
        }

        private static Ladder? RideOnLadder(List<Ladder> ladders, int position)
        {
            try
            {
                var ladder = ladders.SingleOrDefault(s => s.LowerCellNumber == position);
                return ladder;
            }
            catch
            {
                throw new Exception("More than one ladder in the same position");
            }
        }
        private void CalculateTotalClimbs(Ladder ladder)
        {
            int climb = ladder.UpperCellNumber - ladder.LowerCellNumber;
            
            if (_biggestClimb < climb)
            {
                _biggestClimb = climb;
            }

            _totalClimbs += climb;
        }
        private void CalculateTotalSlides(Snake snake)
        {
            int slide = snake.UpperCellNumber - snake.LowerCellNumber;
            
            if(_biggestSlide < slide)
            {
                _biggestSlide = slide;
            }
            
            _totalSlides += slide;
        }
        private void RecordSingleAndConsecutiveTurns(int diceValue)
        {
            if (diceValue == Dice.MaxValue - 1)
            {
                _singleConsecutiveTurnList.Add(diceValue);
            }
            else
            {
                if (_singleConsecutiveTurnList.Count > 0)
                {
                    _singleConsecutiveTurnList.Add(diceValue);
                    _allConsecutiveTurnList.Add(_singleConsecutiveTurnList.ToArray());
                    _singleConsecutiveTurnList.Clear();
                }
                else
                {
                    _singleTurnList.Add(diceValue);
                }
            }
        }
        private int[] FindLongestTurn()
        {
            int[] longestTurn = new int[] { };
            
            if (_allConsecutiveTurnList.Count > 0)
            {
                var longestTurnLength = _allConsecutiveTurnList.Max(x => x.Length);
                var longestTurnList = _allConsecutiveTurnList.Where(x => x.Length == longestTurnLength).ToList();
                int valueOfLastIndex = 0;
                
                foreach(var turn in longestTurnList)
                {
                    if (valueOfLastIndex < turn[longestTurnLength - 1])
                    {
                        valueOfLastIndex = turn[longestTurnLength - 1];
                        longestTurn = turn;
                    }
                }

                return longestTurn;
            }
            else
            {
                longestTurn = new[] { _singleTurnList.Max() } ;
                return longestTurn;
            }           
        }

    }
}
