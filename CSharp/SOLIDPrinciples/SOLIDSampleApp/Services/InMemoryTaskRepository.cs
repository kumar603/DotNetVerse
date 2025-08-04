using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Interfaces;
using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Services
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private readonly List<TaskItem> _tasks = new List<TaskItem>();
        private int _idCounter = 1;

        public void Add(TaskItem task)
        {
            task.Id = _idCounter++;
            _tasks.Add(task);
        }

        public TaskItem Get(int id) => _tasks.FirstOrDefault(t => t.Id == id);

        public List<TaskItem> GetAll() => _tasks;

        public void Update(TaskItem task)
        {
            var index = _tasks.FindIndex(t => t.Id == task.Id);
            if (index >= 0)
                _tasks[index] = task;
        }
    }
}
