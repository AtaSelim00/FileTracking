using FileTracking.Abstract;
using FileTracking.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileTracking.Concrete
{
    public class XmlFileLoader : IFileLoader
    {
        public List<TradeData> LoadData(string filePath)
        {
            var tradeDataList = new List<TradeData>();
            if (!File.Exists(filePath))
            {
                return tradeDataList;
            }
            var doc = XDocument.Load(filePath);
            var elements = doc.Descendants("value");

            foreach (var element in elements)
            {
                var tradeData = new TradeData
                {
                    Date = DateTime.Parse(element.Attribute("date").Value),
                    Open = decimal.Parse(element.Attribute("open").Value),
                    High = decimal.Parse(element.Attribute("high").Value),
                    Low = decimal.Parse(element.Attribute("low").Value),
                    Close = decimal.Parse(element.Attribute("close").Value),
                    Volume = int.Parse(element.Attribute("volume").Value)
                };
                tradeDataList.Add(tradeData);
            }
            return tradeDataList;
        }
    }

}
