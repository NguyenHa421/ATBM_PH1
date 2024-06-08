using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ATBM_PhanHe1.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionStr = "DATA SOURCE=(DESCRIPTION =" +
        "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
        $"(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME =)));User Id = {Home_Login.Login.User};password = {Home_Login.Login.Pass};";
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }

        }
        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            if (Home_Login.Login.User != "sys")
            {
                connectionStr = "DATA SOURCE=(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            $"(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME =)));User Id = {Home_Login.Login.User};password = {Home_Login.Login.Pass};";
            }
            else
            {
                connectionStr = "DATA SOURCE=(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            $"(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME =)));User Id = {Home_Login.Login.User};password = {Home_Login.Login.Pass};DBA Privilege=SYSDBA;";
            }

            using (OracleConnection connection = new OracleConnection(connectionStr))
            {

                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                }
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                connection.Close();

            }
            
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            if (Home_Login.Login.User != "sys")
            {
                connectionStr = "DATA SOURCE=(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            $"(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME =)));User Id = {Home_Login.Login.User};password = {Home_Login.Login.Pass};";
            }
            else
            {
                connectionStr = "DATA SOURCE=(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            $"(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME =)));User Id = {Home_Login.Login.User};password = {Home_Login.Login.Pass};DBA Privilege=SYSDBA;";
            }
            using (OracleConnection connection = new OracleConnection(connectionStr))
            {

                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                    
                }
                
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            if (Home_Login.Login.User != "sys")
            {
                connectionStr = "DATA SOURCE=(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            $"(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME =)));User Id = {Home_Login.Login.User};password = {Home_Login.Login.Pass};";
            }
            else
            {
                connectionStr = "DATA SOURCE=(DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            $"(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME =)));User Id = {Home_Login.Login.User};password = {Home_Login.Login.Pass};DBA Privilege=SYSDBA;";
            }
            using (OracleConnection connection = new OracleConnection(connectionStr))
            {

                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.Add(item, parameter[i]);
                            i++;
                        }
                    }
                    
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }

}
