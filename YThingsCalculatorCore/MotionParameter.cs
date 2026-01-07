using System;
using System.Collections.Generic;
using System.Text;

namespace YThingsCalculatorCore
{
    internal static class MotionParameter
    {
        public static float Gravity { get; set; } = 0.4f;
        public static float JumpSpeed1 { get; set; } = 8.5f;
        public static float JumpSpeed2 { get; set; } = 7.0f;
        public static float JumpSpeedVine { get; set; } = 9.0f;
        public static float JumpCancelRate { get; set; } = 0.45f;
        // 定义上说应当设置为 9.4f, 但保持原版游戏的比较赋值再加重力的方式以避免可能的浮点数误差
        public static float fallSpeedMax { get; set; } = 9.0f;
    }
}
