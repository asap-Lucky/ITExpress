using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class SQLCustomerRepository
    {
        string connectionString = "Data Source=ucl-jtm-sqlserver.database.windows.net;Initial Catalog=2-sem-gr-1;Persist Security Info=True;User ID=2-sem-gr-1-login;Password=Gr21Pa$$word!";
        SqlConnection Connection { get; set; }

        public SQLCustomerRepository()
        {
            Connection = new SqlConnection(connectionString);
        }

        public List<ICustomer> GetAllCustomers()
        {
            DataTable customerTable = new DataTable();
            using (Connection)
            {
                string query = "SELECT * ALL FROM Customer";
                SqlCommand command = new SqlCommand(query, Connection);

                Connection.Open();

                using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(customerTable);
                }
                Connection.Close();
            }
            return MapToModels(customerTable);
        }

        public void AddCustomer(ICustomer customer)
        {
            string query = "INSERT INTO Customer (Customer_FirstName, " +
                "Customer_LastName, " +
                "Customer_Login, " +
                "Customer_Password, " +
                "Customer_Email, " +
                "Customer_ZipCode, " +
                "Customer_City," +
                "Customer_Address, " +
                "Customer_PhoneNumber) " +
                "VALUES " +
                "(@Customer_FirstName, " +
                "@Customer_LastName, " +
                "@Customer_Login, " +
                "@Customer_Password, " +
                "@Customer_Email, " +
                "@Customer_Zipcode, " +
                "@Customer_City, " +
                "@Customer_Address, " +
                "@Customer_PhoneNumber)";
            using (Connection)
            {
                SqlCommand sqlCommand = new SqlCommand(query, Connection);
                sqlCommand = MapToCommand(sqlCommand, customer);
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
                Connection.Close();
            }
        }

        public void EditCustomer(ICustomer customer)
        {
            using (Connection)
            {
                string query = "UPDATE Customer SET " +
                    "Customer_FirstName = @Customer_FirstName," +
                    "Customer_LastName = @Customer_LastName," +
                    "Customer_Login = @Customer_Login," +
                    "Customer_Password = @Customer_Password," +
                    "Customer_Email = @Customer_Email," +
                    "Customer_ZipCode = Customer_ZipCode," +
                    "Customer_City = @Customer_City," +
                    "Customer_Address = @Customer_Address," +
                    "Customer_PhoneNumber = @Customer_PhoneNumber " +
                    "WHERE CustomerId = @CustomerId";

                SqlCommand command = new SqlCommand(query, Connection);
                command = MapToCommand(command, customer);

                Connection.Open();
                command.ExecuteNonQuery();
                Connection.Close();
            }
        }

        public void DeleteCustomer(ICustomer customer)
        {
            using (Connection)
            {
                string query = "DELETE FROM Customer WHERE CustomerId = @CustomerId";

                SqlCommand command = MapToCommand(new SqlCommand(query,Connection), customer);

                Connection.Open();
                command.ExecuteNonQuery();
                Connection.Close();
            }
        }

        public bool IsValidCustomer(string login, string password)
        {
            bool isValid = false;
            DataTable customerTable = new DataTable();
            using (Connection)
            {
                string query = "SELECT * FROM Customer WHERE Customer_Login = @Customer_Login AND Customer_Password = @Customer_Password";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Customer_Login", login);
                command.Parameters.AddWithValue("@Customer_Password", password);

                Connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(customerTable);
                }
                Connection.Close();
            }
            List<ICustomer> customerModels = MapToModels(customerTable);

            if(customerModels.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }

        public ICustomer GetCustomer(int id)
        {
            DataTable customerTable = new DataTable();
            using (Connection)
            {
                string query = "SELECT * FROM Customer WHERE CustomerId = @CustomerId";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@CustomerId", id);
                Connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(customerTable);
                }
                Connection.Close();
            }
            ICustomer customerModel = MapToModels(customerTable).FirstOrDefault(c => c.Id == id);
            return customerModel;
        }

        public ICustomer GetCustomer(string login, string password)
        {
            DataTable customerTable = new DataTable();
            using (Connection)
            {
                string query = "SELECT * FROM Customer WHERE Customer_Login = @Customer_Login and Customer_Password = @Customer_Password";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@Customer_Login", login);
                command.Parameters.AddWithValue("@Customer_Password", password);

                Connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(customerTable);
                }
                Connection.Close();
            }
            ICustomer customerModel = MapToModels(customerTable).FirstOrDefault(c => c.Login == login && c.Password == password);
            return customerModel;
        }

        private List<ICustomer> MapToModels(DataTable customerTable)
        {
            List<ICustomer> customerModels = new List<ICustomer> ();

            foreach(DataRow row in customerTable.Rows)
            {
                ICustomer customerModel = new Models.Customer(); 
                customerModel.Id = Convert.ToInt32(row["CustomerId"]);
                customerModel.FirstName = row["Customer_FirstName"].ToString();
                customerModel.LastName = row["Customer_LastName"].ToString();
                customerModel.Login = row["Customer_Login"].ToString();
                customerModel.Password = row["Customer_Password"].ToString();
                customerModel.Email = row["Customer_Email"].ToString();
                customerModel.ZipCode = Convert.ToInt32(row["Customer_ZipCode"]);
                customerModel.City = row["Customer_City"].ToString();
                customerModel.Address = row["Customer_Address"].ToString();
                customerModel.PhoneNumber = Convert.ToInt32(row["Customer_PhoneNumber"]);
                customerModels.Add(customerModel);
            }
            return customerModels;
        }
        private SqlCommand MapToCommand(SqlCommand command, ICustomer customer)
        {
            command.Parameters.AddWithValue("@CustomerId",customer.Id);
            command.Parameters.AddWithValue("@Customer_FirstName", customer.FirstName);
            command.Parameters.AddWithValue("@Customer_LastName", customer.LastName);
            command.Parameters.AddWithValue("@Customer_Login", customer.Login);
            command.Parameters.AddWithValue("@Customer_Password", customer.Password);
            command.Parameters.AddWithValue("@Customer_Email", customer.Email);
            command.Parameters.AddWithValue("@Customer_ZipCode", customer.ZipCode);
            command.Parameters.AddWithValue("@Customer_City",customer.City);
            command.Parameters.AddWithValue("@Customer_Address", customer.Address);
            command.Parameters.AddWithValue("@Customer_PhoneNumber", customer.PhoneNumber);
            return command;
        }
    }
}
