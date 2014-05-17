using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace newGym
{
    class MySQL
    {
        private static string cs = @"server=localhost;userid=root;password=csharp;database=gym";
        public static int count(string query)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand(query,conn);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show("Error no: " + ex.Message);

                return -1;

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }
        public static int Query(DataTable dt,string query)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);


                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = new MySqlCommand(query, conn);

                conn.Open();
                adapter.Fill(dt);

                conn.Close();
                return 0;
            }
            catch (MySqlException ex)
            {
                return ex.Number;

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }
        public static int Select(DataTable dt,string table)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);


                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = new MySqlCommand("SELECT * FROM " + table, conn);

                conn.Open();
                adapter.Fill(dt);

                conn.Close();
                return 0;
            }
            catch (MySqlException ex)
            {
                return ex.Number;

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        public static int Update(string table,string parameters,string where)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);

                MySqlCommand cmd = new MySqlCommand("UPDATE " + table + " SET " + parameters + " WHERE " + where,conn);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conn.Close();
                    return 1;
                }

                conn.Close();
                return 0;
            }
            catch (MySqlException ex)
            {
                return ex.Number;

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        public static int Insert(string table, string columns ,string parameters)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);

                MySqlCommand cmd = new MySqlCommand("INSERT INTO " + table + "(" + columns + ")" + " VALUES (" + parameters + ")", conn);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conn.Close();
                    return 1;
                }

                conn.Close();
                return 0;
            }
            catch (MySqlException ex)
            {
                return ex.Number;

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        public static int Delete(string table, string where)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);

                MySqlCommand cmd = new MySqlCommand("DELETE FROM " + table + " WHERE " + where, conn);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conn.Close();
                    return 1;
                }

                conn.Close();
                return 0;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show("Error no: " + ex.Message);

                return ex.Number;

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }
        // new added function 
        public static int SUM(string table, string collumn)
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);

                MySqlCommand cmd = new MySqlCommand("SELECT SUM(" + collumn + ")" + " FROM " + table, conn);

                conn.Open();
                //      MessageBox.Show( cmd.ExecuteScalar().GetType().Name +Convert.ToInt32(cmd.ExecuteScalar() ));
                int ret = (int)Convert.ToInt32(cmd.ExecuteScalar());

                return ret;
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Error no: " + ex.Message);

                return 0;
            }
            catch (InvalidCastException exe) {
                MessageBox.Show("Error type: " + exe.Message);
                return 0;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }
    }
}
