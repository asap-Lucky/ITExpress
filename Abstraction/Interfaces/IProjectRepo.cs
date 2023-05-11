using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface IProjectRepo
    {
        List<IProject> GetAllProjects();

        void AddProject(IProject dto);

        void DeleteProject(IProject dto);

        void EditProject(IProject project);
    }
}
