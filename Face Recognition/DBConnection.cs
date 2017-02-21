using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace  Face_Recognition

{
    class DBConnection
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=silentwatcher;Integrated Security=True");
        public static string _userid = String.Empty;
        public string userid
        {

            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }


        public static string _criminalid = String.Empty;
        public string criminalid
        {

            get
            {
                return _criminalid;
            }
            set
            {
                _criminalid = value;
            }
        }
        public string ins_up_del(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {

                cmd.ExecuteNonQuery();
                con.Close();
                return "true";
            }
            catch (Exception ex)
            {
                con.Close();
                string s = ex.Message.ToString();
                return s;
            }


        }
        public int check_column(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            int it = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return it;

        }

        public DataTable gettable(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(query, con);
            dap.Fill(dt);
            con.Close();
            return dt;

        }

        public string savedata(string sp_name, SqlCommand cmd)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp_name;
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                return "true";
            }
            catch (Exception ex)
            {
                con.Close();
                string s = ex.Message.ToString();
                return s;
            }

        }
        public string selone(string qry)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            string t = cmd.ExecuteScalar().ToString();
            con.Close();
            return t;
        }





    }
}
