using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    #region xml test
    [XmlRoot("result")]
    public class UMailResponse
    {
        [XmlElement("status")]
        public string status { get; set; }
        [XmlElement("data")]
        public string data { get; set; }
    }

    public class AisinoResponse
    {
        public string operateCode { get; set; }
        public string message { get; set; }
        public object datas { get; set; }
        public object pageAndSort { get; set; }
    }

    [XmlRoot("data")]
    public class MlAddrListRes
    {
        [XmlElement("total_num")]
        public string total_num { get; set; }
        [XmlElement("addr")]
        public List<Addr> addr { get; set; }
    }

    [XmlRoot("addr")]
    public class Addr
    {
        [XmlElement("id")]
        public string id { get; set; }
        [XmlElement("list_id")]
        public string list_id { get; set; }
        [XmlElement("address")]
        public string address { get; set; }
        [XmlElement("brithday")]
        public string brithday { get; set; }
        [XmlElement("phone")]
        public string phone { get; set; }
        [XmlElement("area")]
        public string area { get; set; }
        [XmlElement("fullname")]
        public string fullname { get; set; }
        [XmlElement("time")]
        public string time { get; set; }


        [XmlElement("var1")]
        public string var1 { get; set; }
        [XmlElement("var2")]
        public string var2 { get; set; }
        [XmlElement("var3")]
        public string var3 { get; set; }
        [XmlElement("var4")]
        public string var4 { get; set; }
        [XmlElement("var5")]
        public string var5 { get; set; }
        [XmlElement("var6")]
        public string var6 { get; set; }
        [XmlElement("var7")]
        public string var7 { get; set; }
        [XmlElement("var8")]
        public string var8 { get; set; }
        [XmlElement("var9")]
        public string var9 { get; set; }
        [XmlElement("var10")]
        public string var10 { get; set; }
    }

    [XmlRoot("data")]
    public class STaskRes
    {
        [XmlElement("task")]
        public List<Task> task { get; set; }
    }

    [XmlRoot("task")]
    public class Task
    {
        [XmlElement("task_id")]
        public string task_id { get; set; }
        [XmlElement("task_date")]
        public string task_date { get; set; }
        [XmlElement("task_ident")]
        public string task_ident { get; set; }
        [XmlElement("totalsum")]
        public string totalsum { get; set; }
        [XmlElement("total")]
        public string total { get; set; }
        [XmlElement("invalid")]
        public string invalid { get; set; }
        [XmlElement("failed")]
        public string failed { get; set; }
        [XmlElement("send_failed")]
        public string send_failed { get; set; }
        [XmlElement("success")]
        public string success { get; set; }
        [XmlElement("email_not_exist")]
        public string email_not_exist { get; set; }
        [XmlElement("spam_content")]
        public string spam_content { get; set; }
        [XmlElement("connect_error")]
        public string connect_error { get; set; }
        [XmlElement("actual")]
        public string actual { get; set; }
        [XmlElement("over_quota")]
        public string over_quota { get; set; }
        [XmlElement("user_reject")]
        public string user_reject { get; set; }
        [XmlElement("rubbish")]
        public string rubbish { get; set; }
        [XmlElement("rebate")]
        public string rebate { get; set; }
        [XmlElement("point")]
        public string point { get; set; }
    }


    [XmlRoot("data")]
    public class OpenDetailRes
    {
        [XmlElement("user")]
        public List<OpenDetailUser> user { get; set; }
    }

    [XmlRoot("user")]
    public class OpenDetailUser
    {
        [XmlElement("email_id")]
        public string email_id { get; set; }
        [XmlElement("email")]
        public string email { get; set; }
        [XmlElement("browser")]
        public string browser { get; set; }
        [XmlElement("os")]
        public string os { get; set; }
        [XmlElement("device")]
        public string device { get; set; }
        [XmlElement("addr_first")]
        public string addr_first { get; set; }
        [XmlElement("ip_first")]
        public string ip_first { get; set; }
        [XmlElement("ip_last")]
        public string ip_last { get; set; }
        [XmlElement("addr_last")]
        public string addr_last { get; set; }
        [XmlElement("open_total")]
        public string open_total { get; set; }
        [XmlElement("click_total")]
        public string click_total { get; set; }
        [XmlElement("open_first")]
        public string open_first { get; set; }
        [XmlElement("open_last")]
        public string open_last { get; set; }
        [XmlElement("click_first")]
        public string click_first { get; set; }
        [XmlElement("click_last")]
        public string click_last { get; set; }
    }

    [XmlRoot("track")]
    public class OverviewRes
    {
        [XmlElement("track_id")]
        public string track_id { get; set; }
        [XmlElement("task_sn")]
        public string task_sn { get; set; }
        [XmlElement("send_id")]
        public string send_id { get; set; }
        [XmlElement("send_count")]
        public string send_count { get; set; }
        [XmlElement("real_send_count")]
        public string real_send_count { get; set; }
        [XmlElement("error_send_count")]
        public string error_send_count { get; set; }
        [XmlElement("open_unique")]
        public string open_unique { get; set; }
        [XmlElement("open_total")]
        public string open_total { get; set; }
        [XmlElement("open_first")]
        public string open_first { get; set; }
        [XmlElement("open_last")]
        public string open_last { get; set; }
        [XmlElement("click_unique")]
        public string click_unique { get; set; }
        [XmlElement("click_total")]
        public string click_total { get; set; }
        [XmlElement("click_first")]
        public string click_first { get; set; }
        [XmlElement("click_last")]
        public string click_last { get; set; }
        [XmlElement("open_ratio")]
        public string open_ratio { get; set; }
        [XmlElement("email_id")]
        public string click_ratio { get; set; }
        [XmlElement("link_statistic")]
        public OverviewLinkStatistic link_statistic { get; set; }
    }

    [XmlRoot("link_statistic")]
    public class OverviewLinkStatistic
    {
        [XmlElement("link")]
        public List<OverviewLink> link { get; set; }
    }

    [XmlRoot("link")]
    public class OverviewLink
    {
        [XmlElement("link_id")]
        public string link_id { get; set; }
        [XmlElement("link")]
        public string link { get; set; }
        [XmlElement("click_unique")]
        public string click_unique { get; set; }
        [XmlElement("click_total")]
        public string click_total { get; set; }
        [XmlElement("click_first")]
        public string click_first { get; set; }
        [XmlElement("click_last")]
        public string click_last { get; set; }
    }



    [XmlRoot("maillist")]
    public class MailList
    {
        [XmlElement("item")]
        public List<MailItem> item { get; set; }
    }
    [XmlRoot("item")]
    public class MailItem
    {
        [XmlElement("id")]
        public string id { get; set; }
        [XmlElement("subject")]
        public string subject { get; set; }
        [XmlElement("descrīption")]
        public string description { get; set; }
        [XmlElement("count")]
        public string count { get; set; }
        [XmlElement("input_status")]
        public string input_status { get; set; }
        [XmlElement("status")]
        public string status { get; set; }
    }
    #endregion

    #region 查询SI活动可执行状态 返回实体
    public class SiActivityExecutableStatusEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 活动已取消
        /// </summary>
        public string Msg { get; set; }
    }

    public class SiActivityExecutableStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public SiActivityExecutableStatusEntity Entity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsSucceed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StatusCode { get; set; }
    }
    #endregion

    public class MesStock
    {
        [Description("第一个"), ExcelAnnotations("第一个")]
        public string Deid { get; set; }
        [Description("第二个"), ExcelAnnotations("第二个")]
        public string Pno { get; set; }
        [Description("第三个"), ExcelAnnotations("第三个")]
        public string Sno { get; set; }
        [Description("第四个"), ExcelAnnotations("第四个")]
        public int TotalNums { get; set; }
    }

    // 定义特性用于excel批注
    public class ExcelAnnotations : Attribute
    {
        public string Value { get; }

        public ExcelAnnotations(string value)
        {
            Value = value;
        }
    }
}
