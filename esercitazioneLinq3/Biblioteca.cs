using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneLinq3
{
    internal class Biblioteca
    {
        public List<Documento> documenti { get; set; } = new List<Documento> { };
        public List<Autore> autori { get; set; } = new List<Autore> { };
        public List<Utente> utenti { get; set; } = new List<Utente> { };
        public List<Prestito> prestiti { get; set; } = new List<Prestito> { };
        Dictionary<string, Prestito> indicePrestiti { get; set; } = new Dictionary<string, Prestito> { };

        public void ricercaDocumento(string elementoDiRicerca) 
        {
            Documento documentoTrovato = documenti.Find(x => x.titolo == elementoDiRicerca);
            if (documentoTrovato != null)
                Console.WriteLine($"{documentoTrovato.codice} | {documentoTrovato.anno} | {documentoTrovato.settore}");
        }
        void generaCodice(Prestito prestito) 
        {
            string caratteri = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            string codice = "";
            for (int i = 0; i < 15; i++) 
            {
                codice = codice + caratteri[random.Next(0, caratteri.Length)];  
            }
            indicePrestiti.Add(codice, prestito);
        }
        public void nuovoPrestito(Prestito prestito) { prestiti.Add(prestito); generaCodice(prestito); }
        public void ricercaPrestitoTramiteNome(string nomeUtente) 
        {
            List<Prestito> prestitiTrovati = prestiti.FindAll(x => x.utente.nome == nomeUtente);
            if (prestitiTrovati != null) 
            {
                foreach (Prestito p in prestitiTrovati) 
                {
                    Console.WriteLine($"{p.utente.nome} {p.utente.cognome} ha richiesto il prestito di '{p.documento.titolo}' dal {p.dal.ToString("dd/MM/yyyy")} al {p.al.ToString("dd/MM/yyyy")}");
                }
            }
        }
        public void ricercaPrestitoTramiteCognome(string cognomeUtente)
        {
            List<Prestito> prestitiTrovati = prestiti.FindAll(x => x.utente.cognome == cognomeUtente);
            if (prestitiTrovati != null)
            {
                foreach (Prestito p in prestitiTrovati)
                {
                    Console.WriteLine($"{p.utente.nome} {p.utente.cognome} ha richiesto il prestito di {p.documento.titolo} dal {p.dal.ToString("dd/MM/yyyy")} al {p.al.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
