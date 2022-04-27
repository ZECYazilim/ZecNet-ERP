using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum BankaHesapTuru:byte
    {
        [Description("VADESİZ MEVDUAT HESABI")]
        VadesizMevduatHesabi=1,
        [Description("VADELİ MEVDUAT HESABI")]
        VadeliMevduatHesabi =2,
        [Description("KREDİ HESABI")]
        KrediHesabi =3,
        [Description("E-POS BLOKE HESABI")]
        EposBlokeHesabi =4,
        [Description("OTS BLOKE HESABI")]
        OtsBlokeHesabi =5,
        [Description("POS BLOKE HESABI")]
        PosBlokeHesabi =6,
        [Description("BLOKE ÇÖZÜM HESABI")]
        BlokeCozumHesabi =7
    }
}