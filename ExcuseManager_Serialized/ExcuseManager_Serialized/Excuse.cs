using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }
        public void OpenFile(string excusePath)
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
        public void Save(string fileName) 
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }
    }
}
