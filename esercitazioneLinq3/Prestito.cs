using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneLinq3
{
    internal class Prestito
    {
        public DateTime dal { get; set; }
        public DateTime al { get; set; }
        public Documento documento { get; set; }
        public Utente utente { get; set; }

        public Prestito(DateTime dal, DateTime al, Documento documento, Utente utente)
        {
            this.dal = dal;
            this.al = al;
            this.documento = documento;
            this.utente = utente;
        }
    }
}
