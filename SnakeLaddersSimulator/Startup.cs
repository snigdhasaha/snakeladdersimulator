using Microsoft.Extensions.Configuration;

namespace SnakeLaddersSimulator
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            snakeLadderSimulatorSettings = config.GetSection("SnakeLadderSimulatorSettings").Get<SnakeLadderSimulatorSettings>();

        }

        public SnakeLadderSimulatorSettings snakeLadderSimulatorSettings { get; private set; }
    }
}
