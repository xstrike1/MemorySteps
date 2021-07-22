using System;

namespace MemorySteps.Core.Interfaces
{
    public interface IMemoryWindow
    {
        void Show();
        void Close();
        void Hide();
        object Invoke(Delegate method);
    }
}
