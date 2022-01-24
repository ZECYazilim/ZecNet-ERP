using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum KartTuru : byte
    {
        [Description("Okul Kartı")]
        Okul=1,
        [Description("İl Kartı")]
        Il =2,
        [Description("İlçe Kartı")]
        Ilce =3
    }
}
