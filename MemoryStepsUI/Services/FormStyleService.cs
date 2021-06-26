using MaterialSkin;
using MaterialSkin.Controls;
using MemoryStepsCore.Models;

namespace MemoryStepsUI.Services
{
    public static class FormStyleService
    {
        private static readonly ColorScheme ColorScheme = new(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        public static void InitMaterialSkin(MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = ColorScheme;
            form.Icon = Properties.Resources.logo;
        }
    }
}
