using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInspection
{
    internal class Pc
    {
        public int id = 0;
        public string cpuType = "";
        public int ram = 0;
        public string gpu = "";
        public bool isGaming = false;

        public Pc ( int id, string cpuType, int ram, string gpu, bool isGaming )
        {
            this.id = id;
            this.cpuType = cpuType;
            this.ram = ram;
            this.gpu = gpu;
            this.isGaming = isGaming;
        }
    }
}
