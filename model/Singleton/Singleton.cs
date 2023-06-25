using System.Data.SqlClient;

namespace TestTask.model.Singleton
{
    internal class Singleton
    {
        private static SqlConnection connection;
        public string _server_name { get; set; }
        public string _user_name { get; set; }
        public string _password { get; set; }
        public string _connState { get; set; }

        public Singleton(){}

        public SqlConnection GetInstance()
        {
            if (_connState == "bad")
            {
                connection = null;
                _connState = null;
            }
            if (connection == null)
            {
                connection = new SqlConnection(GetConnectionStrings());
            }
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            return connection;
        }
        public string GetConnectionStrings()
        {
            if (_user_name == "" && _password == "")
            {
                string connStr = $"Server={_server_name};Trusted_Connection=True;";
                return connStr;
            }
            else if (_password == "")
            {
                string connStr = $"Server={_server_name};User Id={_user_name};Integrated Security=true";
                return connStr;
            }
            else
            {
                string connStr = $"Server={_server_name};Database=master;User Id={_user_name};Password={_password};";
                return connStr;
            }
        }
    }
}
