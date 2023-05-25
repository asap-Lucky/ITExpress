using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Facader
{
    /// <summary>
    /// Djoan
    /// </summary>
    public class ProjectService
    {
        //Create an Interface of type IProjectService
        public IProjectService projectService { get; set; }

        // Create an interface of type IProject
        public Abstraction.Interfaces.IProject MyProject { get; set; }
        //Uses ProjectService and IProjectService to create a new instance of projectservice

        public ProjectService(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        public List<IProject> GetAllProjects()
        {
            return projectService.GetAllProjects();
        }

        public void EditProjectStatus(int id, int status)
        {
            MyProject = projectService.GetProject(id);

            MyProject.Status = status;

            projectService.EditProject(MyProject);
        }

        public IProject GetProject(int id)
        {
            return projectService.GetProject(id);
        }
    }
}
