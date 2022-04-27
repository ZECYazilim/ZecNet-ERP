using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum RaporuKagidaSigdirmaTuru:byte
    {
        [Description("Sütünları Daraltarak Sığdır")]
        SutunlariDaraltarakSigdir=1,
        [Description("Yazı Boyutunu Küçülterek Sığdır")]
        YaziBoyutunuKuculterekSigdir =2,
        [Description("İşlem Yapma")]
        IslemYapma =3
    }
}
