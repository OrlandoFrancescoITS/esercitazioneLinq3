using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneLinq3
{
    internal class Documento
    {
        public string codice {  get; set; }
        public string titolo { get; set; }
        public DateTime anno { get; set; }
        public string settore { get; set; }
        public Stato stato { get; set; }
        public Scaffale scaffale { get; set; }

        public Documento(string codice, string titolo, DateTime anno, string settore, Stato stato, Scaffale scaffale)
        {
            this.codice = codice;
            this.titolo = titolo;
            this.anno = anno;
            this.settore = settore;
            this.stato = stato;
            this.scaffale = scaffale;
        }
    }
}
