using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LuuNiem
{
    internal class MyDb
    {
        //Khai báo biến
        private static SqlConnection mySqlConnection;

        public MyDb()
        {
            string severName = Environment.MachineName;

            try
            {
                mySqlConnection = new SqlConnection($"Data Source ={severName};Initial Catalog=LuuNiem;Integrated Security=True");
                //mySqlConnection = new SqlConnection($"Data Source=DESKTOP - GP47KE0;Initial Catalog=LuuNiem;Integrated Security=False;User ID=sa;Password=12345;");
                mySqlConnection.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error" + ex.Number.ToString());
            }
        }
        public DataTable GetDataTable( string sSql)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(sSql, mySqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.Fill(myDataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error" + ex.Number.ToString());
                return null;
            }
            return myDataTable;
        }
        public SqlDataReader GetDataReader(string sQuery)
        {
            SqlDataReader dataReader;
            try
            {
                SqlCommand command = new SqlCommand(sQuery, mySqlConnection);
                dataReader = command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error" + ex.Number.ToString());
                return null;
            }
            return dataReader;
        }
        public void RunNonQuery(string sSql)
        {
            SqlCommand mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error" + ex.Source.ToString() + ": " + ex.LineNumber.ToString());
            }
        }
        
    }
    
}