using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Interfaces
{
    public interface ITaskRepository
    {
        void Add(TaskItem task);
        TaskItem Get(int id);
        List<TaskItem> GetAll();
        void Update(TaskItem task);
    }
}
