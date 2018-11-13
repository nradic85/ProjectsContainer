using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace provjeriOIB
{
    public partial class _default : System.Web.UI.Page
    {
        public ulong zbroj; //deklaracija varijable koja nam koristi za preračunavanje OIB-a
        public ulong kontrola; //deklaacija varijable koja nam koristi za kontrolu zadnje znamenke
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendOIB_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbOIB.Text, "[^0-9]")) //provjera ako je unesena vrijednost broj ako je izvršava se if
            {
                if (tbOIB.Text.Length == 11) //ako je dužina unesene vrijednosti 11 onda se izvršava blok u nastavku
                {
                    ulong temp = Convert.ToUInt64(tbOIB.Text); //deklaracija privremene varijable koja će nam koristi za splitanje broja 
                    ulong[] temp1 = new ulong[tbOIB.Text.Length]; //deklaracija polja u koje cemo krcati broj
                    for (int j = tbOIB.Text.Length - 1; j >= 0; j--) //punjenje broja u polje
                    {
                        temp1[j] = temp % 10;
                        temp /= 10;
                    }
                    for (int i = 0; i < tbOIB.Text.Length; i++) //provjera ispravnosti broja
                    {
                        if (i == tbOIB.Text.Length - 1)
                        {
                            kontrola = 11 - zbroj;
                            if (kontrola == 10)
                            {
                                kontrola = 0;
                            }
                            if (kontrola == temp1[i])
                            {
                                lblOutput.Text = "OIB je valjan!";
                                lblOutput.Visible = true;
                            }
                            else
                            {
                                lblOutput.Text = "OIB nije valjan!";
                                lblOutput.Visible = true;
                            }
                        }
                        if (i != 0 && i != tbOIB.Text.Length - 1)
                        {
                            zbroj += temp1[i];
                            zbroj %= 10;
                            if (zbroj == 0) { zbroj = 10; }
                            zbroj *= 2;
                            zbroj %= 11;
                        }
                        else
                        {
                            zbroj = temp1[i] + 10;
                            zbroj %= 10;
                            if (zbroj == 0) { zbroj = 10; }
                            zbroj *= 2;
                            zbroj %= 11;
                        }
                    }
                }
                else //ako dužina unesene vrijednosti nije 11 ona se ispisuje poruka u nastavku
                {
                    lblOutput.Text = "OIB nije valjane dužine!";
                    lblOutput.Visible = true; 
                }
            }
            else //ako unesena vrijednost nije brojčana onda se ispisuje poruka u nastavku
            {
                lblOutput.Text = "OIB treba biti brojčana vrijednost!";
                lblOutput.Visible = true;
            }
        }
    }
}