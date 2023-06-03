using Student_Management_System.Context;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Student_Management_System.Controllers
{
    public class ClassController : Controller
    {

        // GET: Class
        studentmanagementsystem_Entities1 dbObj = new studentmanagementsystem_Entities1();
        [HttpGet]
        public ActionResult AddClass()
        {
            @class cls = new @class();
            return View(cls);
        }


        [HttpPost]
        public ActionResult AddClass(@class model)
        {

            @class cls = new @class();
            cls.id = model.id;
            cls.name = model.name;
            cls.section = model.section;
            cls.IsMaths = model.IsMaths;
            cls.IsEnglishLiterature = model.IsEnglishLiterature;
            cls.IsEnglishGrammar = model.IsEnglishGrammar;
            cls.IsUrdu = model.IsUrdu;
            cls.IsIslamiyat = model.IsIslamiyat;
            cls.IsScience = model.IsScience;
            cls.IsPhysics = model.IsPhysics;
            cls.IsChemistry = model.IsChemistry;
            cls.IsComputer = model.IsComputer;
            cls.IsHistory = model.IsHistory;
            cls.IsGeography = model.IsGeography;

            if (model.id == 0)
            {
                dbObj.classes.Add(cls);
                dbObj.SaveChanges();
            }
            else
            {
                dbObj.Entry(cls).State = EntityState.Modified;
                dbObj.SaveChanges();
            }
            ModelState.Clear();

            return RedirectToAction("ClassList", "Class");
        }

        public ActionResult Edit(int Id)
        {
            List<@class> clslist = dbObj.classes.ToList();

            //getting a class from collection
            var cls = clslist.Where(s => s.id == Id).FirstOrDefault();

            return View(cls);
        }

        [HttpPost]
        public ActionResult Edit(@class clas)
        {
            List<@class> clslist = dbObj.classes.ToList();

            //update list by removing old class and adding updated class information
            var cls = clslist.Where(s => s.id == clas.id).FirstOrDefault();
            dbObj.classes.Remove(cls);
            dbObj.classes.Add(clas);
            dbObj.SaveChanges();

            return RedirectToAction("ClassList");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                // return a bad request
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            @class cls = dbObj.classes.Find(id);
            if (cls == null)
            {
                return HttpNotFound();
            }
            return View(cls);
        }

        public ActionResult ClassList(string searchBy, string searchValue)
        {
            List<JoinClasses> jc = new List<JoinClasses>();
            string constrg = @"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=studentmanagementsystem_;Persist Security Info=True;User ID=studentmanagementsystem_;Password=student123";
            SqlConnection sql = new SqlConnection(constrg);
            string sqlqu = "select * from class";
            SqlCommand sqlComm = new SqlCommand(sqlqu, sql);
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                JoinClasses jcobj = new JoinClasses();
                jcobj.id = (int)dr["id"];
                jcobj.name = dr["name"].ToString();
                jcobj.section = dr["section"].ToString();
                jcobj.IsMaths = (bool)dr["IsMaths"];
                jcobj.IsEnglishLiterature = (bool)dr["IsEnglishLiterature"];
                jcobj.IsEnglishGrammar = (bool)dr["IsEnglishGrammar"];
                jcobj.IsUrdu = (bool)dr["IsUrdu"];
                jcobj.IsIslamiyat = (bool)dr["IsIslamiyat"];
                jcobj.IsScience = (bool)dr["IsScience"];
                jcobj.IsPhysics = (bool)dr["IsPhysics"];
                jcobj.IsChemistry = (bool)dr["IsChemistry"];
                jcobj.IsComputer = (bool)dr["IsComputer"];
                jcobj.IsHistory = (bool)dr["IsHistory"];
                jcobj.IsGeography = (bool)dr["IsGeography"];

                jc.Add(jcobj);
            }

            if (string.IsNullOrEmpty(searchValue))
            {
                TempData["InfoMessage"] = "Please provide search value.";
                return View(jc);
            }
            else
            {
                if (searchBy.ToLower() == "name")
                {
                    var searchByFname = jc.Where(p => p.name.ToLower().Contains(searchValue.ToLower()));
                    return View(searchByFname);
                }
                else if (searchBy.ToLower() == "section")
                {
                    var searchByPhone = jc.Where(p => p.section.ToLower().Contains(searchValue.ToLower()));
                    return View(searchByPhone);
                }
            }

            return View(jc);
        }
    }
}