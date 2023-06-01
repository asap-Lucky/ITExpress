using Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SQLCodeLanguageRepository
    {
        string ConnectionString { get; set; }
        SqlConnection Connection { get; set; }

        public SQLCodeLanguageRepository()
        {
            ConnectionString = "Data Source=ucl-jtm-sqlserver.database.windows.net;Initial Catalog=2-sem-gr-1;Persist Security Info=True;User ID=2-sem-gr-1-login;Password=Gr21Pa$$word!";
        }

        public void AddCodeLanguage(ICodeLanguage codeLanguage)
        {
            string query = "INSERT INTO CodeLanguage (LanguageName) VALUES (@LanguageName)";
            using (Connection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, Connection);
                sqlCommand.Parameters.AddWithValue("@LanguageName", codeLanguage.Language);

                Connection.Open();
                sqlCommand.ExecuteNonQuery();
                Connection.Close();
            }
        }

        public void DeleteCodeLanguage(ICodeLanguage language)
        {
            string query = "DELETE FROM CodeLanguage WHERE Id = @Id";
            using (Connection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, Connection);
                sqlCommand.Parameters.AddWithValue("@Id", language.Id);
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
                Connection.Close();
            }
        }

        public void EditCodeLanguage(ICodeLanguage dto)
        {
            string query = "UPDATE CodeLanguage SET LanguageName = @LanguageName WHERE Id = @Id";
            using (Connection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, Connection);
                sqlCommand.Parameters.AddWithValue("@Id", dto.Id);
                sqlCommand.Parameters.AddWithValue("@LanguageName", dto.Language);
                Connection.Open();
                sqlCommand.ExecuteNonQuery();
                Connection.Close();
            }
        }

        public List<ICodeLanguage> GetAllCodeLanguages()
        {
            List<ICodeLanguage> languageModels = new List<ICodeLanguage>();
            DataTable languageTable = new DataTable();
            string query = "SELECT * FROM CodeLanguage";

            using (Connection = new SqlConnection(ConnectionString)) 
            {
                SqlCommand sqlCommand = new SqlCommand(query, Connection);
                Connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.Fill(languageTable);
                }
                Connection.Close();
            }
            foreach(DataRow row in languageTable.Rows)
            {
                ICodeLanguage codeLanguage = new Models.CodeLanguage();
                codeLanguage.Id = Convert.ToInt32(row["Id"]);
                codeLanguage.Language = row["LanguageName"].ToString();
                languageModels.Add(codeLanguage);
            }
            return languageModels;
        }

        public ICodeLanguage GetCodeLanguage(ICodeLanguage language)
        {
            ICodeLanguage languageCode = new Models.CodeLanguage();
            DataTable languageTable = new DataTable();
            string query = "SELECT * FROM CodeLangauge WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@Id", language.Id);
            using (Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.Fill(languageTable);
                }
                Connection.Close();
            }
            foreach (DataRow row in languageTable.Rows)
            {
                language.Id = Convert.ToInt32(row["Id"]);
                language.Language = row["LanguageName"].ToString();
            }
            return languageCode;
        }
    }
}
