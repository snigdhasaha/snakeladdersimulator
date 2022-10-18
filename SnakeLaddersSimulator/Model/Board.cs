namespace SnakeLaddersSimulator.Model
{
    public class Board 
    {        
        public List<Cell> Cells { get; set; }
        public List<Ladder> Ladders { get; set; }
        public List<Snake> Snakes { get; set; }
        public Board(List<Cell> cells, List<Ladder> ladders, List<Snake> snakes)
        {
            Cells = cells;
            Ladders = ladders;
            Snakes = snakes;
        }
    }
}
