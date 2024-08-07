using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string strtmp = "Duplicate entry '822091504-70004637-C00056931' for key 'PRIMARY'";
            //string[] strTmps = strtmp.Split('\'');
            ////string strtmp2 = strTmps[1];
            ////string[] strTmps2 = strtmp2.Split('-');

            ////for (int i = 0; i < strTmps2.Length; i++)
            ////{
            ////    Console.WriteLine(strTmps2[i]);
            ////}


            //if (strTmps.Count() > 2)
            //{
            //    string strtmp2 = strTmps[1];
            //    string[] strTmps2 = strtmp2.Split('-');
            //    if (strTmps2.Count() >= 3)
            //    {
            //        Console.WriteLine($"活动编码：{strTmps2[0]}，大区：{strTmps2[1]}，客户系列：{strTmps2[2]}已经存在！");
            //    }
            //}

            //int maxSellinNo = 57;

            //for (int i = 0; i < 5; i++)
            //{
            //    var orderSellinNoO = "000" + (i + 1 + maxSellinNo);
            //    var orderSellinNo = orderSellinNoO.Substring(orderSellinNoO.Length - 4);
            //    var SellinNo = "C822090808" + orderSellinNo;
            //    Console.WriteLine(SellinNo);
            //}

            //List<string> abc = new List<string>() { "4", "3", "2", "1" };
            //Console.WriteLine(JsonConvert.SerializeObject(abc));

            //List<string> abc = new List<string>() {  };
            //Console.WriteLine(JsonConvert.SerializeObject(abc?.First()));

            //DateTime dateNow = DateTime.Now;
            //var weekStart = dateNow.AddDays(-(int)dateNow.DayOfWeek + 1).Date;
            //var weekEnd = weekStart.AddDays(7).AddSeconds(-1);
            //Console.WriteLine("weekStart:" + weekStart  );
            //Console.WriteLine("weekEnd:" + weekEnd);

            //Console.WriteLine(((int)DateTime.Now.DayOfWeek).ToString());

            //DateTime dateNow = DateTime.Now;
            //DateTime firstDay = dateNow.AddDays(-7 + (int)dateNow.DayOfWeek).Date;
            //DateTime lastDay = firstDay.AddDays(7);
            //Console.WriteLine(dateNow.AddDays(-7 + (int)dateNow.DayOfWeek).Date);

            //List<int> listA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<int> listB = new List<int>() { 1, 2, 3, 4, 9 };
            //var resultExceptList = listB.Except(listA);
            //Console.WriteLine(string.Join(",", resultExceptList));

            ////DateTime abc = DateTime.Now;
            //DateTime abc = Convert.ToDateTime("2022-12-9");
            ////Console.WriteLine(abc.AddDays( 1- (int)abc.DayOfWeek).Date);
            //Console.WriteLine(abc.AddDays(8 - (int)abc.DayOfWeek).Date.AddSeconds(-1));


            //DateTime abc = DateTime.Now;//.AddDays(6);
            //DateTime abc = DateTime.Now.AddDays(2);

            //DateTime abcb = Convert.ToDateTime("2022-12-10");
            //Console.WriteLine(abcb.Date);

            //int abcc = (int)abcb.DayOfWeek;
            //Console.WriteLine(abcc);
            ////Console.WriteLine(abc.AddDays(1 - (int)abc.DayOfWeek).Date);

            //DateTime datetime = DateTime.Now.AddDays(7);// Convert.ToDateTime("2022-12-5");
            //int thisDay = (int)datetime.DayOfWeek == 0 ? 7 : (int)datetime.DayOfWeek;
            //Console.WriteLine(datetime.AddDays(1 - thisDay).Date);

            //foreach (var item in "123456".Split(','))
            //    Console.WriteLine(item);

            //DateTime dt = DateTime.ParseExact("2022122009370000", "yyyyMMddHHmmssff", System.Globalization.CultureInfo.CurrentCulture);
            //Console.WriteLine(dt);
            //Console.WriteLine(Convert.ToDateTime("2022-1-1"));
            //Console.WriteLine((int)DateTime.Now.DayOfWeek);
            //Console.WriteLine((int)Convert.ToDateTime("2023-1-15").DayOfWeek);

            //List<string> list = new List<string>();
            //list.Add("1");
            //list.Add("2");
            //list.Add("3");
            //Console.WriteLine("\""+String.Join("\",\"", list)+ "\"");

            //var reqResult = JsonConvert.DeserializeObject<AisinoResponse>("{\"operateCode\":\"S\",\"message\":\"开票成功\",\"datas\":{\"orderNo\":\"6331919663383552\",\"serialNo\":6331919663432704},\"pageAndSort\":null}");
            //var abc = reqResult.datas;
            //string serialNo = ((dynamic)abc).serialNo;
            //Console.WriteLine(serialNo);

            //Console.WriteLine(Convert.ToDateTime("2023/2/10+8:38:00"));

            //decimal? InvoiceAmount = 780000M;
            //decimal MaxInvoiceAmount = 100000M;

            //if (InvoiceAmount>0)
            //{
            //    decimal parseAmount=Convert.ToDecimal(InvoiceAmount);
            //    decimal reqTimes = Math.Ceiling(parseAmount / MaxInvoiceAmount);

            //    if (parseAmount > MaxInvoiceAmount)
            //        for (int i = 0; i < reqTimes; i++)
            //        {
            //            if (i == reqTimes - 1)
            //            {
            //                Console.WriteLine(parseAmount - i * MaxInvoiceAmount);
            //            }
            //            else
            //            {
            //                Console.WriteLine(MaxInvoiceAmount);
            //            }
            //        }
            //}

            //var orderNo = ("858984651-0").Split('-')[0];
            //Console.WriteLine(orderNo);

            //RedisHelper redisHelper = new RedisHelper("127.0.0.1:6379");
            //string value = "abcdefg";
            //bool r1 = redisHelper.SetValue("mykey", value);
            //string saveValue = redisHelper.GetValue("mykey");
            //Console.WriteLine(saveValue);
            //bool r2 = redisHelper.SetValue("mykey", "NewValue");
            //saveValue = redisHelper.GetValue("mykey");
            //Console.WriteLine(saveValue);

            //Console.WriteLine(redisHelper.GetValue("test"));
            ////bool r3 = redisHelper.DeleteKey("mykey");
            ////string uncacheValue = redisHelper.GetValue("mykey");

            //var todayKey = "UserQueuing_" + DateTime.Now.ToString("yyyy-MM-dd");
            //Console.WriteLine(todayKey);

            //string strCmdText;
            //strCmdText = "start cmd /K \"cd /d D:\\Code\\WanLink\\WanlinkCore\\WanLink.E-Book.Web\\Web && npm run ssr\"";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //HttpWebRequest myReq = (HttpWebRequest)HttpWebRequest.Create("https://www.bestedm.net/mm-ms/apinew/mloperate.php?do=maillist-list");
            //string username = "UMailB06";
            //string password = "GHIjkl741";
            ////注意这里的格式哦，为 "username:password"
            //string usernamePassword = username + ":" + password;
            //CredentialCache mycache = new CredentialCache();
            //mycache.Add(new Uri("https://www.bestedm.net/mm-ms/apinew/mloperate.php?do=maillist-list"), "Basic", new NetworkCredential(username, password));
            //myReq.Credentials = mycache;
            //myReq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(usernamePassword)));
            //WebResponse wr = myReq.GetResponse();
            //Stream receiveStream = wr.GetResponseStream();
            //StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            //string content = reader.ReadToEnd();



            //UMailResponse test2 = XmlSerializeHelper.Serialize<UMailResponse>("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n   <result>\r\n      <status>\r\n         success\r\n      </status>\r\n      <data>\r\n         1020647\r\n      </data>\r\n</result>");

            //string result = XmlSerializeHelper.Serialize<UMailResponse>(new UMailResponse
            //{
            //    status = "Seven",
            //    data = "663927",
            //});
            //Console.WriteLine(result);
            //UMailResponse test2 = XmlSerializeHelper.DeSerialize<UMailResponse>("<?xml version=\"1.0\" encoding=\"UTF-8\"?><result><status>success</status><data>1021544</data></result>");


            //var client = new RestClient($"https://api.bestedm.net/mm-ms/apinew/template.php?do=tpl-attachment-add&tpl_id=1021564");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Authorization", " Basic MTAwMDBsaW5rOjEwMDAwbGluaw==");
            //request.AddHeader("content-type", "multipart/form-data; boundary=---011000010111000001101001");
            //request.AddParameter("multipart/form-data; boundary=---011000010111000001101001", "-----011000010111000001101001\r\nContent-Disposition: form-data; name=\"file\"\r\n\r\nC:\\Users\\Administrator\\Downloads\\1623570712369565697 (3).pdf\r\n-----011000010111000001101001--\r\n\r\n", ParameterType.RequestBody);
            //request.AddFile("File", "C:\\Users\\Administrator\\Downloads\\1623570712369565697 (3).pdf");
            //IRestResponse response = client.Execute(request);

            //var client = new RestClient("https://api.bestedm.net/mm-ms/apinew/template.php?do=tpl-attachment-add&tpl_id=1021564");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Authorization", "Basic MTAwMDBsaW5rOjEwMDAwbGluaw==");
            //request.AddFile("file", "C:\\Users\\Administrator\\Downloads\\1623570712369565697 (3).pdf");
            //request.AddFile("file", "C:\\Users\\Administrator\\Downloads\\SAP EDI订单20230111095201.xlsx");
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);
            //UMailResponse resSet = XmlSerializeHelper.DeSerialize<UMailResponse>(response.Content);
            //var abc = resSet.data;


            //OpenDetailRes resSet = XmlSerializeHelper.DeSerialize<OpenDetailRes>("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<data>\r\n<user>\r\n<email_id>14</email_id>\r\n<email>995841965@qq.com</email>\r\n<browser>Chrome Mobile WebView 92.0.4515</browser>\r\n<os>Android </os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|北京北京</addr_first>\r\n<ip_first>223.104.237.93</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 09:50:43</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>15</email_id>\r\n<email>499453217@qq.com</email>\r\n<browser>Mobile Safari UI/WKWebView 16.5</browser>\r\n<os>iOS 16.5</os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|甘肃嘉峪关</addr_first>\r\n<ip_first>42.88.167.122</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 09:51:34</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>16</email_id>\r\n<email>huangyu@dnb.com</email>\r\n<browser>Chrome 100.0.4896</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>40.94.29.86</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>10</click_total>\r\n<open_first>2023-06-13 09:52:03</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:52:03</click_first>\r\n<click_last>2023-06-13 09:52:04</click_last>\r\n</user>\r\n<user>\r\n<email_id>17</email_id>\r\n<email>zhangsi@sf-express.com</email>\r\n<browser>Chrome 111.0.0</browser>\r\n<os>Windows 7</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>54.70.53.60</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>15</click_total>\r\n<open_first>2023-06-13 09:52:13</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:52:13</click_first>\r\n<click_last>2023-06-13 09:52:30</click_last>\r\n</user>\r\n<user>\r\n<email_id>18</email_id>\r\n<email>13641842827@163.com</email>\r\n<browser>Chrome 69.0.3497</browser>\r\n<os>Windows 7</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|上海上海</addr_first>\r\n<ip_first>183.194.69.30</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 09:52:34</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>19</email_id>\r\n<email>bgao@gfscold.com</email>\r\n<browser>Chrome 86.0.4240</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>40.77.57.90</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>9</click_total>\r\n<open_first>2023-06-13 09:53:23</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:53:23</click_first>\r\n<click_last>2023-06-13 09:53:23</click_last>\r\n</user>\r\n<user>\r\n<email_id>20</email_id>\r\n<email>mashuang@bosc.cn</email>\r\n<browser>Chrome 113.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>34.213.235.11</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>16</click_total>\r\n<open_first>2023-06-13 09:53:30</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:53:30</click_first>\r\n<click_last>2023-06-13 09:53:31</click_last>\r\n</user>\r\n<user>\r\n<email_id>21</email_id>\r\n<email>hongfei@cmbc.com.cn</email>\r\n<browser>Chrome 113.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>34.210.84.51</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>15</click_total>\r\n<open_first>2023-06-13 09:54:29</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:54:29</click_first>\r\n<click_last>2023-06-13 09:54:30</click_last>\r\n</user>\r\n<user>\r\n<email_id>22</email_id>\r\n<email>gavin.du@c2fo.com</email>\r\n<browser>Chrome 86.0.4240</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>40.94.28.68</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>10</click_total>\r\n<open_first>2023-06-13 09:54:49</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:54:49</click_first>\r\n<click_last>2023-06-13 09:54:50</click_last>\r\n</user>\r\n<user>\r\n<email_id>23</email_id>\r\n<email>nancytang@sfmail.sf-express.com</email>\r\n<browser>Firefox 111.0</browser>\r\n<os>Windows 7</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>54.71.187.124</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>15</click_total>\r\n<open_first>2023-06-13 09:55:28</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:55:28</click_first>\r\n<click_last>2023-06-13 09:55:49</click_last>\r\n</user>\r\n<user>\r\n<email_id>24</email_id>\r\n<email>wanggang.js@ccb.com</email>\r\n<browser>Chrome 113.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>35.91.181.42</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>33</click_total>\r\n<open_first>2023-06-13 09:55:30</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:55:30</click_first>\r\n<click_last>2023-06-13 09:59:34</click_last>\r\n</user>\r\n<user>\r\n<email_id>25</email_id>\r\n<email>hanyouwei@kxjf.com</email>\r\n<browser>Chrome 113.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>35.163.149.35</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>14</click_total>\r\n<open_first>2023-06-13 09:55:38</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:55:38</click_first>\r\n<click_last>2023-06-13 09:55:44</click_last>\r\n</user>\r\n<user>\r\n<email_id>26</email_id>\r\n<email>liangjianhong@sfmail.sf-express.com</email>\r\n<browser>Chrome 111.0.0</browser>\r\n<os>Windows 7</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>54.70.53.60</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>15</click_total>\r\n<open_first>2023-06-13 09:55:44</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:55:44</click_first>\r\n<click_last>2023-06-13 09:56:08</click_last>\r\n</user>\r\n<user>\r\n<email_id>27</email_id>\r\n<email>wangyj20@bosc.cn</email>\r\n<browser>Chrome 113.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>35.89.120.36</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>16</click_total>\r\n<open_first>2023-06-13 09:56:06</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:56:06</click_first>\r\n<click_last>2023-06-13 09:56:07</click_last>\r\n</user>\r\n<user>\r\n<email_id>28</email_id>\r\n<email>shiyuxue@sfmail.sf-express.com</email>\r\n<browser>Chrome 111.0.0</browser>\r\n<os>Windows 7</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>54.71.187.124</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>16</click_total>\r\n<open_first>2023-06-13 09:56:23</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:56:23</click_first>\r\n<click_last>2023-06-13 09:58:08</click_last>\r\n</user>\r\n<user>\r\n<email_id>29</email_id>\r\n<email>383651647@qq.com</email>\r\n<browser>Chrome Mobile WebView 92.0.4515</browser>\r\n<os>Android </os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|北京北京</addr_first>\r\n<ip_first>39.144.138.249</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 09:56:51</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>30</email_id>\r\n<email>yuruifen@shrbank.com</email>\r\n<browser>Chrome 113.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>54.218.111.230</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>32</click_total>\r\n<open_first>2023-06-13 09:56:58</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:56:58</click_first>\r\n<click_last>2023-06-13 09:59:48</click_last>\r\n</user>\r\n<user>\r\n<email_id>31</email_id>\r\n<email>chejing@dxil.com.cn</email>\r\n<browser>Chrome 75.0.3770</browser>\r\n<os>Windows 8</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|江苏苏州常熟</addr_first>\r\n<ip_first>49.72.21.195</ip_first>\r\n<ip_last>49.72.21.195</ip_last>\r\n<addr_last>亚洲|中国|江苏苏州常熟</addr_last>\r\n<open_total>2</open_total>\r\n<click_total>1</click_total>\r\n<open_first>2023-06-13 09:57:02</open_first>\r\n<open_last>2023-06-13 10:38:52</open_last>\r\n<click_first>2023-06-13 10:39:42</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>32</email_id>\r\n<email>13318165101@189.cn</email>\r\n<browser>Chrome 89.0.4389</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|广东东莞</addr_first>\r\n<ip_first>183.61.185.72</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>5</click_total>\r\n<open_first>2023-06-13 09:57:13</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:57:13</click_first>\r\n<click_last>2023-06-13 09:57:23</click_last>\r\n</user>\r\n<user>\r\n<email_id>33</email_id>\r\n<email>chendi@shrbank.com</email>\r\n<browser>Chrome 113.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>35.86.145.198</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>29</click_total>\r\n<open_first>2023-06-13 09:57:28</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:57:28</click_first>\r\n<click_last>2023-06-13 10:00:25</click_last>\r\n</user>\r\n<user>\r\n<email_id>34</email_id>\r\n<email>yizl@szu.edu.cn</email>\r\n<browser>IE 11.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|广东深圳</addr_first>\r\n<ip_first>210.39.3.5</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 09:58:02</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>35</email_id>\r\n<email>max.zhang@c2fo.com</email>\r\n<browser>Chrome 102.0.5005</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>40.94.34.50</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>10</click_total>\r\n<open_first>2023-06-13 09:58:17</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 09:58:17</click_first>\r\n<click_last>2023-06-13 09:58:18</click_last>\r\n</user>\r\n<user>\r\n<email_id>36</email_id>\r\n<email>15305692167@189.cn</email>\r\n<browser>Chrome 89.0.4389</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|广东东莞</addr_first>\r\n<ip_first>183.61.185.72</ip_first>\r\n<ip_last>183.61.185.72</ip_last>\r\n<addr_last>亚洲|中国|广东东莞</addr_last>\r\n<open_total>2</open_total>\r\n<click_total>4</click_total>\r\n<open_first>2023-06-13 09:59:39</open_first>\r\n<open_last>2023-06-13 09:59:49</open_last>\r\n<click_first>2023-06-13 09:59:39</click_first>\r\n<click_last>2023-06-13 09:59:50</click_last>\r\n</user>\r\n<user>\r\n<email_id>37</email_id>\r\n<email>3281878926@qq.com</email>\r\n<browser>Chrome Mobile WebView 88.0.4324</browser>\r\n<os>Android </os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|河南信阳</addr_first>\r\n<ip_first>221.14.127.119</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 09:59:46</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>38</email_id>\r\n<email>365872430@qq.com</email>\r\n<browser>Mobile Safari UI/WKWebView 14.8</browser>\r\n<os>iOS 14.8</os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|山东</addr_first>\r\n<ip_first>112.224.74.45</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 09:59:57</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>39</email_id>\r\n<email>fancy.fan@sgscm.com</email>\r\n<browser>Chrome 49.0.2623</browser>\r\n<os>Windows 8</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|广东深圳龙岗</addr_first>\r\n<ip_first>119.123.177.13</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:00:14</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>41</email_id>\r\n<email>396523789@qq.com</email>\r\n<browser>Chrome Mobile WebView 108.0.5359</browser>\r\n<os>Android </os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|四川甘孜</addr_first>\r\n<ip_first>117.174.14.74</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:02:44</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>46</email_id>\r\n<email>leifeng@cndmerchandise.com</email>\r\n<browser>Chrome Mobile WebView 92.0.4515</browser>\r\n<os>Android </os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|黑龙江哈尔滨</addr_first>\r\n<ip_first>42.102.183.224</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:07:44</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>42</email_id>\r\n<email>343636375@qq.com</email>\r\n<browser>Mobile Safari UI/WKWebView 15.0.2</browser>\r\n<os>iOS 15.0.2</os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|北京北京</addr_first>\r\n<ip_first>223.104.48.96</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:05:52</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>43</email_id>\r\n<email>leixiaocong@10000link.com</email>\r\n<browser>Other </browser>\r\n<os>Android </os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|广东深圳南山</addr_first>\r\n<ip_first>183.15.176.55</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>1</click_total>\r\n<open_first>2023-06-13 10:06:24</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 10:18:53</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>44</email_id>\r\n<email>flywangzhe@163.com</email>\r\n<browser>Chrome Mobile WebView 104.0.5112</browser>\r\n<os>Android </os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|河南郑州中原</addr_first>\r\n<ip_first>123.52.27.60</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:06:47</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>45</email_id>\r\n<email>emergent@163.com</email>\r\n<browser>Other </browser>\r\n<os>Other </os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>104.28.69.33</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:06:56</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>48</email_id>\r\n<email>wangst@sinoguarantee.com</email>\r\n<browser>Chrome 113.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|波特兰</addr_first>\r\n<ip_first>54.244.166.221</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>5</click_total>\r\n<open_first>2023-06-13 10:12:17</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>2023-06-13 10:12:17</click_first>\r\n<click_last>2023-06-13 10:12:35</click_last>\r\n</user>\r\n<user>\r\n<email_id>49</email_id>\r\n<email>ihwang@163.com</email>\r\n<browser>Chrome 49.0.2623</browser>\r\n<os>Windows 7</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|河北邯郸</addr_first>\r\n<ip_first>101.26.2.93</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:15:44</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>50</email_id>\r\n<email>yingling@szedi.cn</email>\r\n<browser>Chrome 101.0.4951</browser>\r\n<os>Windows 8</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|广东深圳</addr_first>\r\n<ip_first>183.49.45.137</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:16:17</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>51</email_id>\r\n<email>nyh0307@163.com</email>\r\n<browser>Chrome Mobile WebView 92.0.4515</browser>\r\n<os>Android </os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|广东深圳南山</addr_first>\r\n<ip_first>183.15.176.55</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:26:27</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>52</email_id>\r\n<email>chenxiaosong@hanhua.com</email>\r\n<browser>Other </browser>\r\n<os>Other </os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>104.28.66.33</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:28:16</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>53</email_id>\r\n<email>limei_wang@kingdee.com</email>\r\n<browser>Other </browser>\r\n<os>Other </os>\r\n<device>pc</device>\r\n<addr_first>北美洲|美国|</addr_first>\r\n<ip_first>104.28.66.59</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:30:34</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>54</email_id>\r\n<email>guo_zhixiong@infopro.com.my</email>\r\n<browser>Mobile Safari UI/WKWebView 14.6</browser>\r\n<os>iOS 14.6</os>\r\n<device>mobile</device>\r\n<addr_first>亚洲|中国|福建厦门湖里</addr_first>\r\n<ip_first>140.243.190.162</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 10:57:48</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>55</email_id>\r\n<email>yaling.li@dg-shl.com</email>\r\n<browser>Chrome 114.0.0</browser>\r\n<os>Windows 10</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|广东东莞</addr_first>\r\n<ip_first>219.130.39.18</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 11:03:27</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n<user>\r\n<email_id>56</email_id>\r\n<email>daxiasougoushurufa@163.com</email>\r\n<browser>Chrome 75.0.3770</browser>\r\n<os>Windows 8</os>\r\n<device>pc</device>\r\n<addr_first>亚洲|中国|江西</addr_first>\r\n<ip_first>118.212.216.152</ip_first>\r\n<ip_last></ip_last>\r\n<addr_last></addr_last>\r\n<open_total>1</open_total>\r\n<click_total>0</click_total>\r\n<open_first>2023-06-13 11:10:18</open_first>\r\n<open_last>0000-00-00 00:00:00</open_last>\r\n<click_first>0000-00-00 00:00:00</click_first>\r\n<click_last>0000-00-00 00:00:00</click_last>\r\n</user>\r\n</data>\r\n");

            //string thisSrc = "";
            //string[] thisEventDSrc = thisSrc.Split(",");

            //List<string> abc = new List<string>();
            //string result = string.Join(',', abc);

            //Console.WriteLine("Halo!");
            //while (true)
            //{
            //    string abc = Console.ReadLine();
            //    if (abc.ToLower().Contains("done"))
            //        break;
            //    else
            //        Console.WriteLine("Hello " + abc);
            //}

            //string abc = "aabbcc";
            //var a = abc.Substring(0, 1);
            //Console.WriteLine(a);

            //string a = null;
            //string b = a ?? "abc";
            //Console.WriteLine(b);

            //string a = null;
            //string b = "";
            //Console.WriteLine(Convert.ToDecimal(a));
            //Console.WriteLine(Convert.ToDecimal(b));

            //List<string> numbers = new List<string> { "0", "2", "3", "3", "", "5", "5" };
            //List<string> distinctNumbers = numbers.Distinct().ToList();
            //var disNums = string.Join(",", distinctNumbers);//list去重
            //Console.WriteLine(disNums);
            //var splitRemoveEmpty = disNums.Split(',', StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join(",", splitRemoveEmpty));


            //int[] fixedNums = { 27, 5 };
            //Console.WriteLine(fixedNums.Sum());

            //List<int> listA = new List<int>() { 1, 2, 3 };
            //List<int> listB = new List<int>() { 2 };

            //var difference = listA.Except(listB);
            //Console.WriteLine("差集为：");
            //foreach (var item in difference)
            //{
            //    Console.Write($"{item} ");
            //}

            //decimal value = 123.45m;
            //decimal roundedValue = decimal.Round(value, 4); // 保留四位小数
            //Console.WriteLine(roundedValue);

            //List<string> abc = new List<string>();
            //foreach (var item in abc)
            //{
            //    abc.IndexOf(item);
            //}

            //abc.ForEach(abc => {
            //    Console.WriteLine(abc);
            //});

            ////List<string> list = new List<string>() { "1", "2", "3" };
            //List<string> list = new List<string>() ;
            //var activityNoArrayStr = "'" + string.Join("','", list) + "'";
            //Console.WriteLine(activityNoArrayStr);

            //DateTime dateA = Convert.ToDateTime("2024-01-28 08:00:00");
            //DateTime dateB = Convert.ToDateTime("2024-03-02 08:00:00");
            //Console.WriteLine((dateB - dateA).Days + 1);

            //string abc = "1,2,3";
            //var a = abc.Split(",");
            //Console.WriteLine(string.Join(',',a));

            //DateTime a = DateTime.Now;
            //Console.WriteLine(a.Ticks);
            //long timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            //Console.WriteLine(timeStamp);

            //UMailResponse test2 = XmlSerializeHelper.DeSerialize<UMailResponse>("<?xml version=\"1.0\" encoding=\"UTF-8\"?><result><status>success</status><data>1021544</data></result>");

            //MlAddrListRes test2 = XmlSerializeHelper.DeSerialize<MlAddrListRes>("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<data>\r\n<total_num>5700</total_num>\r\n<addr>\r\n<id>153189</id>\r\n<list_id>3299551</list_id>\r\n<address><![CDATA[luke_cai@10000link.com]]></address>\r\n<sex></sex>\r\n<birthday>2014-12-20</birthday>\r\n<phone></phone>\r\n<area><![CDATA[地区]]></area>\r\n<fullname><![CDATA[蔡宇江]]></fullname>\r\n<time>2024-03-11 13:43:15</time>\r\n<var1></var1>\r\n<var2>创始人</var2>\r\n<var3></var3>\r\n<var4>万联网</var4>\r\n<var5>crm-69810</var5>\r\n</addr>\r\n</data>");

            //Dictionary<string, decimal> newDic = new Dictionary<string, decimal>();

            //newDic.Add("001", 12.5M);
            //newDic.Add("002", 12.4M);
            //newDic.Add("003", 12.3M);

            //Console.WriteLine(JsonConvert.SerializeObject(newDic));

            //var client = new RestClient("http://localhost:1049/api/Company/GetList");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            //SiActivityExecutableStatus person = JsonConvert.DeserializeObject<SiActivityExecutableStatus>("{\r\n\t\"IsSucceed\": false,\r\n\t\"Message\": \"异常信息\",\r\n\t\"StatusCode\": 500\r\n}");

            // var test = new List<MesStock> {
            //    new MesStock { Deid="1",Pno="1",Sno="1",TotalNums=1},
            //    new MesStock { Deid="1",Pno="1",Sno="1",TotalNums=1},
            //    new MesStock { Deid="1",Pno="1",Sno="1",TotalNums=11},
            //    new MesStock {Deid="2",Pno="2",Sno="2",TotalNums=2},
            //    new MesStock {Deid="2",Pno="2",Sno="2",TotalNums=2},
            //    new MesStock {Deid="2",Pno="2",Sno="2",TotalNums=33},
            //    new MesStock {Deid="3",Pno="3",Sno="3",TotalNums=3},
            //};
            // List<MesStock> res = new List<MesStock>();

            // test.GroupBy(x => x.Deid + x.Pno + x.Sno, (x, y) =>
            // {
            //     var total = y.Sum(a => a.TotalNums);
            //     var tt = y.Select(t =>
            //     {
            //         t.TotalNums = total;
            //         return t;
            //     }).ToList();
            //     res.Add(tt.First());
            //     return tt;
            // }).ToList();

            // foreach (var item in res)
            // {
            //     Console.WriteLine(item.TotalNums);
            // }




            //// 初始化字符串数组
            //string[] stringArray = { "2019P7W3", "2019P4W4", "2019P1W1", "2019P10W2", "2019P11W1", "2019P7W1", "2024P13W4", "2024P3W2" };

            //// 使用Array.Sort进行排序
            //Array.Sort(stringArray);

            //// 输出排序后的数组
            //foreach (var s in stringArray)
            //{
            //    Console.WriteLine(s);
            //}




            //int minYear = 0, minP = 0, minWeek = 0, maxYear = 0, maxP = 0, maxWeek = 0;
            //string[] stringArray = { "2019P7W3", "2019P4W4", "2019P1W1", "2019P10W2", "2019P11W1", "2019P7W1", "2024P13W4", "2024P3W2" };
            //foreach (var item in stringArray)
            //{
            //    string[] subStrPeriodStart = item.Replace("P", "-").Replace("W", "-").Split("-");
            //    int startYear = int.Parse(subStrPeriodStart[0]),
            //        startPeriod = int.Parse(subStrPeriodStart[1]),
            //        startWeek = int.Parse(subStrPeriodStart[2]);
            //    if ((startYear <= minYear && startPeriod <= minP && startWeek <= minWeek) || minYear == 0)
            //    {
            //        minYear = startYear;
            //        minP = startPeriod;
            //        minWeek = startWeek;
            //    }

            //    string[] subStrPeriodEnd = item.Replace("P", "-").Replace("W", "-").Split("-");
            //    int endYear = int.Parse(subStrPeriodEnd[0]),
            //        endPeriod = int.Parse(subStrPeriodEnd[1]),
            //        endWeek = int.Parse(subStrPeriodEnd[2]);
            //    if (endYear >= maxYear && endPeriod >= maxP && endWeek >= maxWeek)
            //    {
            //        maxYear = endYear;
            //        maxP = endPeriod;
            //        maxWeek = endWeek;
            //    }
            //}
            //Console.WriteLine(minYear + "P" + minP + "W" + minWeek);
            //Console.WriteLine(maxYear + "P" + maxP + "W" + maxWeek);

            //decimal a = 98.15M;
            //Console.WriteLine(a.ToString("f1"));

            //char startChar = 'A';
            //for (int i = 0; i < 36; i++)
            //{
            //    char c = IncrementChar(startChar);
            //    Console.WriteLine(c);
            //    startChar = c;
            //}

            //var abc = TypeDescriptor.GetProperties(new MesStock()).Count;

            //StringBuilder sbW = null;
            //for (int i = 1; i <= 3; i++)//五百以内
            //{
            //    sbW = new StringBuilder();
            //    int n = i;
            //    while (n != 0)
            //    {
            //        if (n % 26 == 0)
            //        {
            //            sbW.Insert(0, 'Z');
            //            n = n / 26 - 1;
            //        }
            //        else
            //        {
            //            sbW.Insert(0, (char)((n % 26 - 1) + 'A'));
            //            n /= 26;
            //        }
            //    }
            //    Console.WriteLine(sbW.ToString());
            //}


            //foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(new MesStock()))
            //{
            //    foreach (Attribute item in property.Attributes)
            //    {
            //        if (item.TypeId.ToString().Contains("ExcelAnnotations"))
            //        {
            //            item.GetType().GetProperty("Value").GetValue(item);
            //            Console.WriteLine(JsonConvert.SerializeObject(item.GetType().GetProperty("Value").GetValue(item)));
            //            break;
            //        }
            //    }
            //    //Console.WriteLine(JsonConvert.SerializeObject(property.Attributes));
            //    //break;
            //}


            //var reqResult = JsonConvert.DeserializeObject<SiActivityExecutableStatus>("{\r\n\t\"Entity\": {\r\n\t\t\"Status\": \"Y\",\r\n\t\t\"Msg\": \"\"\r\n\t},\r\n\t\"IsSucceed\": true,\r\n\t\"Message\": \"\",\r\n\t\"StatusCode\": 200\r\n}");

            //object abc = new {
            //    //通用按钮事件
            //    search = "Search ",
            //    reset = "Reset ",//重置
            //    clear = "Clear",//清空
            //    searchAdvanced = "More filters",//searchAdvanced="More filters"//高级查询
            //    searchGeneral = "Less filters",//searchGeneral="Less filters"//普通查询
            //    searchQuick = "Quick Search ",//分类查询
            //    add = "Add",
            //    edit = "Edit",
            //    delete = "Delete",
            //    import = "Import",
            //    export = "Export To Excel",//export="Export To Excel"
            //    show = "Show",
            //    hide = "Hide",
            //    save = "Save",
            //    cancel = "Cancel",
            //    close = "Close",
            //    view = "View",//view:"View"
            //    confirm = "Confirm",
            //    batchEdit = "Batch Modifying",//batchUpdate:"Batch Update'
            //    upload = "Upload",
            //    download = "Download",
            //    settings = "Settings",//设置
            //    refresh = "Refresh",//刷新
            //    reverse = "Reverse",//退回
            //    saveAndClose = "Save and Close",
            //    copy = "Copy",//复制
            //    approve = "Approve",//approve:"Approve",//审批
            //    reject = "Reject",//reject:"Reject"//驳回		
            //    first = "First",//首页
            //    last = "Last",  //末页
            //    previous = "Previous",//上页
            //    next = "Next",  //下页

            //    languange = "Languange",
            //    chs = "Simplified Chinese",
            //    cht = "Traditional Chinese",
            //    eng = "English",
            //    jpn = "Japanese",
            //    welcome = "Welcome",
            //    hi = "Hi",
            //    dataNotFound = "Data not found.",//dataNotFound:"Data not found.'
            //    pleaseEnter = "Please enter.",
            //    pleaseInput = "Please input.",
            //    pleaseSelect = "Please select",
            //    pleaseChoose = "Please choose",
            //    template = "template",
            //    todoList = "ToDo List",//todoList:"ToDo List",
            //    message = "Message",//message:"Message",
            //    notice = "System notice",
            //    weeHours = "Early to bed and early to rise in the wee hours of the morning! Pay attention to work and rest!",
            //    morning = "Good morning! Don't forget to have a hearty breakfast!",
            //    forenoon = "Good morning! Hurry up and start the day's work!",
            //    noon = "Good afternoon! Remember to eat lunch, and don't forget to take a walk to digest.",
            //    afternoon = "Good afternoon! Treat yourself to a refreshing cup of coffee!",
            //    sunset = "Good evening!  It's been a hard day's work, so hurry up and finish today's task.",
            //    night = "Good evening! Rub your eyes, take a break, make a plan, come on tomorrow!",
            //    lateNight = "In the dead of night, and you.",

            //    //通用系统提示
            //    rubric = "Rubric",
            //    uploadFirst = "Please upload the import file first.",
            //    success = "Success",//成功
            //    saveSuccess = "Data saved successfully.",//保存成功
            //    addSuccess = "Data added successfully.",//添加成功
            //    updateSuccess = "Data updated successfully.",//修改成功
            //    deleteSuccess = "Data deleted successfully.",//删除成功
            //    cancelSuccess = "Data cancelled successfully.",//取消成功
            //    VerifierSuccess = "Data Verified successfully.",//审核成功
            //    approvalSuccess = "Approved successfully.",//审批成功
            //    fieldMandatory = "Fields marked with * are mandatory.",//字段不可为空。

            //    //通用字段
            //    timeCreate = "Creation Time",//创建
            //    createBy = "Creator",
            //    timeUpdate = "Last Update",//修改
            //    updateBy = "Updator",
            //    timeVerify = "Verify Time",//审核
            //    VerifyBy = "Verifier",
            //    timeApprove = "Approve Time",//审批
            //    ApproveBy = "Approver",
            //    timeCancel = "Cancelled Time",//取消
            //    CancelBy = "Cancelled By",
            //    isValid = "Valid",
            //    remarks = "Remarks",
            //    sortSeq = "Sort Seqencing",
            //    isShow = "Showed",
            //    bankName = "Bank Name",
            //    bankAccount = "Bank Account",
            //    currency = "Currency",
            //    website = "Website",
            //    country = "Country",
            //    province = "Province",
            //    city = "City",
            //    address = "Address",
            //    email = "E-Mail",
            //    tel = "Tel",
            //    mobile = "Mobile",
            //    fax = "Fax",
            //    name = "Name",
            //    foreignName = "Foreign Name",//所有enName都用这个
            //    dateBegin = "Date Begin",
            //    dateEnd = "Date End",
            //    isSingle = "Single",
            //    isDefault = "Default",
            //    contact = "Contact",

            //    //登录首页
            //    userCode = "User ID",//用户编码
            //    userName = "User Name",//用户姓名
            //    userPassword = "Password",
            //    login = "Login",//登录
            //    register = "Register",//注册
            //    resetAccount = "Reset",//重置账号
            //    privacyPolicy = "Privacy Policy",//隐私政策
            //    legalTerms = "Legal Terms",//法律条款
            //    rememberMe = "Remember Me",//记住账号
            //    userCodeRequired = "Field User Code is mandatory。",
            //    passwordRequired = "Field User Password is mandatory。",
            //    copyright = "© Copyright 2024 Shenzhen Wanlink Technology Co., LTD.",

            //    // 用户管理
            //    //userCode="User ID",//用户编码
            //    //userName="User Name",//用户姓名
            //    //userPassword="Password",
            //    // email="E-Mail",
            //    // tel="Tel",
            //    // mobile="Mobile",
            //    employeeId = "Employee ID",
            //    // remarks="Remarks",
            //    // isValid="Valid",
            //    isLocked = "Locked",
            //    // dateBegin="Date Begin",
            //    // dateEnd="Date End",
            //    userType = "User Type",
            //    orgCode = "Sales Org.",
            //    department = "Department",
            //    vendorCode = "Vendor",
            //    soldtoCode = "SoldTo",
            //    expiredDate = "Expired Date",
            //    pwdChgDate = "Pwd Change Date",
            //    timeLastLogin = "Last Login",
            //    isAdUser = "AD User",
            //    isUseKey = "Token Required",

            //    //系统权限组
            //    groupCode = "Group Code",
            //    groupName = "Group Name",
            //    // remarks="remarks",
            //    // is_valid="is_valid",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",

            //    //系统参数
            //    paraId = "Parameter ID",
            //    paraDesc = "Parameter Description",
            //    paraType = "Parameter Type",
            //    // remarks="remarks",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",

            //    // para_id="para_id",
            //    itemCode = "Item Code",
            //    itemValue = "Item Value",
            //    udfField1 = "UDF Field1",
            //    udfField2 = "UDF Field2",
            //    udfField3 = "UDF Field3",
            //    udfField4 = "UDF Field4",
            //    // is_valid="is_valid",
            //    // remarks="remarks",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",

            //    //基础编码
            //    pubCode = "Public Code",
            //    codeDesc = "Code Description",
            //    tableName = "Table Name",
            //    fieldName = "Field Name",
            //    // remarks="remarks",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",

            //    // pubCode:"pub_code",`
            //    // itemCode:"item_code",
            //    itemName = "Item Name",
            //    // itemValue:"item_value",
            //    // is_valid:"is_valid",
            //    // remarks:"remarks",
            //    // sortSeq="Sort Seqencing",
            //    // udfField1:"udf_field1",
            //    // udfField2:"udf_field2",
            //    // udfField3:"udf_field3",
            //    // udfField4:"udf_field4",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //菜单管理
            //    menuCode = "Menu Code",
            //    menuName = "Menu Name",
            //    // foreignName="Menu English Name",
            //    menuUrl = "Menu Url",
            //    menuAddr = "Menu Address",
            //    parentId = "Parent ID",
            //    icon = "Icon",
            //    // isCommon="is_common",
            //    // isShow="Showed",
            //    // remarks="remarks",
            //    // sortSeq="sort_seq",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",

            //    //公司管理
            //    companyName = "Company Name",
            //    // companyNameEn="English Name",
            //    shortName = "Short Name",
            //    companyType = "Company Type",
            //    // contact="Contact",
            //    // tel="Tel",
            //    // fax="Fax",
            //    // email="email",
            //    // mobile="mobile",
            //    // is_valid="is_valid",
            //    taxId = "Tax ID",
            //    // bankName="Bank Name",
            //    // bankAccount="Bank Account",
            //    // currency="Currency",
            //    // website="Website",
            //    // country="Country",
            //    // province="Province",
            //    // city="City",
            //    // address="Address",
            //    // remarks="remarks",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",

            //    //货币汇率
            //    localCurrency = "Local Currency",
            //    foreignCurrency = "Foreign Currency",
            //    exRate = "Exchange Rate",
            //    // dateBegin="date_begin",
            //    // dateEnd="date_end",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //产品资料
            //    productCode = "Product Code",
            //    productName = "Product Name",
            //    // foreignName="product_name_en",
            //    packingPpec = "Packing Spec",
            //    productSpec = "Product Spec",
            //    segment = "Segment",
            //    subSegment = "Sub Segment",
            //    productStatus = "Product Status",
            //    productType = "Product Type",
            //    totalShelflife = "Total Shelflife",
            //    writeoffDays = "Writeoff Days",
            //    agedDays = "Aged Days",
            //    maturedDays = "Matured Days",
            //    pickingType = "Picking Type",
            //    is_palletScan = "Pallet Scan",
            //    palletLayer = "Pallet Layer",
            //    palletLayerCarton = "Pallet Layer Carton",
            //    cargoType = "Cargo Type",
            //    bulkyRate = "Bulky Rate",
            //    firstGiTime = "First Gi Time",
            //    storageCondition = "Storage Condition",
            //    salesAbc = "Sales ABC",
            //    category = "Category",
            //    subCategory = "Sub Category",
            //    brand = "Brand",
            //    subBrand = "Sub Brand",
            //    flavor = "Flavor",
            //    isTopSku = "Top Sku",
            //    productForm = "Product Form",
            //    barcode = "Barcode",
            //    eaPerTdu = "EA Per TDU",
            //    mcuPerTdu = "MCU Per TDU",
            //    rsuPerTdu = "RSU Per TDU",
            //    grossWeight = "Gross Weight",
            //    netWeight = "Net Weight",
            //    volume = "Volume",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",
            //    // remarks="remarks",

            //    // productCode:"product_code",
            //    unitEn = "Unit",
            //    unitName = "Unit Name",
            //    unitDesc = "Unit Description",
            //    // barcode:"Barcode",
            //    // isSingle="is_single",
            //    // isDefault="is_default",
            //    scale = "Scale",
            //    length = "Length",
            //    width = "Width",
            //    height = "Height",
            //    lengthUnit = "Length Unit",
            //    // grossWeight:"Gross Weight",
            //    // netWeight:"net_weight",
            //    weightUnit = "Weight Unit",
            //    // volume:"volume",
            //    volumeUnit = "Volume Unit",
            //    standardPrice = "Standard Price",
            //    listPrice = "List Price",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //仓库管理
            //    whCode = "Warehouse Code",
            //    whName = "Warehouse Name",
            //    // foreignName:"wh_name_en",
            //    whType = "Warehouse Type",
            //    whTag = "Warehouse Tag",
            //    // contact="Contact",
            //    // tel="tel",
            //    // fax="fax",
            //    // email="email",
            //    // mobile="mobile",
            //    // province="province",
            //    // city="city",
            //    // address="address",
            //    // is_valid="is_valid",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",

            //    //销售组织架构
            //    orgName = "Organize Name",
            //    orgLevel = "Organize Level",
            //    orgType = "Organize Type",
            //    // is_valid:"is_valid",
            //    parentNo = "Parent No.",
            //    treePath = "Tree Path",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //省份城市
            //    // province:"province",
            //    // city:"city",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    province_city_id = "Province City ID",
            //    // city:"city",
            //    town = "Town",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //供应商资料
            //    vendorCode = "Vendor Code",
            //    vendorName = "Vendor Name",
            //    // foreignName="vendor_name_en",
            //    // shortName="short_name",
            //    vendorType = "Vendor Type",
            //    // contact="contact",
            //    // tel="tel",
            //    // fax="fax",
            //    // mobile="mobile",
            //    // email="email",
            //    // is_valid="is_valid",
            //    beginDate = "Begin Date",
            //    endDate = "End Date",
            //    // acc_bank="acc_bank",//使用bankName！！！
            //    // acc_no="acc_no",//使用bankAccount！！！
            //    // country="country",
            //    // province="province",
            //    // city="city",
            //    // address="address",
            //    // remarks="remarks",
            //    // time_create="time_create",
            //    // create_by="create_by",
            //    // time_update="time_update",
            //    // update_by="update_by",

            //    //火星日历设置
            //    periodId = "Period ID",
            //    theYear = "The Year",
            //    periodNo = "Period Number",
            //    // dateBegin:"date_begin",
            //    // dateEnd:"date_end",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    weekId = "Week ID",
            //    // period_id:"period_id",
            //    // theYear:"the_year",
            //    // periodNo:"period_no",
            //    weekNo = "Week Number",
            //    // date_begin:"date_begin",
            //    // date_end:"date_end",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //工作时间表
            //    day = "Day",
            //    isHoliday = "Holiday",
            //    isTriple = "Triple Salary",
            //    isOnDuty = "On Duty",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //门店资料
            //    storeId = "Store ID",
            //    storeCode = "Store Code",
            //    storeName = "Store Nname",
            //    regionCode = "Region Code",
            //    regionName = "Region Name",
            //    provinceCode = "Province Code",
            //    provinceName = "Province Name",
            //    cityClusterCode = "City Cluster Code",
            //    cityClusterName = "City Cluster Name",
            //    cityPrefectureCode = "City Prefecture Code",
            //    cityPrefectureName = "City Prefecture Name",
            //    cityCode = "City Code",
            //    cityName = "City Name",
            //    storeAddr = "Store Address",
            //    // contact:"contact",
            //    // tel:"tel",
            //    cneeContact = "Cnee Contact",
            //    cneeTel = "Cnee Tel",
            //    channelName1 = "Channel Name1",
            //    channelName2 = "Channel Name2",
            //    channelName3 = "Channel Name3",
            //    chainCode1 = "Chain Code1",
            //    chainName1 = "Chain Name1",
            //    chainCode2 = "Chain Code2",
            //    chainName2 = "Chain Name2",
            //    chainCode3 = "Chain Code3",
            //    chainName3 = "Chain Name3",
            //    kaType = "Ka Type",
            //    // is_valid:"is_valid",
            //    closeDate = "Close Date",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //库存报告列表
            //    invId = "Inventory ID",
            //    // whCode:"wh_code",
            //    // whName:"wh_name",
            //    // productCode:"product_code",
            //    // productName:"product_name",
            //    batchNo = "Batch No.",
            //    // agedDays:"aged_days",
            //    shelfLife = "Shelf Life",
            //    // eaPerTdu:"ea_per_tdu",
            //    productionDate = "Production Date",
            //    expiryDate = "Expiry Date",
            //    slc = "SLC",
            //    stockType = "Stock Type",
            //    stockReason = "Stock Reason",
            //    pkgNum = "Pkg Num",
            //    pkgEa = "Pkg Ea",
            //    pkgCs = "Pkg Cs",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //批次主数据列表
            //    // productCode:"product_code",
            //    // productName:"product_name",
            //    // batchNo:"batch_no",
            //    // productionDate:"production_date",
            //    availableDate = "Available Date",
            //    // expiryDate:"expiry_date",
            //    production_date_fixed = "Production Date Fixed",
            //    qiStatus = "Quality Inspection Status",
            //    olcStatus = "Olc Status",
            //    releaseStatus = "Release Status",
            //    // stockType:"stock_type",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //货柜管理
            //    containerType = "Container Type",
            //    containerName = "Container Name",
            //    maxWeight = "Max Weight",
            //    maxVolume = "Max Volume",
            //    setWeight = "Set Weight",
            //    setVolume = "Set Volume",
            //    // remarks:"remarks",
            //    // is_valid:"is_valid",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //配送单管理
            //    orderNo = "Order No.",
            //    period = "Mars Period",
            //    orderType = "Order Type",
            //    projectName = "project_name",
            //    ioNo = "IO No.",
            //    // regionCode:"region_code",
            //    // regionName:"region_name",
            //    // provinceCode:"province_code",
            //    // provinceName:"province_name",
            //    // cityClusterCode:"city_cluster_code",
            //    // cityClusterName:"city_cluster_name",
            //    // cityPrefectureCode:"city_prefecture_code",
            //    // cityPrefectureName:"city_prefecture_name",
            //    // cityCode:"city_code",
            //    // cityName:"city_name",
            //    // storeCode:"store_code",
            //    // storeName:"store_name",
            //    // storeAddr:"store_addr",
            //    // cneeContact:"cnee_contact",
            //    // cneeTel:"cnee_tel",
            //    // province:"province",
            //    // city:"city",
            //    // whCode:"wh_code",
            //    // whName:"wh_name",
            //    carrierCode = "Carrier Code",
            //    carrierName = "Carrier Name",
            //    requestDate = "Request Date",
            //    etd = "Estimated Departure Date",
            //    eta = "Estimated Time Of Arrival",
            //    atd = "Actual Departure Date",
            //    ata = "Actual Arrival Date",
            //    billStatus = "Bill Status",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    // orderNo:"order_no",
            //    // productCode:"product_code",
            //    // productName:"product_name",
            //    // unit:"unit",
            //    // unitDesc:"unit_desc",
            //    // pkgNum:"pkg_num",
            //    price = "Price",
            //    // netWeight:"net_weight",
            //    // grossWeight:"gross_weight",
            //    // volume:"volume",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",

            //    //采购单管理
            //    // orderNo:"order_no",
            //    poNo = "Po No.",
            //    deliveryNo = "Delivery No.",
            //    supplierCode = "Supplier Code",
            //    supplierName = "Supplier Name",
            //    poDate = "Po Date",
            //    // carrierCode="Carrier Code",
            //    // carrierName="Carrier Name",
            //    deliveryDate = "Delivery Date",
            //    // billStatus:"bill_status",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",
            //    // wh_code:"wh_code",
            //    // wh_name:"wh_name",
            //    // currency:"currency",
            //    // ex_rate:"ex_rate",

            //    // orderNo:"order_no",
            //    // productCode:"product_code",
            //    // productName:"product_name",
            //    // unit:"unit",
            //    // unitDesc:"unit_desc",
            //    // pkgNum:"pkg_num",
            //    // currency:"currency",
            //    // exRate:"ex_rate",
            //    unitPrice = "Unit Price",
            //    amount = "Amount",
            //    localAmount = "Local Amount",
            //    // netWeight:"net_weight",
            //    // grossWeight:"gross_weight",
            //    // volume:"volume",
            //    // remarks:"remarks",
            //    // time_create:"time_create",
            //    // create_by:"create_by",
            //    // time_update:"time_update",
            //    // update_by:"update_by",
            //};


            //string username = "10000link";
            //string password = "10000link";
            //string usernamePassword = username + ":" + password;
            //string token = Convert.ToBase64String(new ASCIIEncoding().GetBytes(usernamePassword));

            //Console.WriteLine(token);

            //int number = 123;
            //int desiredLength = 8; // 假设我们想要输出的数字长度为8

            //// 使用String.Format
            //string output1 = String.Format("{0:D" + desiredLength + "}", number);
            //Console.WriteLine(output1); // 输出: 00000123

            ////// 使用字符串插值
            ////string output2 = $"{number:D{desiredLength}}";
            ////Console.WriteLine(output2); // 输出: 00000123

            //// 使用PadLeft
            //string output3 = number.ToString().PadLeft(desiredLength, '0');
            //Console.WriteLine(output3); // 输出: 00000123

            //int? testNo = null;
            //testNo++;
            //Console.WriteLine(      testNo);



            //IFormatProvider culture = new CultureInfo("zh-CN", true);
            //string[] expectedFormats = { "dd-M月-yyyy" };

            //if (!(DateTime.TryParseExact("2024 8 1", expectedFormats, culture, DateTimeStyles.AllowInnerWhite, out DateTime displayBeginOut) || DateTime.TryParse("2024 8 1", out displayBeginOut)))
            //{
            //    Console.WriteLine("123");
            //} else {
            //    Console.WriteLine("321");
            //}


            //var ActivityDays = Convert.ToInt32((DateTime.Parse(displayBeginOut.ToString()) - DateTime.Parse(displayBeginOut.ToString())).TotalDays) + 1;


            //Console.WriteLine(ActivityDays);

            //string abc = "46.4";

            ////Console.WriteLine(int.Parse(abc));

            //if (int.TryParse(abc, out int outAbc))
            //{
            //    Console.WriteLine(outAbc);
            //}
            //else {
            //    Console.WriteLine("不行");
            //}

            //string username = "10000link";
            //string password = "10000link";
            //string usernamePassword = username + ":" + password;
            //string token = Convert.ToBase64String(new ASCIIEncoding().GetBytes(usernamePassword));
            //Console.WriteLine(token);


            //// 获取今天的日期
            //DateTime today = DateTime.Now;

            //// 获取今天是周几的枚举值
            //DayOfWeek dayOfWeek = today.DayOfWeek;

            //// 转换为整数，以便显示
            //int dayNumber = (int)dayOfWeek;

            //// 转换为星期名称
            //string dayName = dayOfWeek.ToString();

            //// 打印结果
            //Console.WriteLine("今天是星期几？ 整数表示：" + dayNumber);
            //Console.WriteLine("今天是星期几？ 文本表示：" + dayName);

            //for (int i = 0; i < 7; i++)
            //{
            //    // 获取今天的日期
            //    DateTime today = DateTime.Now.AddDays(i);

            //    // 获取今天是周几的枚举值
            //    DayOfWeek dayOfWeek = today.DayOfWeek;

            //    // 转换为整数，以便显示
            //    int dayNumber = (int)dayOfWeek;

            //    // 转换为星期名称
            //    string dayName = dayOfWeek.ToString();

            //    // 打印结果
            //    Console.WriteLine("今天是星期几？ 整数表示：" + dayNumber);
            //    Console.WriteLine("今天是星期几？ 文本表示：" + dayName);
            //}

            List<string> abc = new List<string>() { "3", "4", "8", "1" };
            abc=abc.OrderBy(x => x).ToList();
            Console.WriteLine(JsonConvert.SerializeObject(abc));
            Console.WriteLine(abc.Max(x=>x));










            Console.WriteLine("Done!");
        }

        public class ExcelAnnotationsAttribute {
            public string Value { get; set; }
            public string TypeId { get; set; }
        }


        public static char IncrementChar(char c)
        {
            if (char.IsUpper(c) && c < 'Z')
            {
                return (char)(c + 1);
            }
            else if (c == 'Z')
            {
                return 'A';
            }
            return c;
        }
    }
}
