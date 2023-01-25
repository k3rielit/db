using Newtonsoft.Json;

namespace Structural.MySQL {
    public class SMySQL {

        // Variables / Constants
        private const string DefaultConfigPath = @"mysqlconfig.json";
        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        private MySQLConfig Config { get; set; } = new();

        // Constructors
        public SMySQL() { }

        public SMySQL(MySQLConfig config) {
            Config = config;
            SaveConfig();
        }

        public SMySQL(string configPath = DefaultConfigPath) {
            try {
                LoadConfig();
            }
            catch(Exception) {
                SaveConfig();
            }
        }

        // Config IO
        public void SaveConfig(string configPath = DefaultConfigPath) {
            try {
                File.WriteAllText(configPath, JsonConvert.SerializeObject(Config, JsonHelper.Settings));
            }
            catch(Exception) { }
        }

        public void LoadConfig(string configPath = DefaultConfigPath) {
            try {
                Config = JsonConvert.DeserializeObject<MySQLConfig>(File.ReadAllText(configPath), JsonHelper.Settings) ?? new();
            }
            catch(Exception) { }
        }

        // Methods
        public void StartThreads() { }
        public void SuspendThreads() { }
        public void StopThreads() { }
        public static async Task DBThread() { }
    }
}