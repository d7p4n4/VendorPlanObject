using Ac4y.Annotation;
using System;

namespace VendorPlanObject
{
    public class Vendor
    {
        public int Id { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string Nev { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string Kategoria { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string SzekhelyOrszag { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string SzekhelyRegio { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.COMBOBOX)]
        public string SzekhelyVaros { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string SzekhelyCim { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string SzolgaltatasiTerulet { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string Telefon { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string WhatsApp { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public string Email { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.NODEF)]
        public DateTime SzerzodesKezdeteTelefon { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.NODEF)]
        public DateTime SzerzodesVegeTelefon { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public long TeljesitettSzerzodesekSzama { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public long AktivSzerzodesekSzama { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public double OsszesSzerzodesErteke { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public double TeljesitettSzerzodesErteke { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public double AktivSzerzodesErteke { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public double FizetettJutalek { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.TEXTBOX)]
        public double RendezetlenJutalek { get; set; }
        [Ac4yWidgetType(Ac4yWidgetType.WidgetEnum.CHECKBOX)]
        public bool EloSzerzodes { get; set; }

    }
}
