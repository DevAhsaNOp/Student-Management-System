using Student_Management_System.Context;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Student_Management_System.Controllers
{
    public class UserController : Controller
    {
        studentmanagementsystem_Entities1 dbObj = new studentmanagementsystem_Entities1();
        // GET: User
        [Authorize]
        public ActionResult Index()
        {
            if (Session["UserName"] != null)
                return View("UserDashBoard");
            return View();
        }

        [AllowAnonymous]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Signup(tbl_account model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.msg = "Please enter the details to Sign Up!";
                model = null;
                return View("Signup");
            }
            else
            {
                if (model != null)
                {
                    dbObj.tbl_account.Add(model);                         // Adding the data into tbl_account table 
                    dbObj.SaveChanges();
                    ViewBag.msg = "Account created successfully!";
                    model = null;
                    return View("Login");
                }
                else
                {
                    ViewBag.msg = "Please enter the details to Sign Up!";
                    model = null;
                    return View("Signup");
                }
            }
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            if (Session["UserName"] != null)
                return View("UserDashBoard");
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(tbl_account model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.msg = "Please enter the details to Login!";
                model = null;
                return View();
            }
            else
            {
                if (model != null)
                {
                    tbl_account s = dbObj.tbl_account.Where(a => a.email.Equals(model.email) && a.password.Equals(model.password)).SingleOrDefault();
                    if (s != null)
                    {
                        Session["UserID"] = s.userid.ToString();
                        Session["UserName"] = s.name.ToString();
                        FormsAuthentication.SetAuthCookie(model.email, false);
                        return Redirect("UserDashBoard");
                    }
                    else
                    {
                        ViewBag.msg = "Invalid Email or Password!";
                        model = null;
                    }
                    return View();
                }
                else
                {
                    ViewBag.msg = "Please enter the details to Login!";
                    model = null;
                    return View("Login");
                }
            }
        }

        [Authorize]
        public ActionResult UserDashBoard()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return View("Login");
        }
    }
}