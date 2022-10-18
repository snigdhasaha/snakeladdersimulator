using SnakeLaddersSimulator.IOperations;
using SnakeLaddersSimulator.Model;
using System.Text;

namespace SnakeLaddersSimulator.Operations
{
    public class SimulatorOperations : ISimulatorOperations
    {
        public SimulatorData CreateSimulatorData(int totalRolls, int totalClimbs, int totalSlides, int totalUnluckyRolls, int totalLuckyRolls, int biggestClimb, int biggestSlide, int[] longestTurn)
        {
            return new SimulatorData(totalRolls, totalClimbs, totalSlides, totalUnluckyRolls, totalLuckyRolls, biggestClimb, biggestSlide, longestTurn);
        }

        public void GetAllSimulatorData(List<SimulatorData> simulatorDataList)
        {
            GetLongestTurn(simulatorDataList);
            int index = 1;
            foreach(SimulatorData simulatorData in simulatorDataList)
            {
                StringBuilder longestRun = new StringBuilder();                
                longestRun.AppendJoin(',', simulatorData.LongestTurn);
                
                Console.WriteLine("Simulator: " + index +
                       " Total rolls: " + simulatorData.TotalRolls +
                       " Total climbs: " + simulatorData.TotalClimbs +
                       " Total slides: " + simulatorData.TotalSlides +
                       " Total unlucky rolls: " + simulatorData.TotalUnluckyRolls +
                       " Total lucky rolls: " + simulatorData.TotalLuckyRolls +
                       " Biggest climb: " + simulatorData.BiggestClimb +
                       " Biggest slide: " + simulatorData.BiggestSlide + 
                       " Longest run: " + longestRun);

                index++;
            }

            Console.WriteLine("Minimum rolls needed to win: " + GetMinimumRollsNeededToWin(simulatorDataList));
            Console.WriteLine(" Average rolls needed to win: " + GetAverageRollsNeededToWin(simulatorDataList));
            Console.WriteLine(" Maximum rolls needed to win: " + GetMaximumRollsNeededToWin(simulatorDataList));
            Console.WriteLine(" Minimum climbs: " + GetMinimumAmountsOfClimbs(simulatorDataList));
            Console.WriteLine(" Average climbs: " + GetAverageAmountsOfClimbs(simulatorDataList));
            Console.WriteLine(" Maximum climbs: " + GetMaximumAmountsOfClimbs(simulatorDataList));
            Console.WriteLine(" Minimum slides: " + GetMinimumAmountsOfSlides(simulatorDataList));
            Console.WriteLine(" Average slides: " + GetAverageAmountsOfSlides(simulatorDataList));
            Console.WriteLine(" Maximum slides: " + GetMaximumAmountsOfSlides(simulatorDataList));
            Console.WriteLine(" Biggest climbs: " + GetBiggestClimbInSingleTurn(simulatorDataList));
            Console.WriteLine(" Biggest slides: " + GetBiggestSlideInSingleTurn(simulatorDataList));
            Console.WriteLine(" Minimum unlucky rolls: " + GetMinimumUnluckyRolls(simulatorDataList));
            Console.WriteLine(" Average unlucky rolls: " + GetAverageUnluckyRolls(simulatorDataList));
            Console.WriteLine(" Maximum unlucky rolls: " + GetMaximumUnluckyRolls(simulatorDataList));
            Console.WriteLine(" Minimum lucky rolls: " + GetMinimumLuckyRolls(simulatorDataList));
            Console.WriteLine(" Average lucky rolls: " + GetAverageLuckyRolls(simulatorDataList));
            Console.WriteLine(" Maximum lucky rolls: " + GetMaximumLuckyRolls(simulatorDataList));
            Console.WriteLine(" Longest run: " + new StringBuilder().AppendJoin(",", GetLongestTurn(simulatorDataList)));
        }

        public int GetAverageAmountsOfClimbs(List<SimulatorData> simulatorDataList)
        {
            double averageClimbs = simulatorDataList.Average(x => x.TotalClimbs);
            return (int)Math.Round(averageClimbs);
        }

        public int GetAverageAmountsOfSlides(List<SimulatorData> simulatorDataList)
        {
            double averageSlides = simulatorDataList.Average(x => x.TotalSlides);
            return (int)Math.Round(averageSlides);
        }

        public int GetAverageLuckyRolls(List<SimulatorData> simulatorDataList)
        {
            double averageLuckyRolls = simulatorDataList.Average(x => x.TotalLuckyRolls);
            return (int)Math.Round(averageLuckyRolls);
        }

        public int GetAverageRollsNeededToWin(List<SimulatorData> simulatorDataList)
        {
            double averageRolls = simulatorDataList.Average(x => x.TotalRolls);
            return (int)Math.Round(averageRolls);
        }

        public int GetAverageUnluckyRolls(List<SimulatorData> simulatorDataList)
        {
            double averageUnluckyRolls = simulatorDataList.Average(x => x.TotalUnluckyRolls);
            return (int)Math.Round(averageUnluckyRolls);
        }

        public int GetBiggestClimbInSingleTurn(List<SimulatorData> simulatorDataList)
        {
            int biggestClimbInSingleTurn = simulatorDataList.Max(x => x.BiggestClimb);
            return biggestClimbInSingleTurn;
        }

        public int GetBiggestSlideInSingleTurn(List<SimulatorData> simulatorDataList)
        {
            int biggestSlideInSingleTurn = simulatorDataList.Max(x => x.BiggestSlide);
            return biggestSlideInSingleTurn;
        }

        public int[] GetLongestTurn(List<SimulatorData> simulatorDataList)
        {
            var maxLength = simulatorDataList.Max(x => x.LongestTurn.Length);
            var list = simulatorDataList.Where(x => x.LongestTurn.Length == maxLength).ToList();
            int longestTurn = 0;
            int[] turn = new int[] { };
            foreach(var item in list)
            {
                if (longestTurn < item.LongestTurn[maxLength - 1])
                {
                    longestTurn = item.LongestTurn[maxLength - 1];
                    turn = item.LongestTurn;
                }
            }
            return turn;
        }

        public int GetMaximumAmountsOfClimbs(List<SimulatorData> simulatorDataList)
        {
            int maximumAmountsOfClimbs = simulatorDataList.Max(x => x.TotalClimbs);
            return maximumAmountsOfClimbs;
        }

        public int GetMaximumAmountsOfSlides(List<SimulatorData> simulatorDataList)
        {
            int maximumAmountsOfSlides = simulatorDataList.Max(x => x.TotalSlides);
            return maximumAmountsOfSlides;
        }

        public int GetMaximumLuckyRolls(List<SimulatorData> simulatorDataList)
        {
            int maximumLuckyRolls = simulatorDataList.Max(x => x.TotalLuckyRolls);
            return maximumLuckyRolls;
        }

        public int GetMaximumRollsNeededToWin(List<SimulatorData> simulatorDataList)
        {
            int maximumRollsNeededToWin = simulatorDataList.Max(x => x.TotalRolls);
            return maximumRollsNeededToWin;
        }

        public int GetMaximumUnluckyRolls(List<SimulatorData> simulatorDataList)
        {
            int maximumUnluckyRolls = simulatorDataList.Max(x => x.TotalUnluckyRolls);
            return maximumUnluckyRolls;
        }

        public int GetMinimumAmountsOfClimbs(List<SimulatorData> simulatorDataList)
        {
            int minimumAmountsOfClimbs = simulatorDataList.Min(x => x.TotalClimbs);
            return minimumAmountsOfClimbs;
        }

        public int GetMinimumAmountsOfSlides(List<SimulatorData> simulatorDataList)
        {
            int minimumAmountsOfClimbs = simulatorDataList.Min(x => x.TotalClimbs);
            return minimumAmountsOfClimbs;
        }

        public int GetMinimumLuckyRolls(List<SimulatorData> simulatorDataList)
        {
            int minimumLuckyRolls = simulatorDataList.Min(x => x.TotalLuckyRolls);
            return minimumLuckyRolls;

        }

        public int GetMinimumRollsNeededToWin(List<SimulatorData> simulatorDataList)
        {
            int minimumRolls = simulatorDataList.Min(x => x.TotalRolls);
            return minimumRolls;

        }

        public int GetMinimumUnluckyRolls(List<SimulatorData> simulatorDataList)
        {
            int minimumUnluckyRolls = simulatorDataList.Min(x => x.TotalUnluckyRolls);
            return minimumUnluckyRolls;
        }
    }
}
