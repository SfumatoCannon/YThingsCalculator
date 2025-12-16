using System;
using System.Collections.Generic;
using System.Text;

namespace YThingsCalculatorCore
{
    public class OutputFormatYAlignAdjust
    {
        int Id { get; set; }
        float StartY { get; set; }
        float EndY { get; set; }
        List<LeapFormat> LeapList { get; set; } = [];
        List<float> YProgressList { get; set; } = [];
    }
}
