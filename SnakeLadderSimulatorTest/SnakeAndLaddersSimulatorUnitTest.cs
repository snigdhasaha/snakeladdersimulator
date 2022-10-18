using SnakeLaddersSimulator.Model;

namespace SnakeLadderSimulatorTest
{
    public class SnakeAndLaddersSimulatorUnitTest
    {
        [Fact]
        public void TaskCheckIfRuntimeConfigured()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void TaskCheckIfBoardSizeIs100()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void TaskCheckIfSnakeHasDefined()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void TaskCheckIfLadderHasDefined()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void TaskCheckIfPlayerNameHasDefined()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void TaskCheckIfMultipleSnakesNotHavingSameUpperPoisition()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void TaskCheckIfMultipleLadderNotHavingSameLowerPosition()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void TaskCheckIfSnakeAndLadderAtSameLocation()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void TaskCheckIfLadderHasUpperAndLowerCellPosition()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void TaskCheckIfSnakeHasUpperAndLowerCellPosition()
        {
            int runTime = 100;
            int boardSize = 100;
            List<Snake> snakes = new List<Snake>
            {
                new Snake
                {
                    UpperCellNumber = 30,
                    LowerCellNumber = 20
                },
                new Snake
                {
                    UpperCellNumber = 50,
                    LowerCellNumber = 5
                },
            };
            List<Ladder> ladderList = new List<Ladder>
            {
                new Ladder
                {
                    UpperCellNumber= 40,
                    LowerCellNumber= 10
                },
                new Ladder
                {
                    UpperCellNumber= 90,
                    LowerCellNumber= 3
                }
            };
            string playerName = "Test player";
            bool expectedValue = true;

            bool actualValue = SnakeLaddersSimulator.SnakeLadderSimulatorStarter.IsValidConfig(runTime, boardSize, snakes, ladderList, playerName);

            Assert.Equal(expectedValue, actualValue);
        }
    }
}