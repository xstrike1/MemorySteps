using Gma.System.MouseKeyHook;
using System;
using System.Windows.Forms;

namespace MemoryStepsCore.Services
{
    public sealed class GlobalHookService
    {
        private static readonly Lazy<GlobalHookService> Lazy = new(() => new GlobalHookService());

        public static GlobalHookService Instance => Lazy.Value;

        private GlobalHookService() {}

        public IKeyboardMouseEvents SubscribeGlobalHook(KeyPressEventHandler keyPressEventHandler = null, MouseEventHandler mouseEventHandler = null, MouseEventHandler mouseDoubleClick = null) 
        {
            IKeyboardMouseEvents globalHook = Hook.GlobalEvents();

            if(keyPressEventHandler != null)
                globalHook.KeyPress += keyPressEventHandler;

            if (mouseEventHandler != null) 
                globalHook.MouseClick += mouseEventHandler;

            if (mouseDoubleClick != null)
                globalHook.MouseDoubleClick += mouseDoubleClick;

            return globalHook;
        }

        public void UnsubscribeGlobalHook(IKeyboardMouseEvents globalHook, KeyPressEventHandler keyPressEventHandler = null, MouseEventHandler mouseEventHandler = null, MouseEventHandler m2 = null) 
        {
            if (globalHook == null)
                return;

            if (keyPressEventHandler != null)
                globalHook.KeyPress -= keyPressEventHandler;

            if (mouseEventHandler != null)
                globalHook.MouseClick -= mouseEventHandler;

            if (m2 != null)
                globalHook.MouseDoubleClick -= m2;

            globalHook.Dispose();
        }
    }
}
