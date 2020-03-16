using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using MvcWithDba.Models;
using System.Data.SqlClient;
namespace MvcWithDba.Controllers
{
    public class DbaController : Controller
    {
        // GET: Dba
        public ActionResult Index()
        {
            List<Test3> testlist = new List<Test3>();
            string cs = ConfigurationManager.ConnectionStrings["DBaconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Test3";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {


                var Test3 = new Test3();
                Test3.Business_Unit = rdr["Business_Unit"].ToString();
                Test3.Job_Name = rdr["Job_Name"].ToString();
                Test3.Scheduled_Date_Time = Convert.ToDateTime( rdr["Scheduled_Date_Time"].ToString());
                Test3.Last_Run_Date_Time = Convert.ToDateTime(rdr["Last_Run_Date_Time"].ToString());
                Test3.Next_Run_Date_Time = Convert.ToDateTime(rdr["Next_Run_Date_Time"].ToString());
                Test3.Scheduled_By_User = rdr["Scheduled_By_User"].ToString();
                Test3.Current_Status = rdr["Current_Status"].ToString();
                Test3.Performance = rdr["Performance"].ToString();
                Test3.Parameter_s = rdr["Parameter_s"].ToString();
                Test3.Last_3_Runs_Hours = rdr["Last_3_Runs_Hours"].ToString();
                testlist.Add(Test3);




            }


            return View(testlist);
        }
