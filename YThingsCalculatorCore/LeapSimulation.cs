using System;
using System.Collections.Generic;
using System.Text;

namespace YThingsCalculatorCore
{
    internal class LeapSimulation
    {
        static float GetFrameY(float startY, LeapFormat leap, int frameIndex) { return 0.0f; /*WIP*/}
        static float GetFrameY(float startY, string leapExpression, int frameIndex)
        { return GetFrameY(startY, new LeapFormat(leapExpression), frameIndex); }

    }
}
