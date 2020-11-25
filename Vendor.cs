using Ac4y.Annotation;
using System;

namespace VendorPlanObject
{
    public class Vendor
    {
        [Ac4yDescription("Az adatbázis által generált érték")]
        [Ac4yExampleValue("2")]
        public int Id { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó név")]
        [Ac4yExampleValue("Nagy Károly")]
        public string Nev { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A szerződés kategóriáját írja le")]
        [Ac4yExampleValue("valamilyen kategória")]
        public string Kategoria { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("Az ország, amiben a szerződéshez tartozó székhely van")]
        [Ac4yExampleValue("Magyarország")]
        public string SzekhelyOrszag { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó székhely régiója")]
        [Ac4yExampleValue("Nagy Károly")]
        public string SzekhelyRegio { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó székhely városa")]
        [Ac4yExampleValue("Nagy Károly")]
        public string SzekhelyVaros { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó székhely címe")]
        [Ac4yExampleValue("Nagy Károly")]
        public string SzekhelyCim { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekord milyen szolgáltatási területhez tartozik")]
        [Ac4yExampleValue("Nagy Károly")]
        public string SzolgaltatasiTerulet { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó telefonszám")]
        [Ac4yExampleValue("+36701234567")]
        public string Telefon { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó WhatsApp elérhetőség")]
        [Ac4yExampleValue("-")]
        public string WhatsApp { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó email cím")]
        [Ac4yExampleValue("teszt@email.hu")]
        public string Email { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.DATETIME)]
        [Ac4yDescription("A szerződés kezdetét jelentő dátum")]
        [Ac4yExampleValue("Nagy Károly")]
        public DateTime SzerzodesKezdete { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.DATETIME)]
        [Ac4yDescription("A szerződés végét jelentő dátum")]
        [Ac4yExampleValue("Nagy Károly")]
        public DateTime SzerzodesVege { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A már teljesített szerződések száma")]
        [Ac4yExampleValue("12")]
        public long TeljesitettSzerzodesekSzama { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("Az élő/aktív szerződések száma")]
        [Ac4yExampleValue("4")]
        public long AktivSzerzodesekSzama { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("Az összes szerződés értéke forintban")]
        [Ac4yExampleValue("55230000")]
        public double OsszesSzerzodesErteke { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A már teljesített szerződés értéke forintban")]
        [Ac4yExampleValue("2000000")]
        public double TeljesitettSzerzodesErteke { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("Az érvényes, aktív szerződés értéke forintban")]
        [Ac4yExampleValue("5000000")]
        public double AktivSzerzodesErteke { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó fizetett jutalék összege forintban")]
        [Ac4yExampleValue("102550")]
        public double FizetettJutalek { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        [Ac4yDescription("A rekordhoz tartozó rendezetlen jutalék összege forintban")]
        [Ac4yExampleValue("100000")]
        public double RendezetlenJutalek { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        [Ac4yDescription("A szerződés érvényességét jelzi")]
        [Ac4yExampleValue("true")]
        public bool EloSzerzodes { get; set; }

    }
}
