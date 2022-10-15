using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace employee_manager
{
    class DBLayer
    {

        public string url = "server=DESKTOP-QT20KPQ;database=EmployeeDatabase;uid=bini;pwd=1234;";
        public void AddNew(User user)
        {

            using (SqlConnection con = new SqlConnection(url))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("spaddperson", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fname", user.fname);
                cmd.Parameters.AddWithValue("@lname", user.lname);
                cmd.Parameters.AddWithValue("@mname", user.mname);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@gender", user.gender);
                cmd.Parameters.AddWithValue("@dob", user.DTB);
                cmd.Parameters.AddWithValue("@Regdate", user.DTB);
                cmd.Parameters.AddWithValue("@branch", user.office);
                cmd.Parameters.AddWithValue("@field", user.field);
                cmd.Parameters.AddWithValue("@position", user.posistion);
                cmd.Parameters.AddWithValue("@phone1", user.phone1);
                cmd.Parameters.AddWithValue("@phone2", user.phone2);
                cmd.Parameters.AddWithValue("@benefit", user.benefit);
                cmd.Parameters.AddWithValue("@image", user.empic);
                cmd.Parameters.AddWithValue("@salary", user.salary);
                cmd.ExecuteNonQuery();
            }  
        }

        public void update(User user)
        {
            using (SqlConnection con = new SqlConnection(url))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("updateEmployee ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", user.id);
                cmd.Parameters.AddWithValue("@fname", user.fname);
                cmd.Parameters.AddWithValue("@lname", user.lname);
                cmd.Parameters.AddWithValue("@mname", user.mname);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@gender", user.gender);
                cmd.Parameters.AddWithValue("@dob", user.DTB);
                cmd.Parameters.AddWithValue("@Regdate", user.DTR);
                cmd.Parameters.AddWithValue("@branch", user.office);
                cmd.Parameters.AddWithValue("@phone1", user.phone1);
                cmd.Parameters.AddWithValue("@phone2", user.phone2);
                cmd.Parameters.AddWithValue("@image", user.empic);
                cmd.ExecuteNonQuery();
            }
        }
        public void updatepwd(string usr,string fld,string pwd)
        {
            using (SqlConnection con = new SqlConnection(url))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("updatepwd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usr",usr );
                cmd.Parameters.AddWithValue("@fld", fld);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.ExecuteNonQuery();
            }

        }
        public DataTable getRecords(string Query)
        {
            SqlConnection Con = new SqlConnection(url);
            Con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public void deleterow(int userid)
        {
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand del = new SqlCommand("spdeleteEmployee", con);
            del.CommandType = CommandType.StoredProcedure;
            del.Parameters.AddWithValue("@id", userid);
            del.ExecuteNonQuery();
        }
        public DataTable getbranch()
        {
            SqlConnection con = new SqlConnection(url);
            DataSet ds = new DataSet();
            con.Open();
            string query = "exec listbranch";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "branch");
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public DataTable getposition()
        {
            SqlConnection con = new SqlConnection(url);
            DataSet ds = new DataSet();
            con.Open();
            string query = "exec listposition";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "position");
            DataTable dt = ds.Tables["position"];
            return dt;
        }
        public DataTable getfield()
        {
            SqlConnection con = new SqlConnection(url);
            DataSet ds = new DataSet();
            con.Open();
            string query = "exec listfield";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "field");
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public void addField(field fld)
        {
            using (SqlConnection con = new SqlConnection(url))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("addfield", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fieldName", fld.newField);
                cmd.Parameters.AddWithValue("@fieldDEC", fld.fieldDesc);
                cmd.ExecuteNonQuery();
            }

        }
        public void addBranch(branch br)
        {
            using (SqlConnection con = new SqlConnection(url))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("addbranch", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@branchName", br.newBranch);
                cmd.Parameters.AddWithValue("@branchAddress", br.branchAdd);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable getRole(string un, string pwd)
        {
            using (SqlConnection con = new SqlConnection(url))
            {
                DataSet ds = new DataSet();
                con.Open();
                string query = "exec spgetRole '" + un + "','" + pwd + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds, "loginRole,loginfld,username,password");
                DataTable dt1 = ds.Tables[0];
                return dt1;
            }
        }

       
    }
}
