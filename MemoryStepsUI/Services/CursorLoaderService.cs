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
        public void SaveConfig(List<CursorEntity> _cursorList)
        {
            string json = JsonConvert.SerializeObject(_cursorList, Formatting.Indented);

            using SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "MemorySteps_Config_" + DateTime.UtcNow.ToString("yyyy-mm-dd");
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
                using (FileStream fs = File.Create(fileName))
                {
                    byte[] jsonBytes = new UTF8Encoding(true).GetBytes(json);
                    fs.Write(jsonBytes, 0, jsonBytes.Length);
                }
            }
        }

        public List<CursorEntity> LoadConfig() 
        {
            List<CursorEntity> cursorList = new List<CursorEntity>();
            var fileContent = string.Empty;

            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Text documents (.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }

            if (fileContent != null)
            {
                cursorList = JsonConvert.DeserializeObject<List<CursorEntity>>(fileContent);
            }

            return cursorList;
        }

    }
}
