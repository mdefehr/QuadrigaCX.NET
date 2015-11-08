using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuadrigaCX
{
    public class QuadrigaResultError : Exception
    {
        public int QuadrigaErrorCode { get; set; }
        public QuadrigaResultError()
        {}
        public QuadrigaResultError(string message):base(message)
        {}
        public QuadrigaResultError(string message, Exception inner):base(message,inner)
        {}
    }
    public class QuadrigaAPI
    {
        private string APIKey;
        private string Secret;
        private int ClientID;

        public QuadrigaAPI(int inClientID, string inAPIKey, string inSecret)
        {
            APIKey = inAPIKey;
            Secret = inSecret;
            ClientID = inClientID;
        }
        public QuadrigaAPI()
        {
        }

        public CurrentTradingInformation GetCurrentTradingInformation(string book = "btc_cad", bool localtime = true)
        {
            dynamic r = SimpleJsonWebRequest("https://api.quadrigacx.com/v2/ticker?book=" + book);
            processError(r);
            return CurrentTradingInformation.GetFromJson(r, localtime);
        }        
        public OrderBook GetOrderBook(string book = "btc_cad", bool group = true, bool localtime = true)
        {
            var r = SimpleJsonWebRequest("https://api.quadrigacx.com/v2/order_book?book=" + book + "&group=" + (@group ? "1" : "0"));
            processError(r);
            return OrderBook.GetFromJson(r,localtime);
        }        
        public IEnumerable<Transaction> GetTransactions(string book = "btc_cad", string time = "hour", bool localtime = true)
        {
            dynamic r = SimpleJsonWebRequest("https://api.quadrigacx.com/v2/transactions?book=" + book + "&time=" + time);
            processError(r);
            List<Transaction> l = new List<Transaction>();
            foreach (dynamic tran in r)
            {
                l.Add(Transaction.GetFromJson(tran,localtime));
                //string c = class_ify(o, "Transaction");
            }
            return l;
        }
        
        public AccountBalance GetAccountBalance()
        {
            dynamic r = JsonWebRequestWithAuthentication("https://api.quadrigacx.com/v2/balance", "POST");
            processError(r);
            return AccountBalance.GetFromJson(r);
        }
        public IEnumerable<UserTransaction> GetUserTransactions(int offset = 0, int limit = 100, string sort = "desc", string book = "btc_cad")
        {
            string additionaljsonparameters =
                String.Format(@", ""offset"": ""{0}"", ""limit"": ""{1}"", ""sort"": ""{2}"", ""book"": ""{3}""", 
                                offset,limit, sort, book);
            dynamic r = JsonWebRequestWithAuthentication("https://api.quadrigacx.com/v2/user_transactions", "POST",additionaljsonparameters);
            processError(r);
            List<UserTransaction> l = new List<UserTransaction>();
            foreach (dynamic tran in r)
            {
                l.Add(UserTransaction.GetFromJson(tran));
            }
            return l;
        }
        public IEnumerable<OpenOrder> GetOpenOrders(string book = "btc_cad")
        {
            string additionaljsonparameters =
                String.Format(@", ""book"": ""{0}""", book);
            dynamic r = JsonWebRequestWithAuthentication("https://api.quadrigacx.com/v2/open_orders", "POST",additionaljsonparameters);
            processError(r);
            List<OpenOrder> l = new List<OpenOrder>();
            foreach (dynamic tran in r)
            {
                l.Add(OpenOrder.GetFromJson(tran, book));
            }
            return l;
        }
        public IEnumerable<OpenOrder> LookupOrder(string orderid)
        {
            string additionaljsonparameters =
                String.Format(@", ""id"": ""{0}""", orderid);
            dynamic r = JsonWebRequestWithAuthentication("https://api.quadrigacx.com/v2/lookup_order", "POST", additionaljsonparameters);
            processError(r);
            List<OpenOrder> l = new List<OpenOrder>();
            foreach (dynamic tran in r)
            {
                processError(tran);
                l.Add(OpenOrder.GetFromJson(tran, tran.book.ToString()));
            }
            return l;
        }
        public string CancelOrder(string orderid)
        {
            string additionaljsonparameters =
                String.Format(@", ""id"": ""{0}""", orderid);
            dynamic r = JsonWebRequestWithAuthentication("https://api.quadrigacx.com/v2/cancel_order", "POST", additionaljsonparameters);
            processError(r);
            return r.ToString();
        }
        public OpenOrder BuyOrderLimit(decimal amount, decimal price, string book)
        {
            string additionaljsonparameters =
                String.Format(@", ""amount"": ""{0}"", ""price"": ""{1}"", ""book"": ""{2}""", amount, price, book);
            dynamic r = JsonWebRequestWithAuthentication("https://api.quadrigacx.com/v2/buy", "POST", additionaljsonparameters);
            processError(r);
            return OpenOrder.GetFromJson(r, book);
        }
        public OpenOrder SellOrderLimit(decimal amount, decimal price, string book)
        {
            string additionaljsonparameters =
                String.Format(@", ""amount"": ""{0}"", ""price"": ""{1}"", ""book"": ""{2}""", amount, price, book);
            dynamic r = JsonWebRequestWithAuthentication("https://api.quadrigacx.com/v2/sell", "POST", additionaljsonparameters);
            processError(r);
            return OpenOrder.GetFromJson(r, book);
        }

        private void processError(dynamic jsonobject)
        {
            QuadrigaResultError e = null;
            try
            {
                dynamic jerror = jsonobject.error;
                string msg = jerror.message;
                e = new QuadrigaResultError(msg);
                e.QuadrigaErrorCode = jerror.code;
            }
            catch (Exception)
            {
            }
            if (e != null) throw e;
        }
        private string class_ify(dynamic jsonobject, string classname = "ClassName")
        {
            string propertylist = "";
            string assignlist = "";
            foreach (dynamic item in jsonobject)
            {
                propertylist = propertylist + "        public string " + item.Name + " { get; set; }" + '\r';;
                assignlist = assignlist + "                " + item.Name + " = APICallResult." + item.Name + "," + '\r';
            }
            assignlist = assignlist.Trim('\r');
            assignlist = assignlist.Trim(',');

            string template = @"public class <classname>
    {
<PropertyList>
        public static <classname> GetFromJson(dynamic APICallResult)
        {
            return new <classname>
            {
<AssignList>
            };
        }
    }";
            template = template.Replace("<PropertyList>", propertylist);
            template = template.Replace("<AssignList>", assignlist);
            template = template.Replace("<classname>", classname);
            return template;
        }
        private dynamic SimpleJsonWebRequest(string url)
        {
            var webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            if (webRequest != null)
            {
                using (WebResponse response = webRequest.GetResponse())
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    dynamic returnData = JsonConvert.DeserializeObject(reader.ReadToEnd());
                    //string c = class_ify(returnData, "CurrentTradingInformation");
                    return returnData;
                }
            }
            return null;
        }
        private dynamic JsonWebRequestWithAuthentication(string url, string method, string additionaljsonparameters = "")
        {
            var webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            if (webRequest != null)
            {
                
                string nonce = Convert.ToInt64(DateTime.Now.Ticks).ToString();

                string message = nonce + ClientID + APIKey;
                string secrethash = CalculateMD5Hash(Secret).ToLower();
                string signature = HashEncode(HashHMAC(StringEncode(secrethash), StringEncode(message)));
                string datastring = "{" + string.Format(@" ""key"": ""{0}"", ""nonce"": ""{1}"", ""signature"": ""{2}""", APIKey, nonce, signature) + additionaljsonparameters + " }";

                webRequest.Method = method;
                webRequest.ContentType = "application/json";
                webRequest.ContentLength = datastring.Length;

                using (StreamWriter sw = new StreamWriter(webRequest.GetRequestStream()))
                    sw.Write(datastring);


                using (WebResponse response = webRequest.GetResponse())
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    return JsonConvert.DeserializeObject(reader.ReadToEnd());
                }
            }
            return null;
        }
        private static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        private static string HashEncode(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
        private static byte[] HashHMAC(byte[] key, byte[] message)
        {
            var hash = new HMACSHA256(key);
            return hash.ComputeHash(message);
        }
        private static byte[] StringEncode(string text)
        {
            var encoding = new ASCIIEncoding();
            return encoding.GetBytes(text);
        }


    }
}
