using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MagicHue___Controler
{
    public class MagicHueAPI
    {

        #region import

        private static HttpWebResponse httpResponse;
        private static WebRequest Request;

        private static StreamReader SR;
        private static StreamWriter SW;
        private static string json;
        private static string result;
        private static string hexData;

        private static User User = new User();

        #endregion

        private static WebRequest createClient(string call)
        {

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(call);
            httpWebRequest.UserAgent = "Magic Home/1.4.6(ANDROID,9,fr-FR)";
            httpWebRequest.ContentType = "application/json; charset=utf-8";
            httpWebRequest.Headers.Add("token", User.token);

            return httpWebRequest;

        }

        public bool Login(string mail, string pass)
        {

            Request = createClient("https://wifij01us.magichue.net/app/login/ZG001");
            Request.Method = "POST";

            using (SW = new StreamWriter(Request.GetRequestStream()))
            {
                json = "{\"userID\":\"" + mail + "\",\"password\":\"" + Utility.MD5Hash(pass) + "\",\"clientID\":\"cf3b2d99ee1e2bb4unknown\"}";
                SW.Write(json);
                SW.Flush();
            }

            try
            {
                using (httpResponse = (HttpWebResponse)Request.GetResponse())
                using (SR = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = SR.ReadToEnd();
                }
            }
            catch (Exception) { }

            User = JsonConvert.DeserializeObject<User>(result);

            return User.code == 0;

        }

        public DeviceInfo[] GetAssociatedDevices()
        {

            var Request = createClient("http://wifij01eu.magichue.net/app/getMyBindDevices/ZG001");
            Request.Method = "GET";

            using (var webResponse = Request.GetResponse())
            using (var webStream = webResponse.GetResponseStream())
            using (SR = new StreamReader(webStream))
            {
                result = SR.ReadToEnd();
            };

            return JsonConvert.DeserializeObject<Device>(result).data;


        }

        public string GetCRC8256_color(hexDataColor Color)
        {
            int sum =  0x31 + Color.R + Color.G + Color.B + 0xf;
                sum %= 0x100;

            return sum.ToString("X");
        }

        public void TurnOn(string MAC, hexDataColor Color)
        {

            Request = createClient("http://wifij01eu.magichue.net/app/sendCommandBatch/ZG001");
            Request.Method = "POST";

            hexData = string.Format("31{0}{1}{2:X}", Color.getColor(), "00000F", GetCRC8256_color(Color));

            using (SW = new StreamWriter(Request.GetRequestStream()))
            {
                json = "{\"dataCommandItems\":[{\"hexData\":\"" + hexData + "\",\"macAddress\":\"" + MAC + "\"}]}";
                SW.Write(json);
                SW.Flush();
            }
            try
            {
                httpResponse = (HttpWebResponse)Request.GetResponse();
                using (SR = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string result = SR.ReadToEnd();
                }
            }
            catch (Exception) { }

        }

        public void TurnOff(String MAC)
        {

            Request = createClient("http://wifij01eu.magichue.net/app/sendCommandBatch/ZG001");
            Request.Method = "POST";

            using (SW = new StreamWriter(Request.GetRequestStream()))
            {
                json = "{\"dataCommandItems\":[{\"hexData\":\"71240fa4\",\"macAddress\":\"" + MAC + "\"}]}";
                SW.Write(json);
                SW.Flush();
            }
            try
            {
                httpResponse = (HttpWebResponse)Request.GetResponse();
                using (SR = new StreamReader(httpResponse.GetResponseStream()))
                {
                    string result = SR.ReadToEnd();
                }
            }
            catch (Exception) { }

        }

        public bool IsLogged()
        {
            return User.code == 0;
        }


    }

    public class hexDataColor
    {

        public Int32 R { get; set; }
        public Int32 G { get; set; }
        public Int32 B { get; set; }
        public int brightness { get; set; }

        public string getColor()
        {
            return string.Format("{0:X2}{1:X2}{2:X2}", R, G, B);
        }

        public hexDataColor(int r, int g, int b, int bt)
        {
            this.R = r*bt/100;
            this.G = g*bt/100;
            this.B = b*bt/100;

        }


    }

    public class Utility
    {
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

        public static string MD5Hash(string tohash)
        {

            StringBuilder hashy = new StringBuilder();
            MD5CryptoServiceProvider MD5P = new MD5CryptoServiceProvider();
            byte[] bytes = MD5P.ComputeHash(new UTF8Encoding().GetBytes(tohash));

            for (int i = 0; i < bytes.Length; i++)
            {
                hashy.Append(bytes[i].ToString("x2"));
            }
            return hashy.ToString();


        }

        public static string GetMacAddress(string IP)
        {

            IPAddress hostIPAddress = IPAddress.Parse(IP);
            byte[] ab = new byte[6];
            int len = ab.Length,
                r = SendARP((int)hostIPAddress.Address, 0, ab, ref len);
            return BitConverter.ToString(ab, 0, 6).Replace("-", string.Empty);


        }

    }

    public class User
    {
        public int code { get; set; }
        public string msg { get; set; }
        public UserData data { get; set; }
        public string token { get; set; }

    }

    public class UserData
    {
        public string webApi { get; set; }
        public string webPathOta { get; set; }
        public string tcpServerController { get; set; }
        public string tcpServerBulb { get; set; }
        public string tcpServerControllerOld { get; set; }
        public string tcpServerBulbOld { get; set; }
        public string sslMqttServer { get; set; }
        public string serverName { get; set; }
        public string serverCode { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userUniID { get; set; }
    }


}