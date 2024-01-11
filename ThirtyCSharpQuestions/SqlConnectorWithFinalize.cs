using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyCSharpQuestions
{
    public class SQLConnectorWithFinalize : IDisposable
    {
        SqlConnection sqlConn = null;

        public SQLConnectorWithFinalize()
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

        ~SQLConnectorWithFinalize()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose any disposable fields here
                GC.SuppressFinalize(this);
            }
            ReleaseNativeResource();
        }

        private void ReleaseNativeResource()
        {
            sqlConn.Dispose();
        }
    }
}

/*Finalize is like a deconstructor which will be called by .NET framework. Suppose you have a unmanaged resource as seen in the above code and you have implemented the Dispose pattern properly.

But what if the user of the class forgets to call the Dispose method. or he does not create the instance of the class in the using code block. The resource will not be disposed and it will create memory leaks.
*/
