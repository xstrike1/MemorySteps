using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryStepsCore.Models
{
    public class TestConfigEntity
    {
        public List<CursorEntity> CursorList { get; set; } = new();
        public string TestName { get; set; } = "";
        public int NumberOfClicks => CursorList.Count;
        public TimeSpan TotalDuration => TimeSpan.FromMilliseconds(CursorList.Sum(cursor => cursor.MilisecondsToNextCursor) - CursorList[^1].MilisecondsToNextCursor);
        public int NumberOfCharacters => CursorList.Sum(cursor => cursor.PressedCharacters.Count);
        public string TestDescription { get; set; } = "";
    }
}
