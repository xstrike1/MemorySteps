using MemorySteps.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MemorySteps.Core.Models
{
    public class Flow : IFlow
    {
        public List<UserAction> UserActionList { get; set; } = new();
        public string TestName { get; set; } = "";
        public int NumberOfClicks => UserActionList.Count;
        public TimeSpan TotalDuration => UserActionList.Count == 0 ? TimeSpan.FromMilliseconds(0) :
            TimeSpan.FromMilliseconds(UserActionList.Sum(cursor => cursor.MilisecondsToNextAction) - UserActionList[^1].MilisecondsToNextAction);
        public int NumberOfCharacters => UserActionList.Sum(cursor => cursor.PressedCharacters.Count);
        public string TestDescription { get; set; } = "";
    }
}
