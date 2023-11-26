using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneLinq3
{
    internal class Utente : Persona
    {
        public string email { get; set; }
        public string password { get; set; }
        public long telefono { get; set; }
        public Utente(string nome, string cognome, string email, string password, long telefono) : base(nome, cognome)
        {
            this.email = email;
            this.password = password;
            this.telefono = telefono;
        }
    }
}
