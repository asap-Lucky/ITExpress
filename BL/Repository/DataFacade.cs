using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repository
{
    //Facade to interact with the data layer. Is also a singleton.
    internal class DataFacade
    {
        static DataFacade instance;
        DAL.LinqToSQL.ITExpressDataClassesDataContext ITExpressDataContext { get; set; }

        protected DataFacade() 
        {
            ITExpressDataContext = new DAL.LinqToSQL.ITExpressDataClassesDataContext("Data Source=ucl-jtm-sqlserver.database.windows.net;Initial Catalog=2-sem-gr-1;Persist Security Info=True;User ID=2-sem-gr-1-login;Password=Gr21Pa$$word!");
        }

        public static DataFacade Instance()
        {
            if(instance == null)
            {
                instance = new DataFacade();
            }
            return instance;
        }
    }
}
