using EngineBuilderCalc.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineBuilderCalc.Core.Repository
{
    public class EngineBlockRepository
    {
        public List<EngineBlock> Retrieve()
        {
            List<EngineBlock> blocks = new List<EngineBlock>();
            blocks.Add(new EngineBlock { Bore = 4, Stroke = 4, Cylinders = 8 });
            return blocks;
        }
    }
}
