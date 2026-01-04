using System;
using System.Collections.Generic;
using System.Text;

namespace YThingsCalculatorCore
{
    internal class LeapSimulation
    {
        static float GetFrameY(float startY, LeapFormat leap, int frameIndex) 
        {
            return 0.0f; /*WIP*/
        }
        static float GetFrameY(float startY, LeapFormat leap, int frameIndex, int blockY1, int blockY2)
        {
            return 0.0f; /*WIP*/
        }
        static List<float> GetFrameYList(float startY, LeapFormat leap, int endFloorY)
        {
            List<float> frameYList = new List<float>();
            float currentY = startY;
            float currentVspeed = 0.0f;
            frameYList.Add(currentY);
            int jumpCount = leap.JumpCount;
            for (int i = 0; i < jumpCount; i++)
            {
                for (int j = 0; j < leap.JumpPauseList[i] - 1; j++)
                {
                    currentVspeed += MotionParameter.Gravity;
                    currentY += currentVspeed;
                    frameYList.Add(currentY);
                }
                JumpFormat currentJump = leap.JumpDetailList[i];
                if (currentJump.Type == JumpFormat.JumpType.Jump1)
                    currentVspeed = -MotionParameter.JumpSpeed1;
                else
                    currentVspeed = -MotionParameter.JumpSpeed2;
                // WIP
            }
            return frameYList;
        }
        static List<float> GetFrameYList(float startY, LeapFormat leap, int endFloorY, int blockY1, int blockY2)
        {
            return new List<float>(); // WIP
        }
        static float GetEndY(float startY, LeapFormat leap, int endFloorY)
        {
            return 0.0f; // WIP
        }
        static float GetEndY(float startY, LeapFormat leap, int endFloorY, int blockY1, int blockY2)
        {
            return 0.0f; // WIP
        }
    }
}
