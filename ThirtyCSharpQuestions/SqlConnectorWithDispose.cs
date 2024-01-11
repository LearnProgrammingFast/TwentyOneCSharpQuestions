using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyCSharpQuestions
{
    public class SQLConnector : IDisposable
    {
        SqlConnection sqlConn = null;

        public SQLConnector()
        {
            sqlConn = new SqlConnection("ConnectionString");
            sqlConn.Open();
        }

        public DataSet GetData()
        {
            //Add the code to retireve some data from the DataBase
            return new DataSet();
        }

        public void PutData()
        {
            //Add the code to update the data base
        }

        public void Dispose()
        {
            if (sqlConn != null)
                sqlConn.Dispose();
        }
    }
}
