using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        public List<Project> GetAllProjects()
        {
            List<Project> list = new List<Project>();
            list.Add(new Project() { ProjectId = 1, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail", Name = "Project 1" });
            list.Add(new Project() { ProjectId = 2, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail2", Name = "Project 2" });
            return list;
        }

        [HttpGet("id:int")]
        public Project GetProject(int id)
        {
            List<Project> list = new List<Project>();
            list.Add(new Project() { ProjectId = 1, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail", Name = "Project 1" });
            list.Add(new Project() { ProjectId = 2, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail2", Name = "Project 2" });
            return list.FirstOrDefault(proj => proj.ProjectId == id);
        }

        [HttpPut]
        public Project UpdateProjectdetails(int id, string name, string details)
        {
            var data = new Project()
            {
                ProjectId = id,
                Name = name,
                Detail = details
            };
            return data;
        }

        [HttpPost]
        public List<Project> CreateProject(Project projectModel)
        {
            List<Project> list = new List<Project>();
            list.Add(new Project() { ProjectId = 1, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail", Name = "Project 1" });
            list.Add(new Project() { ProjectId = 2, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail2", Name = "Project 2" });
            Project st = new Project()
            {
                ProjectId = projectModel.ProjectId,
                Name = projectModel.Name,
                CreatedOn = projectModel.CreatedOn,
                Detail = projectModel.Detail
            };
            list.Add(st);
            return list;
        }

        [HttpDelete]
        public bool DeleteProject(int id)
        {
            List<Project> list = new List<Project>();
            var result = list.FirstOrDefault(a => a.ProjectId == id);
            var deleted = list.Remove(result);
            return deleted; //return true if user with id is deleted otherwise false
        }
    }
}
