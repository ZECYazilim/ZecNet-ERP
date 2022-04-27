using System.ComponentModel;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum KanGrubu:byte
    {
        [Description("Bilinmiyor")]
        Bos =0,
        [Description("0 Rh-")]
        SifirNegatif=1,
        [Description("0 Rh+")]
        SifirPozitif =2,
        [Description("A Rh-")]
        ANegatif =3,
        [Description("A Rh+")]
        APozitif =4,
        [Description("B Rh-")]
        BNegatif =5,
        [Description("B Rh+")]
        BPozitif =6,
        [Description("ABRh-")]
        ABNegatif =7,
        [Description("AB Rh+")]
        ABPozitif =8
    }
}