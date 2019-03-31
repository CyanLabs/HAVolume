using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace HA_Volume
{
    public class HAAPI
    {
        
        public static void POST(string servicetype, string servicename, string json)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Properties.Settings.Default.HAURL + "/api/services/" + servicetype + "/" + servicename);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.Headers.Add("Authorization", "Bearer " + Properties.Settings.Default.HAToken);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    MessageBox.Show("Connection to Home Assistant has been lost, please check connection and try again.", "HA Volume - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static dynamic GET([Optional] string entity)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            try
            {
                dynamic httpWebRequest;
                var result = "";
                if (String.IsNullOrEmpty(entity)) {
                    httpWebRequest = (HttpWebRequest)WebRequest.Create(Properties.Settings.Default.HAURL + "/api/states");
                } else {
                    httpWebRequest = (HttpWebRequest)WebRequest.Create(Properties.Settings.Default.HAURL + "/api/states/" + entity);
                }
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                httpWebRequest.Headers.Add("Authorization", "Bearer " + Properties.Settings.Default.HAToken);

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                return jsonSerializer.Deserialize<dynamic>((result));
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    MessageBox.Show("Connection to Home Assistant has been lost, please check connection and try again.", "HA Volume - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
                }
                return 99;
            }
        }
    }
}
