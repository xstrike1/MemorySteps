using System.Windows.Forms;

namespace MemorySteps.Core.Interfaces
{
    public interface IMouseEventHandlers
    {
        MouseEventHandler MouseClickEventHandler { get; set; }
        MouseEventHandler MouseDoubleClickEventHandler { get; set; }
        MouseEventHandler MouseDragFinishedEventHandler { get; set; }
        MouseEventHandler MouseDragStartedEventHandler { get; set; }
        MouseEventHandler MouseWheelEventHandler { get; set; }
    }
}