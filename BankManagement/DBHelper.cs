using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace BankManagement
{
    public class DBHelper
    {
        ConnectionToDatabase _connectionToDatabase = new ConnectionToDatabase();
        public List<T> ReadAllData<T>(string procedure, params (string Key, object Value)[]? pairs)
        {
            _connectionToDatabase.connection.Open();
            SqlCommand command = new SqlCommand(procedure, _connectionToDatabase.connection);
            command.CommandType = CommandType.StoredProcedure;
            if (pairs != null)
            {
                foreach (var pair in pairs)
                {
                    command.Parameters.AddWithValue(pair.Key, pair.Value);
                }
            }

            SqlDataReader sqlDataReader = command.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            string json = JsonConvert.SerializeObject(dataTable);
            List<T>? users = JsonConvert.DeserializeObject<List<T>>(json);

            _connectionToDatabase.connection.Close();
            List<T> usersList = new();
            if (users != null)
            {
                usersList = users;
            }
            return usersList;
        }

        public void AddData(string procedure, params (string? key, object? value)[]? pairs)
        {
            SqlCommand command = new SqlCommand(procedure, _connectionToDatabase.connection);
            command.CommandType = CommandType.StoredProcedure;

            if (pairs != null)
            {
                foreach (var pair in pairs)
                {
                    command.Parameters.AddWithValue(pair.key, pair.value);
                }
            }
            _connectionToDatabase.connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            _connectionToDatabase.connection.Close();
        }
    }
}
