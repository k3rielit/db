using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.MySQL {
    public class MySQLTableColumns {
        public string Field { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool NullAllowed { get; set; } = true;
        public DBKeyType KeyType { get; set; } = DBKeyType.None;
        public string DefaultValue { get; set; } = "NULL";
        public string Extra { get; set; } = string.Empty;
    }
}
