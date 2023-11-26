using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneLinq3
{
    internal class DVD : Documento
    {
        int durata { get; set; }

        public DVD(string codice, string titolo, DateTime anno, string settore, Stato stato, Scaffale scaffale, int durata) : base(codice, titolo, anno, settore, stato, scaffale)
        {
            this.durata = durata;
        }        
    }
}
