using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FlaUI.Core.Definitions;
using MaterialSkin;
using MemoryStepsUI.Models;
using Newtonsoft.Json;

namespace MemoryStepsUI.Models
{
    public static class AppConfig
    {
        private static string _theme = "LIGHT";

        public static MaterialSkinManager.Themes Theme => _theme.ToUpper() == "LIGHT" ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        public static char KeyBind { get; private set; } = '`';

        public static int MaxActionDelay { get; private set; } = 5000;
        public static List<string> UndefinedControlTypes { get; } = new();
        public const string Undefined = "UNDEFINED";

        static AppConfig()
        {
            InitAppConfig();
        }

        private static void InitAppConfig()
        {
            try
            {
                dynamic config = JsonConvert.DeserializeObject(File.ReadAllText("Config\\appSettings.json"));
                if(config == null) return;

                _theme = config.Theme;
                KeyBind = config.KeyBind;
                MaxActionDelay = config.MaxActionDelay;
                var undefinedControlTypes = config.UndefinedControlTypes;
                foreach (var controlType in undefinedControlTypes)
                {
                    UndefinedControlTypes.Add(controlType.ToString());
                }
            }
            catch
            {
              //TODO Config file not found
            }
        }
    }
}
