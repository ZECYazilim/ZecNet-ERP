using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum OdemeTipi:byte
    {
        [Description("Açık")]
        Acik=1,
        [Description("Çek")]
        Cek =2,
        [Description("Elden")]
        Elden =3,
        [Description("Epos")]
        Epos =4,
        [Description("Ots")]
        Ots =5,
        [Description("Pos")]
        Pos =6,
        [Description("Senet")]
        Senet =7
    }
}
