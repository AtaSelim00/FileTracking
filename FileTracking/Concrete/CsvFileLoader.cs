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
    public class CsvFileLoader : IFileLoader
    {
        public List<TradeData> LoadData(string filePath)
        {
            var tradeDataList = new List<TradeData>();
            if (!File.Exists(filePath))
            {
               
                return tradeDataList;
            }
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var values = line.Split(',');
                var tradeData = new TradeData
                {
                    Date = DateTime.Parse(values[0]),
                    Open = decimal.Parse(values[1]),
                    High = decimal.Parse(values[2]),
                    Low = decimal.Parse(values[3]),
                    Close = decimal.Parse(values[4]),
                    Volume = int.Parse(values[5])
                };
                tradeDataList.Add(tradeData);
            }
            return tradeDataList;
        }
    }

}
