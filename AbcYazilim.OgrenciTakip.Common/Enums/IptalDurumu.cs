using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcYazilim.OgrenciTakip.Common.Enums
{
    public enum IptalDurumu:byte
    {
        [Description("İptal Edildi")]
        IptalEdildi=1,
        [Description("Devam Ediyor")]
        DevamEdiyor=2
    }
}
