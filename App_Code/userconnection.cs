using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


public class userconnection
{
    public SqlCommand cmd;
    public SqlConnection con;
    public SqlDataAdapter da;
    public DataSet ds;
    string str;
	public userconnection()
	{
		
	}
    public void ConOpen()
    {
        str = @"Data Source=DESKTOP-6GN58PT\RAGHAV;Initial Catalog=jobportal;Integrated Security=True";
        con = new SqlConnection(str);
        con.Open();

    }

    public DataTable bindstate()
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

    public DataTable bindquali()
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
    public DataTable bindpostname()
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@action",17);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }


    public DataTable bindbypost( string post)
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Postname",post);
        cmd.Parameters.AddWithValue("@action", 18);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }

    public DataTable bindRecruter()
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
    public DataTable bindRecruterbylist()
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

    public DataTable bindRecruiterjob(string recru)
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Recruiter",recru);
        cmd.Parameters.AddWithValue("@action", 11);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }
    public DataTable bindBankjob(int id)
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@action", 12);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }
    public DataTable bindQualificationjob(string qual)
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Qualification", qual);
        cmd.Parameters.AddWithValue("@action", 13);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }
    public DataTable bindqualibyidjob(int id)
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@action", 14);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }
    public DataTable bindstatejobs(string state)
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@State", state);
        cmd.Parameters.AddWithValue("@action", 15);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }
    public DataTable bindtodayjoblist()
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("jobs", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@action", 16);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }
    //bind data for advertisement
    public DataTable bindadvertisementdata()
    {
        ConOpen();
        SqlCommand cmd = new SqlCommand("advertise", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@action",5);
        SqlDataAdapter sda = new SqlDataAdapter();
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        DataTable dt = new DataTable();
        sda.Fill(dt);
        return dt;


    }


}