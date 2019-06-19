using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _20190507datagird
{
    public class DBManager
    {
        string connectionStr
= "Data Source=192.168.0.7;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=1234";

        public DataSet doSelect()
        {
            DataSet ds = new DataSet();

            SqlConnection con = new SqlConnection(connectionStr);
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from student",con);
            sda.Fill(ds);

            con.Close();

            return ds;
        }

        public bool doInsert(string name, string pw, string gender, string remark, string age)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            con.Open();

            SqlCommand sqlCommand
                = new SqlCommand("insert into student " +
                                 "values " +
                                 "((select max(idx)+1 as idx from student)," +
                                 "@name, @password," +
                                 "@gender, @remark, @age)", con);

            sqlCommand.Parameters.Add(new SqlParameter("@name", name));
            sqlCommand.Parameters.Add(new SqlParameter("@password", pw));
            sqlCommand.Parameters.Add(new SqlParameter("@gender", gender));
            sqlCommand.Parameters.Add(new SqlParameter("@remark", remark));
            sqlCommand.Parameters.Add(new SqlParameter("@age", age));

            sqlCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool dodelete(int idx)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            con.Open();

            SqlCommand sqlCommand
                = new SqlCommand("delete from student " +
                                 "where idx = @idx", con);

            sqlCommand.Parameters.Add(new SqlParameter("@idx", idx));

            sqlCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool doupdate(int select_idx, string name, string pw, string gender, string remark, string age)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            con.Open();

            SqlCommand sqlCommand
                = new SqlCommand("update student" +
                                 " set name = @name," +
                                 "     password = @password," +
                                 "     gender = @gender," +
                                 "     remark = @remark," +
                                 "     age = @age" +
                                 " where idx = @idx", con);

            sqlCommand.Parameters.Add(new SqlParameter("@name", name));
            sqlCommand.Parameters.Add(new SqlParameter("@password", pw));
            sqlCommand.Parameters.Add(new SqlParameter("@gender", gender));
            sqlCommand.Parameters.Add(new SqlParameter("@remark", remark));
            sqlCommand.Parameters.Add(new SqlParameter("@age", age));
            sqlCommand.Parameters.Add(new SqlParameter("@idx", select_idx));

            sqlCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
