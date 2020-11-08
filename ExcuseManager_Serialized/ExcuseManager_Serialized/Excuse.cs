using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcuseManager
{
    [Serializable]
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }
        public Excuse() { ExcusePath = ""; }
        public Excuse(string excusePath) { OpenFile(excusePath); }
        public Excuse(Random random, string folder) 
        {
            string[] fileNames = Directory.GetFiles(folder, "*.dat");
            try 
            { 
                OpenFile(fileNames[random.Next(fileNames.Length)]); 
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No excuse files exist");
                LastUsed = DateTime.Now;
            }
            
        }
        public void OpenFile(string excusePath)
        {
            try
            {
                this.ExcusePath = excusePath;
                BinaryFormatter formatter = new BinaryFormatter();
                Excuse tempExcuse;
                using (Stream input = File.OpenRead(excusePath))
                {
                    tempExcuse = (Excuse)formatter.Deserialize(input);
                }
                Description = tempExcuse.Description;
                Results = tempExcuse.Results;
                LastUsed = tempExcuse.LastUsed;
            }
            catch (SerializationException)
            {
                MessageBox.Show("Unable to read " + excusePath);
                LastUsed = DateTime.Now;
            }
        }
        public void Save(string fileName) 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream output = File.OpenWrite(fileName))
            {
                formatter.Serialize(output, this);
            }
        }
    }
}
