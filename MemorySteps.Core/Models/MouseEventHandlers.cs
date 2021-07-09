using System.Windows.Forms;

namespace MemorySteps.Core.Models
{
    public class MouseEventHandlers
    {
        public MouseEventHandler MouseClickEventHandler { get; set; }
        public MouseEventHandler MouseDoubleClickEventHandler { get; set; }
        public MouseEventHandler MouseDragStartedEventHandler{ get; set; }
        public MouseEventHandler MouseDragFinishedEventHandler { get; set; }
        public MouseEventHandler MouseWheelEventHandler { get; set; }
    }
}
