using FileTracking.Abstract;
using FileTracking.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTracking.Concrete
{
    public class FileLoaderService : IFileLoaderService
    {
        private readonly Dictionary<string, IFileLoader> loaders;

        public FileLoaderService()
        {
            loaders = new Dictionary<string, IFileLoader>
            {
                { ".csv", new CsvFileLoader() },
                { ".txt", new TxtFileLoader() },
                { ".xml", new XmlFileLoader() }
            };
        }

        public List<TradeData> LoadData(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            if (loaders.ContainsKey(extension))
            {
                return loaders[extension].LoadData(filePath);
            }

            return new List<TradeData>();
        }
    }
}
