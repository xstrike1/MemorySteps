using MaterialSkin;
using MaterialSkin.Controls;

namespace MemoryStepsUI.Services
{
    public static class FormStyleService
    {
        private static readonly ColorScheme ColorScheme = new(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.DeepPurple200, TextShade.WHITE);
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
