using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login
{
    internal class FileServerConnect
    {
        //buildFTPConnection
        //client.Credentials = new NetworkCredential("ftpserveruser", "mygrind400");
        //            string url = "ftp://192.168.2.36/abc";
        //            client.UploadFile(url, @"C:\Users\kefid\OneDrive\Bilder\dondacover.png");

        public string UploadFile(string FtpUrl, string fileName, string userName, string password, string
     UploadDirectory = "")
        {
            string PureFileName = new FileInfo(fileName).Name;
            String uploadUrl = String.Format("{0}{1}/{2}", FtpUrl, UploadDirectory, PureFileName);
            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(uploadUrl);
            req.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback =
                      (s, certificate, chain, sslPolicyErrors) => true;
            req.Proxy = null;
            req.Method = WebRequestMethods.Ftp.UploadFile;
            req.Credentials = new NetworkCredential(userName, password);
            req.UseBinary = true;
            req.UsePassive = true;
            byte[] data = System.IO.File.ReadAllBytes(fileName);
            req.ContentLength = data.Length;
            Stream stream = req.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();
            FtpWebResponse res = (FtpWebResponse)req.GetResponse();
            return res.StatusDescription;
        }

    }
}
