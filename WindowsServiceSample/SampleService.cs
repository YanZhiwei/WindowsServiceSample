using System;
using System.IO;
using System.ServiceProcess;

namespace WindowsServiceSample
{
    public partial class SampleService : ServiceBase
    {
        private readonly string _logPath = @"D:\ServiceSample.txt";

        public SampleService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Log("服务启动。");
        }

        private void Log(string content)
        {
            if (!File.Exists(_logPath))
                File.Create(_logPath);
            using (var stream = new FileStream(_logPath, FileMode.Append))
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}{content}");
                }
            }
        }

        protected override void OnStop()
        {
            Log("服务停止。");
        }
    }
}