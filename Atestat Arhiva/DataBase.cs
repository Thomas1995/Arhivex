using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Atestat_Arhiva
{
    class DataBase
    {
        static SqlConnection client = new SqlConnection();

        public DataBase()
        {
            string relativePath = "arhiva.mdf";
            string absolutePath = Application.StartupPath + "\\" + relativePath;
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + "\"" + absolutePath + "\"" + ";Integrated Security=True;Connect Timeout=30";
            client.ConnectionString = connectionString;

            OpenIfNotOpen();
        }

        static void OpenIfNotOpen()
        {
            if(client.State != ConnectionState.Open) client.Open();
        }

        static public List<List<string>> Query(string query)
        {
            OpenIfNotOpen();

            List<List<string>> ret = new List<List<string>>();

            SqlCommand cmd = new SqlCommand(query, client);
            SqlDataReader sdr = cmd.ExecuteReader();

            while(sdr.Read())
            {
                ret.Add(new List<string>());
                for (int i = 0; i < sdr.FieldCount; ++i) ret[ret.Count - 1].Add(sdr[i]+"");
            }

            sdr.Close();
            sdr.Dispose();
            cmd.Dispose();
            return ret;
        }

        static public void NonQuery(string query)
        {
            OpenIfNotOpen();

            SqlCommand cmd = new SqlCommand(query, client);
            cmd.ExecuteNonQuery();
        }

        static public int GetValue(string query)
        {
            OpenIfNotOpen();

            SqlCommand cmd = new SqlCommand(query, client);
            string ret = cmd.ExecuteScalar().ToString();
            if (ret == "") return 0;
            return Convert.ToInt32(ret);
        }

        static public void FillDataSet(string query, DataSet ds)
        {
            OpenIfNotOpen();

            SqlDataAdapter sda = new SqlDataAdapter(query, client);
            sda.Fill(ds);
        }
    }
}
