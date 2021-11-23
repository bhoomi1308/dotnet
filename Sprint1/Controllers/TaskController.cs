using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public List<TaskModel> GetAllTasks()
        {
            List<TaskModel> list = new List<TaskModel>();
            list.Add(new TaskModel() { TaskId = 1, AssignedUserId = 1, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail", ProjectId = 1, Status = 1 });
            list.Add(new TaskModel() { TaskId = 2, AssignedUserId = 2, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail2", ProjectId = 2, Status = 2 });
            return list;
        }

        [HttpGet("id:int")]
        public TaskModel GetTask(int id)
        {
            List<TaskModel> list = new List<TaskModel>();
            list.Add(new TaskModel() { TaskId = 1, AssignedUserId = 1, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail", ProjectId = 1, Status = 1 });
            list.Add(new TaskModel() { TaskId = 2, AssignedUserId = 2, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail2", ProjectId = 2, Status = 2 });
            return list.FirstOrDefault(user => user.TaskId == id);
        }

        [HttpPut]
        public TaskModel UpdateTaskdetails(int id, int assignedId, string details)
        {
            var data = new TaskModel()
            {
                TaskId = id,
                AssignedUserId = assignedId,
                Detail = details
            };
            return data;
        }

        [HttpPost]
        public List<TaskModel> CreateTask(TaskModel taskModel)
        {
            List<TaskModel> list = new List<TaskModel>();
            list.Add(new TaskModel() { TaskId = 1, AssignedUserId = 1, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail", ProjectId = 1, Status = 1 });
            list.Add(new TaskModel() { TaskId = 2, AssignedUserId = 2, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail2", ProjectId = 2, Status = 2 });
            TaskModel st = new TaskModel()
            {
                TaskId = taskModel.TaskId,
                ProjectId = taskModel.ProjectId,
                AssignedUserId = taskModel.AssignedUserId,
                CreatedOn = taskModel.CreatedOn,
                Detail = taskModel.Detail,
                Status = taskModel.Status
            };
            list.Add(st);

            return list;
        }

        [HttpDelete]
        public bool DeleteTask(int id)
        {
            List<TaskModel> list = new List<TaskModel>();
            var result = list.FirstOrDefault(a => a.TaskId == id);
            var deleted = list.Remove(result);
            return deleted; //return true if user with id is deleted otherwise false
        }
    }
}
