using DAL.LinqToSQL;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ConsultantRepo
    {
        private ITExpressDataClassesDataContext DataContext { get; set; }

        public ConsultantRepo(ITExpressDataClassesDataContext dataContext)
        {
            DataContext = dataContext;
        }

        public Table<Consultant> GetAllConsultants()
        {
            return DataContext.Consultants;
        }

        public void CreateConsultant(Consultant consultant)
        {
            DataContext.Consultants.InsertOnSubmit(consultant);
            DataContext.SubmitChanges();
        }

        public void DeleteConsultant(Consultant consultant)
        {
            DataContext.Consultants.DeleteOnSubmit(consultant);
            DataContext.SubmitChanges();
        }

        public void UpdateConsultant(Consultant consultant)
        {
            Consultant dataConsultant = (from c in DataContext.Consultants
                                         where c.ConsultantId == consultant.ConsultantId
                                         select c).FirstOrDefault();
            if (dataConsultant != null)
            {
                dataConsultant.ConsultantId = consultant.ConsultantId;
                dataConsultant.Consultant_FirstName = consultant.Consultant_FirstName;
                dataConsultant.Consultant_LastName = consultant.Consultant_LastName;
                dataConsultant.Consultant_Login = consultant.Consultant_Login;
                dataConsultant.Consultant_Password = consultant.Consultant_Password;
                dataConsultant.Consultant_Email = consultant.Consultant_Email;
                dataConsultant.Consultant_ZipDode = consultant.Consultant_ZipDode;
                dataConsultant.Consultant_Address = consultant.Consultant_Address;
                dataConsultant.Consultant_PhoneNumber = consultant.Consultant_PhoneNumber;
            }
            DataContext.SubmitChanges();
        }
    }
}
