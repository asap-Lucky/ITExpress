using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IProjectService
    {
        List<IProject> GetAllProjects();

        List<IProject> GetProjectsByConsultant(int consultantId);

        void AddProject(IProject project);

        void EditProject(IProject project);

        void DeleteProject(IProject project);

        List<IProject> GetProjectsByCostumer(ICustomer customer);
    }
}
