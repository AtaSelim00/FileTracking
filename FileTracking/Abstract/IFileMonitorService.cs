using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTracking.Abstract
{
    public interface IFileMonitorService
    {
        void StartMonitoring();
        void StopMonitoring();
        void SetPath(string path);
        void IncludeSubdirectories(bool include);
        string LastEventFileName { get; set; }
        bool isFileDeleted { get; set; }
    }
}
