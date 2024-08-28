using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class KetNoi
    {
        private static KetNoi instance;
        public static KetNoi Instance
        {
            get { if (instance == null) instance = new KetNoi(); return KetNoi.instance; }
            private set { KetNoi.instance = value; }
        }
        private KetNoi() { }

        private string conStr = @"Data Source=DESKTOP-HIU54U1;Initial Catalog=DEMO;Integrated Security=True";

        public DataTable ExecuteQuery(string truyvan, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);

                if (parameter != null)
                {
                    string[] listPara = truyvan.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                conn.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string truyvan, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);

                if (parameter != null)
                {
                    string[] listPara = truyvan.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }
        public object ExecuteScalar(string truyvan, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);

                if (parameter != null)
                {
                    string[] listPara = truyvan.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                conn.Close();
            }
            return data;
        }

    }
}

