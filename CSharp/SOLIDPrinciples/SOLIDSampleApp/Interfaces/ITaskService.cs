using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Interfaces
{
    public interface ITaskService
    {
        void CreateTask(string title, string description);
        void UpdateStatus(int taskId, string status);
        void ShowTasks();
    }
}
