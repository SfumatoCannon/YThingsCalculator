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
        List<float> YAlignProgressList { get; set; } = [];
        String GetOutputExpression()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Start y: {StartY}\n");
            int size = LeapList.Count;
            for (int i = 0; i < size; i++)
            {
                sb.Append($"{LeapList[i].GetLeapExpression()} → {((double)YAlignProgressList[i]).ToString("R")}\n");
            }
            return sb.ToString();
        }
    }
}
