using System;
using System.Drawing;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Drawing.Imaging;
using Diplom.Models;
using Diploma.Models;
using System.Text;
using System.Security.Cryptography;
using static Diploma.MvcApplication;

namespace Diploma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CryptoEncrypted()
        {
            return View();
        }



        algoritm)
 
[HttpPost]
        public ActionResult CryptoEncrypted(HttpPostedFileBase upload1, string key, string


            else if (algoritm == "TripleDES")
            {
                text = TripleDes.Encrypt<TripleDESCryptoServiceProvider>(text, key);
            }
            else if (algoritm == "Rijndael")
            {
                text = TripleDes.Encrypt<RijndaelManaged>(text, key);
            }
