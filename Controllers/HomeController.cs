using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace Pitch.Controllers
{
    public class HomeController : Controller
    {
                public IActionResult AddFriends()
        {

            return View();
        }
        public IActionResult CreateNewGroup()
        {

            return View();
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Groups()
        {
            //ViewData["Message"] = "Your Groups page.";
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Playlist()
        {
            //ViewData["Message"] = "Your Groups page.";
            return View();
        }

        public IActionResult About()
        {
            /*
            SqlConnection myconnection = new SqlConnection();
            myconnection.ConnectionString =
               "user id=Garrett; password = ; server=GARRETT-IDEAPAD\\SQLEXPRESS; Database=PitchDB;";
            try {
                myconnection.Open();
                SqlCommand myCommand = new SqlCommand("select * from Users", myconnection);
                myCommand.ExecuteNonQuery();
                //myCommand.CommandType = System.Data.CommandType.Text;
                //myCommand.CommandText = "select * from Users";
                //myconnection.Open();

                SqlDataReader myReader = null;
                SqlDataReader reader = myCommand.ExecuteReader();
                myReader = myCommand.ExecuteReader();
                while(myReader.Read())
                {
                    ViewData["Message"] = myReader["Username"].ToString();
                    Console.WriteLine(myReader["Column2"].ToString());
                }
            }
            catch (Exception e)
            {
                ViewData["Message"] = "Caught by catch";
                Console.WriteLine(e.ToString());
            }

            //ViewData["Message"] = "Your application description page.";
            //ViewData["Message"] =  reader.ToString();
            */
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
