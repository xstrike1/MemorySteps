using System;

namespace MemorySteps.Core.Models
{
    public interface IMemoryForm
    {
        void Show();
        void Close();
        void Hide();
        object Invoke(Delegate method);
    }
}
