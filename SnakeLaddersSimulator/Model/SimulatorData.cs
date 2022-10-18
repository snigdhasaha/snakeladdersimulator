namespace SnakeLaddersSimulator.Model
{
    public class SimulatorData
    {
        public int TotalRolls { get; set; }
        public int TotalClimbs { get; set; }
        public int TotalSlides { get; set; }        
        public int TotalUnluckyRolls { get; set; }
        public int TotalLuckyRolls { get; set; }
        public int BiggestClimb { get; set; }
        public int BiggestSlide { get; set; }
        public int[] LongestTurn { get; set; }

        public SimulatorData(int totalRolls, int totalClimbs, int totalSlides, int totalUnluckyRolls, int totalLuckyRolls, int biggestClimb, int biggestSlide, int[] longestTurn)
        {
            TotalRolls = totalRolls;
            TotalClimbs = totalClimbs;
            TotalSlides = totalSlides;
            TotalUnluckyRolls = totalUnluckyRolls;
            TotalLuckyRolls = totalLuckyRolls;
            BiggestClimb = biggestClimb;
            BiggestSlide = biggestSlide;
            LongestTurn = longestTurn;
        }
    }
}
