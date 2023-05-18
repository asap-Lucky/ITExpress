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
                project.Customer = new DAL.Models.Customer() 
                {
                    Id = dto.Customer.CustomerId,

                };
                project.StartDate = dto.Project_StartDate;
                project.EndDate = dto.Project_EndDate;
                project.Status = dto.Project_Status;
                project.Description = dto.Project_Description;




                result.Add(project);
            }
            return result;
        }

        public List<IProject> GetProjectsByConsultant(int consultantId)
        {
            var result = new List<IProject>();

            var consultantProjects = DataContext.Projects.Where(p => p.Project_ConsultantId == consultantId);

            foreach (var dto in consultantProjects)
            {
                Models.Project project = new Models.Project();

                project.Id = dto.ProjectId;
                project.Name = dto.Project_Name;
                project.CustomerId = dto.Project_CustomerId;
                project.StartDate = dto.Project_StartDate;
                project.EndDate = dto.Project_EndDate;
                project.Status = dto.Project_Status;
                project.Description = dto.Project_Description;

                project.Language = new Models.CodeLanguage();
                project.Language.Id = dto.CodeLanguage.Id;
                project.Language.Language = dto.CodeLanguage.LanguageName;

                project.EndType = new Models.EndType();
                project.EndType.Id = dto.EndType.Id;
                project.EndType.EndType1 = dto.EndType.EndType1;

                result.Add(project);
            }
            return result;
        }

        public void AddProject(IProject dto)
        {
            Database.Project projectData = MapToData(dto);            
            DataContext.Projects.InsertOnSubmit(projectData);
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
                targetProject.Project_CustomerId = project.Customer.Id;
                targetProject.Project_ConsultantId = project.Consultant.Id;
                targetProject.Project_StartDate = project.StartDate;
                targetProject.Project_EndDate = project.EndDate;
                targetProject.Project_Status = project.Status;
                targetProject.Project_EndType = project.EndType.Id;
                targetProject.Project_CodeLanguageId = project.Language.Id;

                // Save the changes to the database.
                DataContext.SubmitChanges();
            }
        }

        public List<IProject> GetProjectsByCostumer(ICustomer customer)
        {
            List<IProject> projectModels = new List<IProject>();
            var dataProjects = DataContext.Projects.Where(c => c.Project_CustomerId == customer.Id).ToList();
            foreach(var dataProject in dataProjects)
            {
                projectModels.Add(MapToModel(dataProject));
            }
            return projectModels;
        }

        private IProject MapToModel(Database.Project dataProject)
        {
            IProject projectModel = new Models.Project();
            projectModel.Id = dataProject.ProjectId;
            projectModel.Name = dataProject.Project_Name;
            if(dataProject.Project_TotalSum != null)
            {
                projectModel.TotalSum = (decimal)dataProject.Project_TotalSum;
            }
            projectModel.HourWage = dataProject.Project_HourWage;
            projectModel.StartDate = dataProject.Project_StartDate;
            projectModel.EndDate = dataProject.Project_EndDate;
            projectModel.Description = dataProject.Project_Description;
            if(dataProject.Project_TimeUsed != null)
            {
                projectModel.TimeUsed = (int)dataProject.Project_TimeUsed;
            }
            projectModel.Status = dataProject.Project_Status;
            projectModel.Customer = new Models.Customer() 
            {
                Id = dataProject.Customer.CustomerId,
                FirstName = dataProject.Customer.Customer_FirstName,
                LastName = dataProject.Customer.Customer_LastName,
                Login = dataProject.Customer.Customer_Login,
                Password = dataProject.Customer.Customer_Password,
                Email = dataProject.Customer.Customer_Email,
                ZipCode = dataProject.Customer.Customer_ZipCode,
                City = dataProject.Customer.Customer_City,
                Address = dataProject.Customer.Customer_Address,
                PhoneNumber = dataProject.Customer.Customer_PhoneNumber,                
            };
            

            if(dataProject.Project_ConsultantId != null)
            {
                projectModel.Consultant = (IConsultant)dataProject.Consultant;                
            }
            
            projectModel.Language = new Models.CodeLanguage()
            {
                Id = dataProject.Project_CodeLanguageId,
                Language = dataProject.CodeLanguage.LanguageName
            };
            projectModel.EndType = new Models.EndType();
            if (dataProject.Project_EndType != null)
            {
                projectModel.EndType.Id = (int)dataProject.Project_EndType;
                projectModel.EndType.EndType1 = dataProject.EndType.EndType1;
            }

            return projectModel;
        }

        private Database.Project MapToData(IProject projectModel)
        {
            Database.Project projectData = new Database.Project()
            {
                ProjectId = projectModel.Id,
                Project_Name = projectModel.Name,
                Project_Description = projectModel.Description,
                Project_TotalSum = projectModel.TotalSum,
                Project_HourWage = projectModel.HourWage,
                Project_StartDate = projectModel.StartDate,
                Project_EndDate = projectModel.EndDate,
                Project_TimeUsed = projectModel.TimeUsed,
                Project_Status = projectModel.Status,
                Project_CustomerId = projectModel.Customer.Id,
                Project_ConsultantId = projectModel.Consultant.Id,
                Project_CodeLanguageId = projectModel.Language.Id,
                Project_EndType = projectModel.EndType.Id
            };
            return projectData;
        }
    }
}