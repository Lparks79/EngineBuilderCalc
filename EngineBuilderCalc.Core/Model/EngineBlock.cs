using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineBuilderCalc.Core.Model
{
    public class EngineBlock
    {
        public float Bore { get; set; }
        public float Stroke { get; set; }
        public float CubicInch { get; set; }
        public float CubicCentimeter { get; set; }
        public int Cylinders { get; set; }
    }
}
