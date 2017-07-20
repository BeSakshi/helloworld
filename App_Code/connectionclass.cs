using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

public class connectionclass
{
    public SqlCommand cmd;
    public SqlConnection con;
    public SqlDataAdapter da;
    public DataSet ds;
    public string str;
	public connectionclass()
	{
		
	}
    public void ConOpen()
    {
        str = @"Data Source=DESKTOP-6GN58PT\RAGHAV;Initial Catalog=jobportal;Integrated Security=True";
        con = new SqlConnection(str);
        con.Open();

    }
    //MAIN TABLE INSERTION.........////
    public int insert_into_job( string Logo, string Name,string Recruiter,string Postname,string Category, string State,string Description, string NoOfVacancy,string PayScale , string GradePay, string Nationality, string AgeLimit, string AgeRelaxation,string JobLocation, string SelectionProcess, string ApplicationFee, string HowToApply, string PostalAddress ,  string Qualification, string Postdate, string Lastdate, string Waytoapply,string Link)
    {
        ConOpen();
        cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Logo", SqlDbType.VarChar, 50).Value = Logo;
        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = Name;
        cmd.Parameters.Add("@Recruiter", SqlDbType.VarChar, 100).Value = Recruiter;
        cmd.Parameters.Add("@Postname", SqlDbType.VarChar, 50).Value = Postname;
        cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = Category;
        cmd.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = State;
        cmd.Parameters.Add("@Description", SqlDbType.VarChar,5000).Value = Description;
        cmd.Parameters.Add("@NoOfVacancy", SqlDbType.VarChar, 50).Value = NoOfVacancy;
        cmd.Parameters.Add("@PayScale", SqlDbType.VarChar, 50).Value = PayScale;
        cmd.Parameters.Add("@GradePay", SqlDbType.VarChar, 50).Value = GradePay;
        cmd.Parameters.Add("@Nationality", SqlDbType.VarChar, 50).Value = Nationality;
        cmd.Parameters.Add("@AgeLimit", SqlDbType.VarChar, 50).Value = AgeLimit;
        cmd.Parameters.Add("@AgeRelaxation", SqlDbType.VarChar, 50).Value = AgeRelaxation;
        cmd.Parameters.Add("@JobLocation", SqlDbType.VarChar, 50).Value = JobLocation;
        cmd.Parameters.Add("@SelectionProcess", SqlDbType.VarChar, 50).Value = SelectionProcess;
        cmd.Parameters.Add("@ApplicationFee", SqlDbType.VarChar, 50).Value = ApplicationFee;
        cmd.Parameters.Add("@HowToApply", SqlDbType.VarChar, 50).Value = HowToApply;
        cmd.Parameters.Add("@PostalAddress", SqlDbType.VarChar, 50).Value = PostalAddress;
            cmd.Parameters.Add("@Qualification", SqlDbType.VarChar, 50).Value = Qualification;
        cmd.Parameters.Add("@Postdate", SqlDbType.VarChar,50).Value = Postdate;
        cmd.Parameters.Add("@Lastdate", SqlDbType.VarChar,50).Value = Lastdate;
        cmd.Parameters.Add("@Waytoapply", SqlDbType.VarChar, 50).Value = Waytoapply;
        cmd.Parameters.Add("@Link", SqlDbType.VarChar, 50).Value = Link;
        
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 1;
        int n = cmd.ExecuteNonQuery();
        return n;
    }
         


    //..........................//
    //sub category table insertion///
    public int insert_into_state(string statename)

    {
        ConOpen();
        cmd = new SqlCommand("stt", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@statename", SqlDbType.VarChar, 50).Value = statename;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 1;
        int n = cmd.ExecuteNonQuery();
        return n;

    }
   
    public int insert_into_qualification(string qualification)
    {
        ConOpen();
        cmd = new SqlCommand("quali", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@qualificationname", SqlDbType.VarChar, 50).Value = qualification;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 1;
        int n = cmd.ExecuteNonQuery();
        return n;
    }
    public int insert_into_recruitertable(string recruitername)
    {
        ConOpen();
        cmd = new SqlCommand("recruit", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Recruitername", SqlDbType.VarChar, 100).Value = recruitername;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 1;
        int n = cmd.ExecuteNonQuery();
        return n;
    }
    public DataTable GetData(SqlCommand cmd)
    {
        string conString = @"Data Source=DESKTOP-6GN58PT\RAGHAV;Initial Catalog=jobportal;Integrated Security=True";
        
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                cmd.Connection = con;

                sda.SelectCommand = cmd;
                using (DataTable ds = new DataTable())
                {
                    sda.Fill(ds);
                    return ds;
                }
            }
        }
    }
    public int insert_into_category(string category)
    {
        ConOpen();
        cmd = new SqlCommand("categ", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@category", SqlDbType.VarChar, 100).Value = category;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 2;
        int n = cmd.ExecuteNonQuery();
        return n;
    }



    public DataTable bindqualification()
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("quali", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@action", 2);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }
    public DataTable bindRecruiter()
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("recruit", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@action", 2);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }

    public DataTable bindcateg()
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("categ", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@action", 3);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }




    public DataTable bindstates()
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("stt", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@action", 3);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }


    //storeprocedurecode for grid view select//
    public DataSet show(int action)
    {
        ConOpen();
        cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 2;
        DataSet ds = new DataSet();
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }
    //delete data from gridview/////
    public int delete_data(int Id)
    {
        ConOpen();
        cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 3;
        int n = cmd.ExecuteNonQuery();
        return n;
    }

    //gridview updatecode///
    public int update_data(int id,string Logo, string Name, string Recruiter, string Postname, string Category, string State, string Description, string NoOfVacancy, string PayScale, string GradePay, string Nationality, string AgeLimit, string AgeRelaxation, string JobLocation, string SelectionProcess, string ApplicationFee, string HowToApply, string PostalAddress, string Qualification, string Postdate, string Lastdate, string Waytoapply, string Link)
    {
        ConOpen();
        cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Logo", SqlDbType.VarChar, 50).Value = Logo;
        cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = Name;
        cmd.Parameters.Add("@Recruiter", SqlDbType.VarChar, 100).Value = Recruiter;
        cmd.Parameters.Add("@Postname", SqlDbType.VarChar, 50).Value = Postname;
        cmd.Parameters.Add("@Category", SqlDbType.VarChar, 50).Value = Category;
        cmd.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = State;
        cmd.Parameters.Add("@Description", SqlDbType.VarChar, 5000).Value = Description;
        cmd.Parameters.Add("@NoOfVacancy", SqlDbType.VarChar, 50).Value = NoOfVacancy;
        cmd.Parameters.Add("@PayScale", SqlDbType.VarChar, 50).Value = PayScale;
        cmd.Parameters.Add("@GradePay", SqlDbType.VarChar, 50).Value = GradePay;
        cmd.Parameters.Add("@Nationality", SqlDbType.VarChar, 50).Value = Nationality;
        cmd.Parameters.Add("@AgeLimit", SqlDbType.VarChar, 50).Value = AgeLimit;
        cmd.Parameters.Add("@AgeRelaxation", SqlDbType.VarChar, 50).Value = AgeRelaxation;
        cmd.Parameters.Add("@JobLocation", SqlDbType.VarChar, 50).Value = JobLocation;
        cmd.Parameters.Add("@SelectionProcess", SqlDbType.VarChar, 50).Value = SelectionProcess;
        cmd.Parameters.Add("@ApplicationFee", SqlDbType.VarChar, 50).Value = ApplicationFee;
        cmd.Parameters.Add("@HowToApply", SqlDbType.VarChar, 250).Value = HowToApply;
        cmd.Parameters.Add("@PostalAddress", SqlDbType.VarChar, 250).Value = PostalAddress;
        cmd.Parameters.Add("@Qualification", SqlDbType.VarChar, 50).Value = Qualification;
        cmd.Parameters.Add("@Postdate", SqlDbType.VarChar, 50).Value = Postdate;
        cmd.Parameters.Add("@Lastdate", SqlDbType.VarChar, 50).Value = Lastdate;
        cmd.Parameters.Add("@Waytoapply", SqlDbType.VarChar, 50).Value = Waytoapply;
        cmd.Parameters.Add("@Link", SqlDbType.VarChar, 50).Value = Link;

        cmd.Parameters.Add("@action", SqlDbType.Int).Value=4;
        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
        int x = cmd.ExecuteNonQuery();
        return x;
    }

    //advertisement gridview//
    public DataSet advertiseshow(int action)
    {
        ConOpen();
        cmd = new SqlCommand("advertise", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 3;
        DataSet ds = new DataSet();
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }
    //insert advertisement table//
    public int insert_into_advertise(string name, string image, string link, string description)
    {
        ConOpen();
        cmd = new SqlCommand("advertise", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
        cmd.Parameters.Add("@image", SqlDbType.VarChar, 50).Value = image;
        cmd.Parameters.Add("@link", SqlDbType.VarChar, 200).Value = link;
        cmd.Parameters.Add("@description", SqlDbType.VarChar, 500).Value = description;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 1;
        int n = cmd.ExecuteNonQuery();
        return n;

    }
    public int updateadvertise(int id, string name, string image, string link, string description)
    {
        ConOpen();
        cmd = new SqlCommand("advertise", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        cmd.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = name;
        cmd.Parameters.Add("@image", SqlDbType.VarChar, 100).Value =image;
        cmd.Parameters.Add("@link", SqlDbType.VarChar, 200).Value = link;
        cmd.Parameters.Add("@description", SqlDbType.VarChar, 500).Value = description;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 2;
        int x = cmd.ExecuteNonQuery();
        return x;
    }
    public int delete_advertisedata(int Id)
    {
        ConOpen();
        cmd = new SqlCommand("advertise", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 4;
        int n = cmd.ExecuteNonQuery();
        return n;
    }
    public SqlDataReader Select(String name, string pass)
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("login", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@action", SqlDbType.Int).Value = 1;
        cmd.Parameters.Add("email", SqlDbType.VarChar, 50).Value = name;
        cmd.Parameters.Add("password", SqlDbType.VarChar, 50).Value = pass;
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
        
    }
    public DataSet checkdoc_Email(string email)
    {
        ConOpen();
         cmd=new SqlCommand ("login" ,con);
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.Add("@action", SqlDbType.Int).Value = 2;
         cmd.Parameters.Add("email", SqlDbType.VarChar, 50).Value =email;
        
         SqlDataReader dr = cmd.ExecuteReader();
         ds = new DataSet();
         con.Close();
         da = new SqlDataAdapter(cmd);
         da.Fill(ds);
         return ds;

    }
  
}