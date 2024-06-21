using Environmental_survey.Data;
using Environmental_survey.Migrations;
using Environmental_survey.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Environmental_survey.Controllers
{
    public class adminController : Controller
    {
        appcontext _appcontext;

        // Image Work
        IWebHostEnvironment env;

        public adminController(appcontext appcontext, IWebHostEnvironment environment)
        {
            _appcontext = appcontext;
            env = environment ; 
        }


        // Temlate Work Start

        // Simple Views
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Blog_Details()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        // Contact Insert
        [HttpPost]
        //public IActionResult Contact(contact c)
        //{
        //    _appcontext.contacts.Add(c);
        //    _appcontext.SaveChanges();
        //    ModelState.Clear();
        //    return View();
        //}

        public IActionResult Elements()
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();

        }

        public IActionResult whatdo()
        {
            return View();
        }
        // Simple Views End


        // View
        public IActionResult Register()
        {
            return View();
        }

        // Register Insert
        [HttpPost]
        public IActionResult Register(register r)

        {
            _appcontext.registers.Add(r);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("login");
        }

        // View
        public IActionResult login()
        {
            return View();
        }

        // Login Work
        [HttpPost]
        public IActionResult login(register r)
        {

            var a = _appcontext.registers.Where(data => data.Email == r.Email && data.Password == r.Password).FirstOrDefault();

            if (a != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.ErrorMessage = "Plz Insert Correct Password";
            }


            return View();
        }

        // Temlate Work End

        // Admin Dashboard Work End
        public IActionResult Dashboard()
        {
            return View();
        }


        // Contact Work Start

        // Fetch
        public IActionResult viewContact()
        {
            return View(_appcontext.contacts.ToList());
        }

        // Delete
        //public IActionResult contactDelete(int Id)
        //{
        //    contact c = _appcontext.contacts.Find(Id);
        //    _appcontext.contacts.Remove(c);
        //    _appcontext.SaveChanges();
        //    return RedirectToAction("viewContact");

        //}
        // Contact Work End


        // Signup Work Start

        // Fetch
        public IActionResult viewSignup()
        {
            return View(_appcontext.registers.ToList());
        }

        // Delete
        public IActionResult signupDelete(int Id)
        {
            register re = _appcontext.registers.Find(Id);
            _appcontext.registers.Remove(re);
            _appcontext.SaveChanges();
            return RedirectToAction("viewSignup");
        }

        // Update
        public IActionResult signupUpdate(int Id)
        {
            var mysignupupdate = _appcontext.registers.Find(Id);
            return View(mysignupupdate);
        }

        // Update(insert)
        [HttpPost]
        public IActionResult signupUpdate(register r)
        {
            var merasignupdate = _appcontext.registers.Find(r.Id);

            if(merasignupdate != null)
            {
                merasignupdate.Name = r.Name;
                merasignupdate.Email = r.Email;
                merasignupdate.Password = r.Password;
            }
            _appcontext.SaveChanges();

            return RedirectToAction("viewSignup");
        }

        // Signup Work End

        // Survey Work Start

        // View
        public IActionResult addSurvey()

        {
            return View();
        }

        // Insert + Img
        [HttpPost]
        public IActionResult addSurvey(survey_ s)

        {
            String filename = "";
            if (s.Photo != null)
            {
                String uploadFolder = Path.Combine(env.WebRootPath, "images");
                filename = Guid.NewGuid().ToString() + "_" + s.Photo.FileName;
                String mergevalue = Path.Combine(uploadFolder, filename);
                s.Photo.CopyTo(new FileStream(mergevalue, FileMode.Create));
                Survey data = new Survey
                {
                    Title = s.Title,
                    Details  = s.Details,
                    SurveyImage = filename
                };
                _appcontext.surveys.Add(data);
                _appcontext.SaveChanges();
                ModelState.Clear();
            }
            return RedirectToAction("Dashboard");
           
        }

        // Fetch
        public IActionResult viewSurvey()
        {
            return View(_appcontext.surveys.ToList());
        }

        // Delete
        public IActionResult surveyDelete(int Id)
        {
             Survey s = _appcontext.surveys.Find(Id);
            _appcontext.surveys.Remove(s);
            _appcontext.SaveChanges();
            return RedirectToAction("viewSurvey");
        }

        // Update
        public IActionResult surveyUpdate(int Id)
        {
            var mysurvey = _appcontext.surveys.Find(Id);
            return View(mysurvey);
        }

        // Update(insert)
        [HttpPost]
        public IActionResult surveyUpdate(Survey s)
        {
            var mysurveyupdate = _appcontext.surveys.Find(s.Id);

            if (mysurveyupdate != null)
            {
                mysurveyupdate.Title = s.Title;
                mysurveyupdate.Details = s.Details;
                mysurveyupdate.SurveyImage = s.SurveyImage;
            }
            _appcontext.SaveChanges();

            return RedirectToAction("viewSurvey");
        }

        // Facultay Work Start

        public IActionResult addFaculty()
        {
            return View();
        }

        // Insert + Img
        [HttpPost]
        public IActionResult addFaculty(faculty_ f)

        {
            String myfile = "";
            if (f.Photo != null)
            {
                String uploadFolder = Path.Combine(env.WebRootPath, "images");
                myfile = Guid.NewGuid().ToString() + "_" + f.Photo.FileName;
                String mergevalue = Path.Combine(uploadFolder, myfile);
                f.Photo.CopyTo(new FileStream(mergevalue, FileMode.Create));
                faculty data = new faculty
                {
                   Name = f.Name,
                   Email = f.Email,
                   Password  = f.Password,
                   Education = f.Education,
                   facultyimg = myfile
                };
                _appcontext.faculties.Add(data);
                _appcontext.SaveChanges();
                ModelState.Clear();
            }
            return View();

        }

        // Fetch
        public IActionResult ViewFaculty()
        {
            return View(_appcontext.faculties.ToList());
        }

        // Delete
        public IActionResult facultyDelete(int Id)
        {
            faculty f = _appcontext.faculties.Find(Id);
            _appcontext.faculties.Remove(f);
            _appcontext.SaveChanges();
            return RedirectToAction("ViewFaculty");
        }

        // Update
        public IActionResult FacultyUpdate(int Id)
        {
            var accountupdate = _appcontext.faculties.Find(Id);
            return View(accountupdate);
        }

        // Update(Insert)
        [HttpPost]
        public ActionResult FacultyUpdate(faculty f)
        {
            var updateaccount = _appcontext.faculties.Find(f.Id);
            if (updateaccount != null)
            {
                updateaccount.Name = f.Name;
                updateaccount.Email = f.Email;
                updateaccount.Password = f.Password;
                updateaccount.Education = f.Education;
                updateaccount.facultyimg = f.facultyimg;
            }
            _appcontext.SaveChanges();
            return RedirectToAction("ViewFaculty");
        }

        // Facultay Work End

        // Student Work Start

        // View
        public IActionResult AddStudent()
        {
            return View();
        }

        // Insert
        [HttpPost]
        public IActionResult AddStudent(Student s)
        {
            _appcontext.students.Add(s);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("StudentLogin");
        }

        public IActionResult StudentLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StudentLogin(Student s)
        {
            var studentdata = _appcontext.students.Where(data => data.Std_Roll_NO == s.Std_Roll_NO && data.Std_Name == s.Std_Name).FirstOrDefault();        
           
          if(studentdata != null)
                
            {
                return RedirectToAction("userdashboard");
            }
            return View();
        }

public IActionResult userdashboard()
        {
            return View();
        }

        // Fetch
        public IActionResult ViewStudent()
        {
            return View(_appcontext.students.ToList());
        }

        // Delete
        public IActionResult DeleteStudent(int Id)
        {
            Student s = _appcontext.students.Find(Id);
            _appcontext.students.Remove(s);
            _appcontext.SaveChanges();
            return RedirectToAction("ViewStudent");
        }

        // Update 
        public IActionResult UpdateStudent(int Id)
        {
            var updatestudent = _appcontext.students.Find(Id);
            return View(updatestudent);
        }

        // Update(Insert)
        [HttpPost]
        public IActionResult UpdateStudent(Student s)
        {
            var studentupdate = _appcontext.students.Find(s.Id);
            if(studentupdate != null)
            {
                studentupdate.Std_Name = s.Std_Name;
                studentupdate.Std_Roll_NO = s.Std_Roll_NO;
                studentupdate.Std_Class = s.Std_Class;
                studentupdate.Std_Specification = s.Std_Specification;
                studentupdate.Std_Section = s.Std_Section;
                studentupdate.Std_Admission_Date = s.Std_Admission_Date;
            }
            _appcontext.SaveChanges();
            return RedirectToAction("ViewStudent");
        }

        // Student Work End


        //FaQS Work Start

        public IActionResult addFaQs()
        {
            return View();
        }

        // Insert
        [HttpPost]
        public IActionResult addFaQs(FaQs f)
        {
            _appcontext.faQs.Add(f);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return View();
        }

        // Fetch
        public IActionResult viewFaQs()
        {
            return View(_appcontext.faQs.ToList());
        }

        // Delete
        public IActionResult faQsDelete(int id)
        {
            FaQs f = _appcontext.faQs.Find(id);
            _appcontext.faQs.Remove(f);
            _appcontext.SaveChanges();
            return RedirectToAction("viewFaQs");
        }

        // Update
        public IActionResult faQsEdit(int id)
        {
            var updateFaQs = _appcontext.faQs.Find(id);
            return View(updateFaQs);
        }

        // Update(insert)
        [HttpPost]
        public IActionResult faQsEdit(FaQs f)
        {
            var updateFaQs = _appcontext.faQs.Find(f.id);
            if (updateFaQs != null)
            {
                updateFaQs.Question = f.Question;
                updateFaQs.Answer = f.Answer;

          }
            _appcontext.SaveChanges();
            return RedirectToAction("viewFaQs");
        }

        // Admin Dashboard Work End

        // Student Dashboard Work Start

        // Fetch
        public IActionResult faQsForStudent()
        {
            return View(_appcontext.faQs.ToList());
        }
        // Fetch
        public IActionResult SurveyForStudent()
        {
            return View(_appcontext.surveys.ToList());
        }
       

        // Competition Work Start

        // View
        public IActionResult Competititon()
        {
            return View();
        }
        // Insert
        [HttpPost]
        public IActionResult Competititon(competition_ c)
        {
            competition data  = new competition();
            data.Competition_name = c.Competition_name;
            data.Competition_startdate = c.Competition_startdate;
            data.Competition_enddate = c.Competition_enddate;
            data.Competition_location = c.Competition_location;
            data.Competiton_type = c.Competiton_type.ToString(); 
            _appcontext.competitions.Add(data);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return View();
        }

        // User studentparticipate work start

        public IActionResult studentparticipate()
        {
            return View();
        }

        // Insert
        [HttpPost]
        public IActionResult studentparticipate(user u)
        {
            _appcontext.stdparticipate.Add(u);
            _appcontext.SaveChanges();
            ModelState.Clear();
            return View();
        }

        // Fetch 

        public IActionResult stdfetch()
        {
            return View(_appcontext.stdparticipate.ToList());
        }


        // Delete
        public IActionResult stdparticipatedelete(int id)
        {
            user u = _appcontext.stdparticipate.Find(id);
            _appcontext.stdparticipate.Remove(u);
            _appcontext.SaveChanges();
            return RedirectToAction("stdfetch");
        }

        // Update
        public IActionResult stdparticipateupdate(int id)
        {
            var updateparticipate = _appcontext.stdparticipate.Find(id);
            return View(updateparticipate);
        }

        // Update(insert)
        [HttpPost]
        public IActionResult stdparticipateupdate(user u)
        {
            var updateparticipate = _appcontext.stdparticipate.Find(u.Id);
            if (updateparticipate != null)
            {
                updateparticipate.Group_Name = u.Group_Name;
                updateparticipate.Group_Email = u.Group_Email;
                updateparticipate.Group_Contact = u.Group_Contact;
                updateparticipate.Group_Address = u.Group_Address;
                updateparticipate.Num_Of_prpoles = u.Num_Of_prpoles;

            }
            _appcontext.SaveChanges();
            return RedirectToAction("stdfetch");
        }

        // User studentparticipate work end
        // User Dashboard Work End
    }
}

