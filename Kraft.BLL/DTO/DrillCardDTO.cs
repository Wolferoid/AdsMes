using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraft.BLL.DTO
{
    public class DrillCardDTO
    {
        public long ID { get; set; }

        public DateTime DateTime { get; set; }

        public int PairNumber { get; set; }

        public string UpperHead { get; set; }

        public string LowerHead { get; set; }

        public int Resource { get; set; }

        public string Manufacter { get; set; }

        public string NewDrill { get; set; }

        public string SharpenDrill { get; set; }

        public string UserName { get; set; }

        public int ShiftNumber { get; set; }
    }
}
