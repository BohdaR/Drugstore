using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Drugstore
{
    class DB
    {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.drugstoreConnectionString);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

        public string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;

            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
    }
}
