using Gma.System.MouseKeyHook;
using MemoryStepsCore.Models;
using System;
using System.Windows.Forms;

namespace MemoryStepsCore.Services
{
    public sealed class GlobalHookService
    {
        private static readonly Lazy<GlobalHookService> Lazy = new(() => new GlobalHookService());

        public static GlobalHookService Instance => Lazy.Value;

        private GlobalHookService() {}

        public static IKeyboardMouseEvents SubscribeGlobalHook(KeyPressEventHandler keyPressEventHandler = null, MouseEventHandlers mouseEventHandlers = null)
        {
            IKeyboardMouseEvents globalHook = Hook.GlobalEvents();

            if(keyPressEventHandler != null)
                globalHook.KeyPress += keyPressEventHandler;

            if (mouseEventHandlers?.MouseClickEventHandler != null)
                globalHook.MouseClick += mouseEventHandlers.MouseClickEventHandler;
            if (mouseEventHandlers?.MouseDoubleClickEventHandler != null)
                globalHook.MouseDoubleClick += mouseEventHandlers.MouseDoubleClickEventHandler;
            if (mouseEventHandlers?.MouseDragStartedEventHandler != null)
                globalHook.MouseDragStarted += mouseEventHandlers.MouseDragStartedEventHandler;
            if (mouseEventHandlers?.MouseDragFinishedEventHandler != null)
                globalHook.MouseDragFinished += mouseEventHandlers.MouseDragFinishedEventHandler;
            if (mouseEventHandlers?.MouseWheelEventHandler != null)
                globalHook.MouseWheel += mouseEventHandlers.MouseWheelEventHandler;

            return globalHook;
        }

        public static void UnsubscribeGlobalHook(IKeyboardMouseEvents globalHook, KeyPressEventHandler keyPressEventHandler = null, MouseEventHandlers mouseEventHandlers = null)
        {
            if (globalHook == null)
                return;

            if (keyPressEventHandler != null)
                globalHook.KeyPress -= keyPressEventHandler;

            if (mouseEventHandlers?.MouseClickEventHandler != null)
                globalHook.MouseClick -= mouseEventHandlers.MouseClickEventHandler;
            if (mouseEventHandlers?.MouseDoubleClickEventHandler != null)
                globalHook.MouseDoubleClick -= mouseEventHandlers.MouseDoubleClickEventHandler;
            if (mouseEventHandlers?.MouseDragStartedEventHandler != null)
                globalHook.MouseDragStarted -= mouseEventHandlers.MouseDragStartedEventHandler;
            if (mouseEventHandlers?.MouseDragFinishedEventHandler != null)
                globalHook.MouseDragFinished -= mouseEventHandlers.MouseDragFinishedEventHandler;
            if (mouseEventHandlers?.MouseWheelEventHandler != null)
                globalHook.MouseWheel -= mouseEventHandlers.MouseWheelEventHandler;

            globalHook.Dispose();
        }
    }
}
