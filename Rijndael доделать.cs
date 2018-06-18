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

