using MemorySteps.Core.Models;
using System;
using System.Collections.Generic;

namespace MemorySteps.Core.Interfaces
{
    public interface IFlow
    {
        int NumberOfCharacters { get; }
        int NumberOfClicks { get; }
        string TestDescription { get; set; }
        string TestName { get; set; }
        TimeSpan TotalDuration { get; }
        List<UserAction> UserActionList { get; set; }
    }
}