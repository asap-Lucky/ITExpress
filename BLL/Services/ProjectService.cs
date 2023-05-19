using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProjectService : IProjectService
    {
        IProjectRepo _ProjectRepo;

        public ProjectService()
        {
            _ProjectRepo = new DAL.Repository.ProjectRepo();
        }

        public List<IProject> GetProjectsByConsultant(int consultantId)
        {
            return _ProjectRepo.GetProjectsByConsultant(consultantId);
        }

        public void AddProject(IProject project)
        {
            _ProjectRepo.AddProject(project);
        }

        public void DeleteProject(IProject project)
        {
            _ProjectRepo.DeleteProject(project);
        }

        public List<IProject> GetAllProjects()
        {
            return _ProjectRepo.GetAllProjects();
        }

        public void EditProject(IProject project)
        {
            _ProjectRepo.EditProject(project);
        }

        public List<IProject> GetProjectsByCostumer(ICustomer customer)
        {
            return _ProjectRepo.GetProjectsByCostumer(customer);
        }
        public IProject GetProject(int id)
        {
            return _ProjectRepo.GetProject(id);
        }

    }
}
