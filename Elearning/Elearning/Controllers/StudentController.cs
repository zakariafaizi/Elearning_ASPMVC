﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Elearning.Models;
using System.Linq;
using System.Configuration.Assemblies;

namespace Elearning.Controllers
{
    public class StudentController : Controller
    {
  
        string nom;
        string prenom;
        string age;
        string email;
        string niveau;

        string username;
        string password;

        string message;


        private eLearningDataContext db;

    


        public ActionResult Home()
        {

            if(Session["username"] != null && (bool)Session["changed"] == true)
            {

                return View("Home");
            }
            else if(Session["username"] != null && (bool)Session["changed"] == false)
            {
                return View("Change");
            }
            else
            {
                return View("Index");
            }

       
        }

        public ActionResult Index()
        {

            
            return View();
        }




        public ActionResult Login()
        {

            return View("Login");
        }


        public ActionResult Change()
        {

            return View("Change");
        }



        private bool sendMail(Email email)
        {
            bool status = false;
            try
            {

                string MailSender = System.Configuration.ConfigurationManager.AppSettings["Mailsender"].ToString();
                string MailPw = System.Configuration.ConfigurationManager.AppSettings["Mailpw"].ToString();

                SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 100000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(MailSender, MailPw);

                MailMessage mailMessage = new MailMessage(MailSender, email.To, email.Subject, email.Message);
                mailMessage.BodyEncoding = System.Text.UTF8Encoding.UTF8;

                smtpClient.Send(mailMessage);

                status = true;
                return status;
            }

            catch (Exception ex)
            {
                return status;
            }

        }








        [HttpPost]
        public ActionResult inscription( Inscrire ins , FormCollection form)
        {

           
            
            nom = ins.nom.ToString();
            prenom = ins.prenom.ToString();
            age = ins.age.ToString();
            email = ins.email.ToString();
            niveau = form["niveauSelection"].ToString();



            username = usr(nom, prenom, age);                      //Call username generating function
            password = pswd(nom, prenom, age);                     //Call password generating function




                    
                                                                                     //EMAIL MESSAGE 
            message = "Hello there ,\nHere is your Username :" 
                    +" \n"
                    + username + "\nand here is your password : \n" 
                    + password + "\n\nNOTE THAT YOU MUST SET A NEW USERNAME AND PASSWORD ON YOUR FIRST LOGIN. \nTHANKS !";






            Email eml = new Email { To = email, Subject = "E-learning Username & Password", Message = message };

            string msg;

            if (sendMail(eml))
            {
                msg = "<script>alert('Username and Password sent to your email ! ');</script>";
                Response.Write(msg);

                Etudiant e1 = new Etudiant { Nom = nom, Prenom = prenom, Age = Convert.ToInt16(age), Email = email , Niveau = niveau , Username =username , Password = password , changedpw = 0 };

                db = new eLearningDataContext();
                db.Etudiants.InsertOnSubmit(e1);
                db.SubmitChanges();

           

            }
            else
            {
                msg = "<script>alert('Not sent ! ! ! RETRY ');</script>";
                Response.Write(msg);
            }


            return View("Login");
        }



        private string usr(string nom , string prenom , string age )
        {

            username = nom.Substring(0, 2).ToUpperInvariant() + (age.Substring(0) + 1 ) + prenom.Substring(0,2).ToUpperInvariant();

            return username;
        }


        private string pswd(string nom , string prenom , string age)
        {
            Random rnd = new Random();
            password =  "@"  + prenom.Substring(2,1) + rnd.Next();

            return password;
        }




        [HttpPost]
        public ActionResult loginin(login log, FormCollection form)
        {
            username = log.username.ToString();
            password = log.password.ToString();

            db = new eLearningDataContext();



            var res = from Etudiant in db.Etudiants
                      where Etudiant.Username.Equals(username) && Etudiant.Password.Equals(password)
                      select new
                      {
                          Etudiant.Username,
                          Etudiant.Password,
                          Etudiant.changedpw

                      };
            
            string msg;

            foreach (var res2 in res)
            {
               if(username.Equals(res2.Username.ToString()) && password.Equals(res2.Password.ToString()) && res2.changedpw == 1)
                {

                    Session["username"] = username;
                    Session["password"] = password;
                    Session["changed"] = true;
                   

                }
               else if(username.Equals(res2.Username.ToString()) && password.Equals(res2.Password.ToString()) && res2.changedpw == 0)
                {

                    Session["username"] = username;
                    Session["password"] = password;
                    Session["changed"]  = false;

                }
                else
                {

                    msg = "<script>alert('user does not exist ! Sign in ');</script>";

                    return View("Index");
                   

                }

            }

            if(res.Count() < 1)
            {
                msg = "<script>alert('user does not exist ! Sign in ');</script>";

                    return View("Index");
            }

            return Home();


        }




    }
}