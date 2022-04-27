using System;

namespace AbcYazilim.OgrenciTakip.Model.Attributes
{
    public class Kod:Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        /// <summary>
        /// Validation işlemleri sırasında zorunlu olan alanları işaretlemek için kullanılacak.
        /// </summary>
        /// <param name="description"> Uyarı Mesajında gösterilecek olan açıklama</param>
        /// <param name="controlName"> mesaj sonrası odaklanılacak kontrol adı</param>
        public Kod(string description,string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}
