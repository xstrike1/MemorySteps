using MemoryStepsUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.Services
{
    public class CursorLoaderService
    {
        public string GetCurrentConfig(TestConfigEntity testConfig) 
        {
            return  JsonConvert.SerializeObject(testConfig, Formatting.Indented);
        }

        public void SaveConfig(TestConfigEntity testConfig)
        {
            string json = GetCurrentConfig(testConfig);

            using SaveFileDialog saveFile = new();
            if(string.IsNullOrEmpty(testConfig.TestName))
                saveFile.FileName = "MemorySteps_Config_" + DateTime.UtcNow.ToString("yyyy-mm-dd");
            else
                saveFile.FileName = testConfig.TestName;

            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "Text documents (.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;

                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using FileStream fs = File.Create(fileName);
                byte[] jsonBytes = new UTF8Encoding(true).GetBytes(json);
                fs.Write(jsonBytes, 0, jsonBytes.Length);
            }
        }

        public TestConfigEntity LoadConfig() 
        {
            TestConfigEntity testConfig = new();
             var fileContent = string.Empty;

            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Text documents (.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;

                var fileStream = openFileDialog.OpenFile();

                using StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
            }

            if (fileContent != null)
            {
                testConfig = JsonConvert.DeserializeObject<TestConfigEntity>(fileContent);
            }

            return testConfig;
        }

    }
}
