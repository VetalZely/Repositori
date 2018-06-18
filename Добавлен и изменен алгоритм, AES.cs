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

{
            var baseLocation = Server.MapPath("~/Files/");

            var fileName1 = GetUniqueFileName(upload1.FileName);
            var fileLocation1 = Path.Combine(baseLocation, fileName1); upload1.SaveAs(fileLocation1);

            StreamReader sr = new StreamReader(fileLocation1, Encoding.Default); string text = sr.ReadToEnd();

            if (algoritm == "AES")
            {

                text = Crypto.EncryptStringAES(text, key);
            }
            else if (algoritm == "TripleDES")
            {
                text = TripleDes.Encrypt<TripleDESCryptoServiceProvider>(text, key);
            }
            else if (algoritm == "Rijndael")
            {
                text = TripleDes.Encrypt<RijndaelManaged>(text, key);
            }
