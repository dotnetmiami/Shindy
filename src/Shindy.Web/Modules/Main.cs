using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;

namespace Shindy.Web.Modules
{
    public class Main :NancyModule
    {
        public Main()
        {
            Get["/"] = x =>
            {
                return View["Index"];
            };
        }

    }
}