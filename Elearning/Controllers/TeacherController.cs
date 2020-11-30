using Elearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elearning.Controllers
{


    public class TeacherController : Controller
    {
        private eLearningDataContext db;


        string nom;
        string prenom;
        string age;
        string email;
        string niveau;

        string username;
        string password;
        string idEnseignant;

        string message;









        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View("Login");
        }


        [HttpPost]
        public ActionResult loginin(login log, FormCollection form)
        {
            username = log.username.ToString();
            password = log.password.ToString();

            db = new eLearningDataContext();



            var res = from Enseignant in db.Enseignants
                      where Enseignant.Username.Equals(username) && Enseignant.Password.Equals(password)
                      select new
                      {
                          Enseignant.Username,
                          Enseignant.Password,
                          Enseignant.idEnseignant
                      };

            string msg;

            foreach (var res2 in res)
            {
                if (username.Equals(res2.Username.ToString()) && password.Equals(res2.Password.ToString()))
                {

                    Session["username"] = username;
                    Session["password"] = password;
                    Session["idEnseignant"] = res2.idEnseignant;
       




                }
               
                else
                {

                    msg = "<script>alert('user does not exist ! Sign in ');</script>";

                    Response.Write(msg);


                }

            }

            if (res.Count() < 1)
            {
                msg = "<script>alert('user does not exist ! Sign in ');</script>";

                Response.Write(msg);
            }


            return RedirectToAction("list", "Teacher");


        }

        public ActionResult list()
        {
            db = new eLearningDataContext();


            if (Session["username"] != null)
            {

                return View(db.Cours.Where(s => s.idEnseignant.ToString().Equals( Session["idEnseignant"].ToString() ) ).ToList());
            }
            else
            {
                Session.Clear();
                return RedirectToAction("list", "Student");
            }


        }


        public ActionResult Create()
        {
            

            return View();
        }

        public ActionResult Delete(int id)
        {
            db = new eLearningDataContext();

            var DeleteID = from d in db.Cours
                           where d.idCours == id
                           select d;

            db.Cours.DeleteAllOnSubmit(DeleteID);
            db.SubmitChanges();


            return RedirectToAction("list", "Teacher");
        }



        public ActionResult Edit(int id)
        {
            db = new eLearningDataContext();

            var cours = db.Cours.Where(c => c.idCours == id).FirstOrDefault();
            return View(cours);
        }


        [HttpPost]
        public ActionResult Edit(Cour cr)
        {
            db = new eLearningDataContext();
            var cours = db.Cours.Where(s => s.idCours == cr.idCours).FirstOrDefault();
            db.Cours.DeleteOnSubmit(cours);
            db.SubmitChanges();
            db.Cours.InsertOnSubmit(cr);
            db.SubmitChanges();

            return RedirectToAction("list", "Teacher");
        }


        [HttpPost]
        public ActionResult insert(Cour c ,FormCollection form)
        {

            string Nom = c.Nom;
            string Laboratoire = c.Laboratoire;
            string Exercice = c.Exercice;
            string Quiz = c.Quiz;
            string Video = c.Video;
            string Niveau = c.Niveau;
            string NoteDeCours = c.NotesDeCours;




            Cour c1 = new Cour { Nom = Nom, Laboratoire = Laboratoire, Exercice = Exercice ,  Quiz = Quiz , Video = Video , Niveau = Niveau , NotesDeCours = NoteDeCours , idEnseignant = (int?)Session["idEnseignant"] };

            db = new eLearningDataContext();
            db.Cours.InsertOnSubmit(c1);
            db.SubmitChanges();

            return RedirectToAction("list", "Teacher");
        }
    }
}