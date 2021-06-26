using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStepsUI.Models
{
    public class TestConfigEntity
    {
        public List<CursorEntity> CursorList { get; set; } = new();
        public string TestName { get; set; } = "";
        public int NumberOfClicks => CursorList.Count;
        public TimeSpan TotalDuration => TimeSpan.FromMilliseconds(CursorList.Sum(cursor => cursor.Milliseconds) - CursorList[^1].Milliseconds);
        public int NumberOfCharacters => CursorList.Sum(cursor => cursor.PressedCharacters.Count);
        public string TestDescription { get; set; } = "";
    }
}
