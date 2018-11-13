using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecajnaLista
{
    public class Tecajna
    {
        //public string Ime { get; set; }
        //public string Prezime { get; set; }

        [JsonProperty(PropertyName = "Broj tečajnice")]
        public string Brojtecajnice { get; set; }
        [JsonProperty(PropertyName = "Datum primjene")]
        public string Datumprimjene { get; set; }
        [JsonProperty(PropertyName = "Država")]
        public string Drzava { get; set; }
        [JsonProperty(PropertyName = "Šifra valute")]
        public string Sifravalute { get; set; }
        public string Valuta { get; set; }
        public string Jedinica { get; set; }
        [JsonProperty(PropertyName = "Kupovni za devize")]
        public decimal Kupovnizadevize { get; set; }
        [JsonProperty(PropertyName = "Srednji za devize")]
        public string Srednjizadevize { get; set; }
        [JsonProperty(PropertyName = "Prodajni za devize")]
        public string Prodajnizadevize { get; set; }
    }
}