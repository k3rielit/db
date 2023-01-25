using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.MySQL {
    public class MySQLConfig {
        public string SourceConnectionString { get; set; } = "server=127.0.0.1;uid=root;pwd=1234;database=test";
        public string TargetConnectionString { get; set; } = "server=127.0.0.1;uid=root;pwd=1234;database=test_copy";
        public bool AutoCreateDatabase { get; set; } = true;
        public string SourceDatabase { get; set; } = "test";
        public string TargetDatabase { get; set; } = "test_copy";
    }
}
