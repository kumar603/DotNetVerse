using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Interfaces;
using DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVerse.CSharp.SOLIDPrinciples.SOLIDSampleApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;
        private readonly ITaskLogger _logger;

        public TaskService(ITaskRepository repository, ITaskLogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public void CreateTask(string title, string description)
        {
            var task = new TaskItem { Title = title, Description = description };
            _repository.Add(task);
            _logger.Log($"Created Task: {task.Title}");
        }

        public void UpdateStatus(int taskId, string status)
        {
            var task = _repository.Get(taskId);
            if (task != null)
            {
                task.Status = status;
                _repository.Update(task);
                _logger.Log($"Updated Task {task.Id} to status: {status}");
            }
            else
            {
                _logger.Log($"Task with ID {taskId} not found.");
            }
        }

        public void ShowTasks()
        {
            foreach (var task in _repository.GetAll())
            {
                Console.WriteLine($"[{task.Id}] {task.Title} - {task.Status}");
            }
        }
    }
}
