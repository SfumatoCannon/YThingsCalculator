using System;
using System.Collections.Generic;
using System.Text;

namespace YThingsCalculatorCore
{
    public class InputFormatYAlignAdjust
    {
        float StartY { get; set; }
        float TargetYRangeLeft { get; set; }
        float TargetYRangeRight { get; set; }

        enum HeightLimitType
        {
            Null,
            Solid,
            Deadly
        };
        HeightLimitType HeightLimit { get; set; }

        enum SearchStrategyType
        {
            Easiest,
            Fastest
        };
        SearchStrategyType SearchStrategy { get; set; }

        bool CanCactus { get; set; } // 定义仙人掌跳为 "第一次取消为非一帧跳的多重取消跳跃"
        bool CanJumpCancel { get; set; } // 定义JC跳为 "第一次取消为一帧跳的多重取消跳跃"
        bool IsPlatformLanding { get; set; }
        bool CanDoubleJump { get; set; }
        bool CanBunnyHop { get; set; }
    }
}
