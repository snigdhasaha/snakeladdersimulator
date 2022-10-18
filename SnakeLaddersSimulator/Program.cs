// See https://aka.ms/new-console-template for more information
using SnakeLaddersSimulator;
using SnakeLaddersSimulator.Model;
using SnakeLaddersSimulator.Operations;

var startup = new Startup();

int boardSize = startup.snakeLadderSimulatorSettings.BoardSize;
List<Snake> snakeList = startup.snakeLadderSimulatorSettings.Snakes;
List<Ladder> ladderList = startup.snakeLadderSimulatorSettings.Ladders;
string player = startup.snakeLadderSimulatorSettings.Player;
int runTime = startup.snakeLadderSimulatorSettings.RunTime;

SnakeLadderSimulatorStarter.Start(runTime, boardSize, snakeList, ladderList, player);

