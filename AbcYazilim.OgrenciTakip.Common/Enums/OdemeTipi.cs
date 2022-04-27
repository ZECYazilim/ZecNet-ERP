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
        [Description("AÇIK")]
        Acik=1,
        [Description("ÇEK")]
        Cek =2,
        [Description("ELDEN")]
        Elden =3,
        [Description("E-POS")]
        Epos =4,
        [Description("OTS")]
        Ots =5,
        [Description("POS")]
        Pos =6,
        [Description("SENET")]
        Senet =7
    }
}
