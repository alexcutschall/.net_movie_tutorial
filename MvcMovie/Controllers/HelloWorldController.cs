using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome(String name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Welcome, {name}, NumTimes is {numTimes}");

        }
    }
}