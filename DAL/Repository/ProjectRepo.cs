using Abstraction.Interfaces;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProjectRepo : IProjectRepo
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public ProjectRepo()
        {
            DataContext = new ITExpressDataClassesDataContext();
        }

        public List<IProject> GetAllProjects()
        {
            var result = new List<IProject>();

            var AllDtoItem = DataContext.Projects;

            foreach (var dto in AllDtoItem)
            {
                Models.Project project = new Models.Project();

                project.Id = dto.ProjectId;
                project.Name = dto.Project_Name;
                project.CustomerId = dto.Project_CustomerId;
                project.ConsultantId = dto.Project_ConsultantId;
                project.StartDate = dto.Project_StartDate;
                project.EndDate = dto.Project_EndDate;
                project.Status = dto.Project_Status;

                result.Add(project);
            }
            return result;
        }

        public void AddProject(IProject dto)
        {
            var project = new Database.Project()
            {
                ProjectId = dto.Id,
                Project_Name = dto.Name,
                Project_CustomerId = dto.CustomerId,
                Project_ConsultantId = dto.ConsultantId,
                Project_StartDate = dto.StartDate,
                Project_EndDate = dto.EndDate,
                Project_Status = dto.Status
            };
            DataContext.Projects.InsertOnSubmit(project);
            DataContext.SubmitChanges();
        }

        public void DeleteProject(IProject dto)
        {
            var targetProject = DataContext.Projects.FirstOrDefault(i => i.ProjectId == dto.Id);

            DataContext.Projects.DeleteOnSubmit(targetProject);

            DataContext.SubmitChanges();
        }

        public void EditProject(IProject project)
        {
            var targetProject = DataContext.Projects.FirstOrDefault(p => p.ProjectId == project.Id);
            if (targetProject != null)
            {
                // Update the Project object with the new values.
                targetProject.Project_Name = project.Name;
                targetProject.Project_CustomerId = project.CustomerId;
                targetProject.Project_ConsultantId = project.ConsultantId;
                targetProject.Project_StartDate = project.StartDate;
                targetProject.Project_EndDate = project.EndDate;
                targetProject.Project_Status = project.Status;

                // Save the changes to the database.
                DataContext.SubmitChanges();
            }
        }
    }
}