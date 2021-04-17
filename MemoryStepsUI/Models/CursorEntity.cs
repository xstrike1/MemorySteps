using Microsoft.Test.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.Models
{
    public class CursorEntity
    {
        public Point Position { get; set; }

        [NonSerialized]
        public Stopwatch Time;

        public long Milliseconds; 
       
        public Dictionary<long, char> PressedCharacters { get; set; }
        public MouseButton ButtonPressed { get; set; }

        public CursorEntity() 
        {
            Time = new Stopwatch();
            Time.Start();
            PressedCharacters = new Dictionary<long, char>();
        }

        public CursorEntity(Point position) 
            : this()
        {
            Position = position;
        }

        public CursorEntity(Point position, MouseButton buttonPressed)
           : this(position)
        {
            ButtonPressed = buttonPressed;
        }
    }
}
