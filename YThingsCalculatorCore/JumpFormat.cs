using System.Text;

namespace YThingsCalculatorCore
{
    public class JumpFormat
    {
        public enum JumpType
        {
            Jump1,
            Jump2
        };
        public JumpType Type { get; set; } = JumpType.Jump1;
        public bool IsJumped { get; set; } = false;
        public List<int> CancelFrameList { get; set; } = [];
        public bool IsFullJump { get { return IsJumped && CancelFrameList.Count == 0; } }
        public bool IsNormalJump { get { return IsJumped && CancelFrameList.Count <= 1; } }
        public bool IsAdvancedJump { get { return IsJumped && CancelFrameList.Count >= 2; } }
        public bool IsJumpCancel { get { return IsAdvancedJump && CancelFrameList[0] == 1; } }
        public bool IsCactus { get { return IsAdvancedJump && CancelFrameList[0] >= 2; } }
        public JumpFormat() { }
        public JumpFormat(string jumpFormatString) { SetFromString(jumpFormatString); }
        public void SetFromString(string jumpFormatString, JumpType jumpType = JumpType.Jump1)
        {
            string[] cancelFrameElementStrings = jumpFormatString.Split('+');
            CancelFrameList.Clear();
            foreach (string i in cancelFrameElementStrings)
            {
                int cancelFrameElement;
                if (int.TryParse(i, out cancelFrameElement))
                {
                    CancelFrameList.Add(cancelFrameElement);
                }
                else
                {
                    IsJumped = false;
                    CancelFrameList.Clear();
                    throw new FormatException($"Invalid format: '{i}' is not a valid integer.");
                }
            }
            IsJumped = true;
            Type = jumpType;
            if (CancelFrameList.Count == 1)
            {
                if ((CancelFrameList[0] == 23 && jumpType == JumpType.Jump1)
                    || (CancelFrameList[0] == 19 && jumpType == JumpType.Jump2))
                {
                    CancelFrameList.Clear();
                }
            }
        }
        public string GetJumpExpression()
        {
            if (!IsJumped)
                return string.Empty;
            if (CancelFrameList.Count == 0)
                return "23f";
            else if (CancelFrameList.Count == 1)
                return $"{CancelFrameList[0]}f";
            StringBuilder sb = new StringBuilder();
            sb.Append($"({CancelFrameList[0]}");
            for (int i = 1; i < CancelFrameList.Count; i++)
                sb.Append($" + {CancelFrameList[i]}");
            sb.Append(")f");
            return sb.ToString();
        }
        public int GetCancelFrameTick(int cancelIndex) // CancelIndex start from 0; Return start from 1
        {
            if (cancelIndex < 0 || cancelIndex >= CancelFrameList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(cancelIndex), cancelIndex, $"'{nameof(cancelIndex)}' cannot be negative");
            }
            int result = 0;
            for (int i = 0; i <= cancelIndex; i++)
                result += CancelFrameList[i];
            return result;
        }
        public int GetTotalDuration()
        {
            if (CancelFrameList.Count == 0)
                return 0;
            return GetCancelFrameTick(CancelFrameList.Count - 1);
        }
    }
}
