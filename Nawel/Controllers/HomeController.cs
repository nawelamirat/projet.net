using Nawel.Models;
using Nawel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nawel.Controllers
{
    public class HomeController : Controller
    {
        IDal dal = new Dal();
        // GET: Home
        public ActionResult Index()
        {
            /* envoi de variabe à la vue avec le tableau viewData*/
            ViewData["nom"] = "Nawel";
            ViewData["dateNow"] = DateTime.Now;
            return View();
        }
        public ActionResult CreateUser()
        {
            /*création d'un utilisateur*/
            dal.createUser("0648512812", "Nawel");
            return View();
        }

        public ActionResult Listuser()
        {
            /*on a déclarer une lsite d'utilisateur vide*/
            List<User> malist = new List<User>();
            /*on utilise la méthode getAllUsers du DAL qu'on a nous même crée pour récupéré 
            la list de tout les utilisateurs */
            malist = dal.getAllUsers();

            /*déclaration d'un objet vide de type ViewModelListUser qui va nous servir de "colis" pour envoyer
            des trucs a la vue*/
            ViewModelListUser ViewModel = new ViewModelListUser();
            /*on met dans le "colis" notre liste d'utilisateur dans l'atribut spécifique */
            ViewModel.Users = malist;
            return View(ViewModel);
        }
    }
}