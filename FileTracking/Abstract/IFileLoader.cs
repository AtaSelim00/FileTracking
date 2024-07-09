using FileTracking.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTracking.Abstract
{
    public interface IFileLoader
    {
        List<TradeData> LoadData(string filePath);
    }

}
    