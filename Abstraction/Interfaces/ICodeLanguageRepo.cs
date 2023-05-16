using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interfaces
{
    public interface ICodeLanguageRepo
    {
        List<ICodeLanguage> GetAllCodeLanguages();

        void AddCodeLanguage(ICodeLanguage dto);

        void DeleteCodeLanguage(ICodeLanguage dto);

        void EditCodeLanguage(ICodeLanguage dto);

        ICodeLanguage GetCodeLanguage(ICodeLanguage codeLanguage);
    }
}
