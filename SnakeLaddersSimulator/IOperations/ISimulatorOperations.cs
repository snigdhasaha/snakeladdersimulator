using SnakeLaddersSimulator.Model;

namespace SnakeLaddersSimulator.IOperations
{
    public interface ISimulatorOperations
    {
        SimulatorData CreateSimulatorData(int totalRolls, int totalClimbs, int totalSlides, int totalUnluckyRolls, int totalLuckyRolls, int biggestClimb, int biggestSlide, int[] longestTurn);
        void GetAllSimulatorData(List<SimulatorData> simulatorDataList);
        int GetMinimumRollsNeededToWin(List<SimulatorData> simulatorDataList);
        int GetAverageRollsNeededToWin(List<SimulatorData> simulatorDataList);
        int GetMaximumRollsNeededToWin(List<SimulatorData> simulatorDataList);
        int GetMinimumAmountsOfClimbs(List<SimulatorData> simulatorDataList);
        int GetAverageAmountsOfClimbs(List<SimulatorData> simulatorDataList);
        int GetMaximumAmountsOfClimbs(List<SimulatorData> simulatorDataList);
        int GetMinimumAmountsOfSlides(List<SimulatorData> simulatorDataList);
        int GetAverageAmountsOfSlides(List<SimulatorData> simulatorDataList);
        int GetMaximumAmountsOfSlides(List<SimulatorData> simulatorDataList);
        int GetBiggestClimbInSingleTurn(List<SimulatorData> simulatorDataList);
        int GetBiggestSlideInSingleTurn(List <SimulatorData> simulatorDataList);
        int[] GetLongestTurn(List<SimulatorData> simulatorDataList);
        int GetMinimumUnluckyRolls(List<SimulatorData> simulatorDataList);
        int GetAverageUnluckyRolls(List<SimulatorData> simulatorDataList);
        int GetMaximumUnluckyRolls(List<SimulatorData> simulatorDataList);
        int GetMinimumLuckyRolls(List<SimulatorData> simulatorDataList);
        int GetAverageLuckyRolls(List<SimulatorData> simulatorDataList);
        int GetMaximumLuckyRolls(List<SimulatorData> simulatorDataList);

    }
}
