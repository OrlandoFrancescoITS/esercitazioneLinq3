using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneLinq3
{
    internal class Persona
    {
        public string nome {  get; set; }
        public string cognome { get; set; }

        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }
    }
}
