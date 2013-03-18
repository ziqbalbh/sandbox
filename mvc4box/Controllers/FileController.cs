using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Controllers
{
    public class FileController : Controller
    {
        //
        // GET: /File/

        public ActionResult Index()
        {
            string address = Request["REMOTE_ADDR"];

            string data = FetchDetails(address);

            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);

            FileContentResult result = new FileContentResult(bytes, "application/octet-stream");
            
            result.FileDownloadName = "data.txt";

            return result;
        }

        private string FetchDetails(string ipAddress)
        {
            string data = "";

            data = FetchData(string.Format("/ip/{0}", ipAddress));

            return data;
        }

        private string FetchData(string resource)
        {
            using (WebClient client = new WebClient())
            {
                client.BaseAddress = "http://whois.arin.net/rest";

                return client.DownloadString(client.BaseAddress + resource);
            }
        }
    }
}
