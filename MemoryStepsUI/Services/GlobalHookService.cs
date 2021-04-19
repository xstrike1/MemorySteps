using Gma.System.MouseKeyHook;
using System;
using System.Windows.Forms;

namespace MemoryStepsUI.Services
{
    public sealed class GlobalHookService
    {
        private static readonly Lazy<GlobalHookService> Lazy = new(() => new GlobalHookService());

        public static GlobalHookService Instance => Lazy.Value;

        private GlobalHookService() {}

        public IKeyboardMouseEvents SubscribeGlobalHook(KeyPressEventHandler keyPressEventHandler = null, MouseEventHandler mouseEventHandler = null) 
        {
            IKeyboardMouseEvents globalHook = Hook.GlobalEvents();

            if(keyPressEventHandler != null)
                globalHook.KeyPress += keyPressEventHandler;

            if (mouseEventHandler != null)
                globalHook.MouseClick += mouseEventHandler;

            return globalHook;
        }

        public void UnsubscribeGlobalHook(IKeyboardMouseEvents globalHook, KeyPressEventHandler keyPressEventHandler = null, MouseEventHandler mouseEventHandler = null) 
        {
            if (globalHook == null)
                return;

            if (keyPressEventHandler != null)
                globalHook.KeyPress -= keyPressEventHandler;

            if (mouseEventHandler != null)
                globalHook.MouseClick -= mouseEventHandler;

            globalHook.Dispose();
        }
    }
}
