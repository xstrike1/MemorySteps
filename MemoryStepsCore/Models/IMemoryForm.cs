using System;

namespace MemoryStepsCore.Models
{
    public interface IMemoryForm
    {
        void Show();
        void Close();
        void Hide();
        object Invoke(Delegate method);
    }
}
