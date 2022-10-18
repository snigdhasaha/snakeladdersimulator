using SnakeLaddersSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLaddersSimulator
{
    public  class SnakeLadderSimulatorSettings
    {
        public int BoardSize { get; set; }
        public int RunTime { get; set; }
        public List<Snake> Snakes { get; set; }
        public List<Ladder> Ladders { get; set; }
        public string Player { get; set; }
    }
}
