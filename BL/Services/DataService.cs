using DAL.LinqToSQL;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    //Data Service. Is a facade and singleton
    internal class DataService
    {
        static DataService instance;
        DAL.LinqToSQL.ITExpressDataClassesDataContext _DataContext { get; set; }
        DAL.Repository.CustomerRepo _CustomerRepo { get; set; }
        DAL.Repository.ConsultantRepo _consultantRepo { get; set; }

        protected DataService()
        {
            _DataContext = new DAL.LinqToSQL.ITExpressDataClassesDataContext("Data Source=ucl-jtm-sqlserver.database.windows.net;Initial Catalog=2-sem-gr-1;Persist Security Info=True;User ID=2-sem-gr-1-login;Password=Gr21Pa$$word!");
            _CustomerRepo = new CustomerRepo(_DataContext);
            _consultantRepo = new ConsultantRepo(_DataContext);
        }

        //Initialization. Should be thread-safe
        public static DataService Instance()
        {
            if (instance == null)
            {
                instance = new DataService();
            }
            return instance;
        }

        //Read Methods
        public List<Models.Customer> GetAllCustomers()
        {
            List<Models.Customer> customers = new List<Models.Customer>();
            var customerTable = _CustomerRepo.GetAllCustomer();
            foreach(var dataCustomer in customerTable) 
            {              
                customers.Add(MapCustomer(dataCustomer));
            }
            return customers;
        }

        public List<Models.Consultant> GetAllConsultants()
        {
            List<Models.Consultant> consultants = new List<Models.Consultant>();
            var consultantTable = _consultantRepo.GetAllConsultants();
            foreach(var dataConsultant in consultantTable)
            {
                consultants.Add(MapConsultant(dataConsultant));
            }
            return consultants;
        }

        //Create methods
        public void Save(Models.Customer customer)
        {            
            _CustomerRepo.CreateCustomer(MapCustomer(customer));
        }

        public void Save(Models.Consultant consultant)
        {
            _consultantRepo.CreateConsultant(MapConsultant(consultant));
        }

        //Delete Methods
        public void Delete(Models.Customer customer) 
        { 
            _CustomerRepo.DeleteCustomer(MapCustomer(customer));
        }

        public void Delete(Models.Consultant consultant) 
        {
            _consultantRepo.DeleteConsultant(MapConsultant(consultant));
        }

        //Update Methods
        public void UpdateCustomer(Models.Customer customer)
        {
            _CustomerRepo.UpdateCustomer(MapCustomer(customer));
        }

        public void UpdateConsultant(Models.Consultant consultant)
        {
            _consultantRepo.DeleteConsultant(MapConsultant(consultant));
        }

        //Map Methods

        //Maps LinqToSQL.Customer to Models.Customer
        private Models.Customer MapCustomer(DAL.LinqToSQL.Customer dataCustomer)
        {
            Models.Customer modelCustomer = new Models.Customer(dataCustomer.CustomerId,
                    dataCustomer.Customer_FirstName,
                    dataCustomer.Customer_LastName,
                    dataCustomer.Customer_Login,
                    dataCustomer.Customer_Password,
                    dataCustomer.Customer_Email,
                    dataCustomer.Customer_ZipCodee,
                    dataCustomer.Customer_Address,
                    dataCustomer.Customer_PhoneNumber);
            return modelCustomer;
        }

        //Maps Models.Customer to LingToSQL.Customer
        private DAL.LinqToSQL.Customer MapCustomer(Models.Customer modelCustomer)
        {
            DAL.LinqToSQL.Customer dataCustomer = new DAL.LinqToSQL.Customer() { 
                Customer_FirstName = modelCustomer.FirstName, 
                Customer_LastName = modelCustomer.LastName, 
                Customer_Login = modelCustomer.Login, 
                Customer_Password = modelCustomer.Password, 
                Customer_Email = modelCustomer.Email, 
                Customer_ZipCodee = modelCustomer.ZipCode, 
                Customer_Address = modelCustomer.Address, 
                Customer_PhoneNumber = modelCustomer.PhoneNumber};
            return dataCustomer;
        }

        //Maps LinqToSQL.Consultant to Models.Consultant
        private Models.Consultant MapConsultant(DAL.LinqToSQL.Consultant dataConsultant)
        {
            Models.Consultant modelConsultant = new Models.Consultant(dataConsultant.ConsultantId,
                dataConsultant.Consultant_FirstName,
                dataConsultant.Consultant_LastName,
                dataConsultant.Consultant_Login,
                dataConsultant.Consultant_Password,
                dataConsultant.Consultant_Email,
                dataConsultant.Consultant_ZipDode,
                dataConsultant.Consultant_Address,
                dataConsultant.Consultant_PhoneNumber);
            return modelConsultant;
        }

        //Maps Models.Consultant to LinqToSQL.Consultant
        private DAL.LinqToSQL.Consultant MapConsultant(Models.Consultant modelConsultant)
        {
            DAL.LinqToSQL.Consultant dataConsultant = new DAL.LinqToSQL.Consultant();
            dataConsultant.ConsultantId = modelConsultant.Id;
            dataConsultant.Consultant_FirstName = modelConsultant.FirstName;
            dataConsultant.Consultant_LastName = modelConsultant.LastName;
            dataConsultant.Consultant_Login = modelConsultant.Login;
            dataConsultant.Consultant_Password = modelConsultant.Password;
            dataConsultant.Consultant_Email = modelConsultant.Email;
            dataConsultant.Consultant_ZipDode = modelConsultant.ZipCode;
            dataConsultant.Consultant_Address = modelConsultant.Address;
            dataConsultant.Consultant_PhoneNumber = modelConsultant.PhoneNumber;
            return dataConsultant;
        }
    }
}
