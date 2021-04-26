
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ISS.Warning.Extras
{
    class FileSystemManager
    {
        public string baseUrl = "ftp://172.16.16.84/";
        public string user = "administrator";
        public string password = "hotelh.123";
        public WebClient ftpAlt()
        {
            WebClient request = new WebClient();
            request.Credentials = new NetworkCredential("administrator", "hotelh.123");
            return request;
        }

        public string template(string template)
        {
            var str = "";
            try
            {
                var request = this.ftpAlt();
                var urlr = $"ftp://172.16.16.84/Documento/Email/{template}";
                byte[] newFileData = request.DownloadData(urlr);
                //string base64String = Convert.ToBase64String(newFileData);
                str = Encoding.UTF8.GetString(newFileData);
            }
            catch (Exception ex)
            {
                str = "";
            }
            return str;

        }
    }
}
