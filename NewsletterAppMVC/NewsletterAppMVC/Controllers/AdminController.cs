using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupvm = new SignupVm();
                    signupvm.Id = signup.Id;
                    signupvm.FirstName = signup.FirstName;
                    signupvm.LastName = signup.LastName;
                    signupvm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupvm);
                }

                return View(signupVms);
            }

        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var sighnup = db.SignUps.Find(Id);
                sighnup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}