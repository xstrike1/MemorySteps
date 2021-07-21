using MemorySteps.Core.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MemorySteps.Core.Services
{
    public static class FlowLoaderService
    {
        public static string GetCurrentConfig(Flow testConfig)
        {
            return JsonConvert.SerializeObject(testConfig, Formatting.Indented);
        }

        public static void SaveConfig(Flow testConfig)
        {
            string json = GetCurrentConfig(testConfig);

            using SaveFileDialog saveFile = new();
            if(string.IsNullOrEmpty(testConfig.TestName))
                saveFile.FileName = "MemorySteps_Config_" + DateTime.UtcNow.ToString("yyyy-mm-dd");
            else
                saveFile.FileName = testConfig.TestName;

            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "Text documents (.txt)|*.txt";

            if (saveFile.ShowDialog() != DialogResult.OK) 
                return;

            string fileName = saveFile.FileName;

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using FileStream fs = File.Create(fileName);
            byte[] jsonBytes = new UTF8Encoding(true).GetBytes(json);
            fs.Write(jsonBytes, 0, jsonBytes.Length);
        }

        public static Flow LoadConfig()
        {
            string fileContent = string.Empty;

            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\", Filter = "Text documents (.txt)|*.txt", RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                Stream fileStream = openFileDialog.OpenFile();

                using StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
            }

            Flow testConfig = JsonConvert.DeserializeObject<Flow>(fileContent);

            return testConfig;
        }

    }
}
