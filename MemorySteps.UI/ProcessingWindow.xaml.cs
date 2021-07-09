using Gma.System.MouseKeyHook;
using MemorySteps.Core.Config;
using MemorySteps.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MemorySteps.UI
{
    /// <summary>
    /// Interaction logic for ProcessingWindow.xaml
    /// </summary>
    public partial class ProcessingWindow : Window
    {
        private IKeyboardMouseEvents _globalHook;
        public ProcessingWindow()
        {
            InitializeComponent();
            Subscribe();
            System.Drawing.Rectangle res = Screen.PrimaryScreen.Bounds;
            Left = res.Width - Width;
            Top = res.Height - Height;
            Topmost = true;
        }

        private void Subscribe()
        {
            _globalHook = GlobalHookService.SubscribeGlobalHook(GlobalHookKeyPress);
        }

        private void Unsubscribe()
        {
            GlobalHookService.UnsubscribeGlobalHook(_globalHook, GlobalHookKeyPress);
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != AppConfig.Config.KeyBind)
                return;

            Unsubscribe();
            e.Handled = true;
            Hide();
        }
    }
}
