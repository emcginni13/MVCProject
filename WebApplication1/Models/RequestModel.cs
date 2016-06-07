using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace WebApplication1.Models
{
    public class RequestModel 
    {
        public string HttpRequest(string url, string contentT, string body, string method)
        {
            string newline;  
            HttpWebRequest webRequest;
            webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("Authorization", "Bearer UTy4l_VkcUXYUsPBdUUnoL6aWPqSWY9dLA");
            if (body != null)
            {
                webRequest.Method = method;
                webRequest.ContentType = contentT;
                var payload = UTF8Encoding.UTF8.GetBytes(body);
                using (var stream = webRequest.GetRequestStream())
                {
                    stream.Write(payload, 0, payload.Length);
                }
            }
            //create stream for json response
            Stream requestStream;
            requestStream = webRequest.GetResponse().GetResponseStream();
            StreamReader apiReader = new StreamReader(requestStream);
            //read lines from stream
            newline = apiReader.ReadLine();
            requestStream.Close();
            apiReader.Close();
            return newline;
        }
    }
}