using FileTracking.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTracking.Concrete
{
    public class FileMonitorService : IFileMonitorService
    {
        private readonly IFileLoaderService fileLoaderService;
        private readonly Action<string> onChangeAction;
        FileSystemWatcher fileMon;
        public  bool isFileDeleted { get;  set; }
        public string LastEventFileName { get;  set; }

        public FileMonitorService(IFileLoaderService fileLoaderService, Action<string> onChangeAction, FileSystemWatcher _fileMon)
        {
            this.fileLoaderService = fileLoaderService;
            this.onChangeAction = onChangeAction;
            fileMon = _fileMon;
            fileMon.Changed += FileMon_Changed;
            fileMon.Created += FileMon_Created;
            fileMon.Deleted += FileMon_Deleted;
            fileMon.Renamed += FileMon_Renamed;
        }

        public void StartMonitoring()
        {
            fileMon.EnableRaisingEvents = true;
        }

        public void StopMonitoring()
        {
            fileMon.EnableRaisingEvents = false;
        }

        public void SetPath(string path)
        {
            fileMon.Path = path;
        }

        public void IncludeSubdirectories(bool include)
        {
            fileMon.IncludeSubdirectories = include;
        }

        private void FileMon_Changed(object sender, FileSystemEventArgs e)
        {

            RecordChange(e);
        }

        private void FileMon_Created(object sender, FileSystemEventArgs e)
        {
            RecordChange(e);
        }

        private void FileMon_Deleted(object sender, FileSystemEventArgs e)
        {
            isFileDeleted = true;
            RecordChange(e);
        }

        private void FileMon_Renamed(object sender, RenamedEventArgs e)
        {
            RecordChange(e);
        }

        private void RecordChange(FileSystemEventArgs e)
        {
            string change = $"{e.ChangeType}: {e.FullPath}";
            onChangeAction(change);
            LastEventFileName = e.FullPath;
        }
    }
}
