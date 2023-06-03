using Student_Management_System.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_System.Controllers
{
    public class ResultController : Controller
    {
        studentmanagementsystem_Entities1 dbObj = new studentmanagementsystem_Entities1();
        // GET: Result
        public ActionResult AddResult(result model)
        {
            var stdList = dbObj.students.ToList();
            ViewBag.std = new SelectList(stdList, "std_id", "std_Fname");
            var classList = dbObj.classes.ToList();
            ViewBag.classname = new MultiSelectList(classList, "id", "name", "section");

            return View(model);
        }

        [HttpPost]
        public ActionResult Result(result model)
        {
            result f = new result();
            f.RES_id = model.RES_id;
            f.RES_class_id = model.RES_class_id;
            f.RES_std_id = model.RES_std_id;
            f.Exam_type = model.Exam_type;
            f.RES_maths_marks = model.RES_maths_marks;
            f.RES_englishliterature_marks = model.RES_englishliterature_marks;
            f.RES_englishgrammar_marks = model.RES_englishgrammar_marks;
            f.RES_urdu_marks = model.RES_urdu_marks;
            f.RES_islamiyat_marks = model.RES_islamiyat_marks;
            f.RES_Science_marks = model.RES_Science_marks;
            f.RES_Physics_marks = model.RES_Physics_marks;
            f.RES_Chemistry_marks = model.RES_Chemistry_marks;
            f.RES_History_marks = model.RES_History_marks;
            f.RES_Geography_marks = model.RES_Geography_marks;
            f.RES_Computer_marks = model.RES_Computer_marks;
            f.RES_activity_marks = model.RES_activity_marks;
            f.RES_total_marks = model.RES_total_marks;
            f.RES_percentage = model.RES_percentage;
            f.RES_grade = model.RES_grade;
            f.RES_REmarks = model.RES_REmarks;

            if (model.RES_id == 0)
            {
                dbObj.results.Add(f);
                dbObj.SaveChanges();
            }
            else
            {
                dbObj.Entry(f).State = System.Data.Entity.EntityState.Modified;
                dbObj.SaveChanges();
            }
            ModelState.Clear();

            return RedirectToAction("ResultList", "Result");
        }

        public ActionResult ResultList(string searchBy, string searchValue)
        {
            List<Joinresult> jr = new List<Joinresult>();
            string constrg = @"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=studentmanagementsystem_;Persist Security Info=True;User ID=studentmanagementsystem_;Password=student123";
            SqlConnection sql = new SqlConnection(constrg);
            string sqlqu = "select R.RES_id, R.RES_std_id, s.std_Fname, s.std_Lname, c.name , c.section, R.RES_percentage,R.RES_grade from result R inner join student s on R.RES_std_id = s.std_id inner join class c on R.RES_std_id = c.id;";
            SqlCommand sqlComm = new SqlCommand(sqlqu, sql);
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Joinresult jrobj = new Joinresult();
                jrobj.RES_id = (int)dr["RES_id"];
                jrobj.RES_std_id = (int)dr["RES_std_id"];
                jrobj.StudentFname = dr["std_Fname"].ToString();
                jrobj.StudentLname = dr["std_Lname"].ToString();
                jrobj.ClassName = dr["name"].ToString();
                jrobj.ClassSection = dr["section"].ToString();
                jrobj.RES_percentage = (double)dr["RES_percentage"];
                jrobj.RES_grade = dr["RES_grade"].ToString();
                jr.Add(jrobj);
            }

            if (string.IsNullOrEmpty(searchValue))
            {
                TempData["InfoMessage"] = "Please provide search value.";
                return View(jr);
            }
            else
            {
                if (searchBy.ToLower() == "studentfname")
                {
                    var searchByFname = jr.Where(p => p.StudentFname.ToLower().Contains(searchValue.ToLower()));
                    return View(searchByFname);
                }
                else if (searchBy.ToLower() == "studentlname")
                {
                    var searchByPhone = jr.Where(p => p.StudentLname.ToLower().Contains(searchValue.ToLower()));
                    return View(searchByPhone);
                }
            }

            return View(jr);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                // return a bad request
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            result cls = dbObj.results.Find(id);
            if (cls == null)
            {
                return HttpNotFound();
            }
            return View(cls);
        }
    }
}