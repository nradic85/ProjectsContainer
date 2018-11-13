using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace TecajnaLista
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int number = 123456789;
            //int temp1 = number.ToString().Length;
            //int temp2 = Math.Floor(Math.Log10(123456789)+1);
            ddlValuta1.DataValueField = "EUR";
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(ConfigurationManager.AppSettings["tecajnaListaAPI"]));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream);//, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }
            List<Tecajna> items = JsonConvert.DeserializeObject<List<Tecajna>>(jsonString);

            var srednjiZaDevize = float.Parse(items[0].Srednjizadevize, CultureInfo.InvariantCulture.NumberFormat)*0.000001;

            ddlValuta1.DataSource = items.ToList();
            ddlValuta1.DataTextField = "Valuta";
            ddlValuta1.DataValueField = "Kupovnizadevize";
            
            ddlValuta1.DataBind();
            //decimal kupovniZaDevize = ddlValuta1.DataValueField = "Kupovnizadevize";
            //decimal stranaValuta = decimal.Parse(tbStranaValuta.ToString());
            //lblKukujemKune = stranaValuta * kupovniZaDevize *0.000001;

            ddlValuta2.DataSource = items.ToList();
            ddlValuta2.DataTextField = "Valuta";
            ddlValuta2.DataValueField = "Prodajnizadevize";
            ddlValuta2.DataBind();

            //ovo je
        }
    }
}