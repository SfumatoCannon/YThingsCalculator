using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace YThingsCalculatorCore
{
    public class LeapSimulation
    {
        static public float GetFrameY(float startY, LeapFormat leap, int frameIndex) 
        {
            return 0.0f; /*WIP*/
        }
        static public float GetFrameY(float startY, LeapFormat leap, int frameIndex, int blockY1, int blockY2)
        {
            return 0.0f; /*WIP*/
        }
        static public List<float> GetFrameYList(float startY, LeapFormat leap, int endFloorY)
        {
            List<float> frameYList = new List<float>();
            float currentY = startY;
            float currentVspeed = 0.0f;
            void YFrameUpdate()
            {
                currentVspeed += MotionParameter.Gravity;
                currentY += currentVspeed;
                frameYList.Add(currentY);
            }
            frameYList.Add(currentY);
            int jumpCount = leap.JumpCount;
            for (int i = 0; i < jumpCount; i++)
            {
                for (int j = 0; j < leap.JumpPauseList[i] - 1; j++)
                {
                    YFrameUpdate();
                }
                JumpFormat currentJump = leap.JumpDetailList[i];
                if (currentJump.Type == JumpFormat.JumpType.Jump1)
                    currentVspeed = -MotionParameter.JumpSpeed1;
                else
                    currentVspeed = -MotionParameter.JumpSpeed2;
                foreach (int pause in currentJump.CancelFrameList)
                {
                    for (int j = 0; j < pause - 1; j++)
                    {
                        YFrameUpdate();
                    }
                    currentVspeed = currentVspeed * MotionParameter.JumpCancelRate;
                    YFrameUpdate();
                }
            }
            // After all jumps, fall until reaching endFloorY
            while (Math.Round(currentY + MotionParameter.Gravity) <= endFloorY)
            {
                currentVspeed += MotionParameter.Gravity;
                if (Math.Round(currentY + currentVspeed) > endFloorY)
                {
                    currentY += endFloorY - (int)Math.Round(currentY);
                    currentVspeed = 0;
                }
                currentY += currentVspeed;
                frameYList.Add(currentY);
            }
            return frameYList;
        }
        static public List<float> GetFrameYList(float startY, LeapFormat leap, int endFloorY, int blockY1, int blockY2)
        {
            return new List<float>(); // WIP
        }
        static public float GetEndY(float startY, LeapFormat leap, int endFloorY)
        {
            return 0.0f; // WIP
        }
        static public float GetEndY(float startY, LeapFormat leap, int endFloorY, int blockY1, int blockY2)
        {
            return 0.0f; // WIP
        }
    }
}
