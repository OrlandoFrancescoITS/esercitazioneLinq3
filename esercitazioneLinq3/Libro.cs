using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneLinq3
{
    internal class Libro : Documento
    {
        int numeroPagine { get; set; }
        public Libro(string codice, string titolo, DateTime anno, string settore, Stato stato, Scaffale scaffale, int numeroPagine) : base(codice, titolo, anno, settore, stato, scaffale)
        {
            this.numeroPagine = numeroPagine;
        }      
    }
}
