using esercitazioneLinq3;

Biblioteca biblioteca = new Biblioteca();

Utente mario = new Utente("Mario", "Rossi", "mario.rossi@mail.it" ,"passwordsupersicura", 3289999999);
Utente luigi = new Utente("Luigi", "Bianchi", "luigi.bianchi@mail.it" ,"€LèG4nt3", 3896666666);
biblioteca.utenti.Add(mario);
biblioteca.utenti.Add(luigi);

Autore franco = new Autore("Franco", "Bellapenna");
Autore artura = new Autore("Artura", "Buonascrittura");
biblioteca.autori.Add(franco);
biblioteca.autori.Add(artura);

Scaffale scaffale1 = new Scaffale(1);
Scaffale scaffale2 = new Scaffale(2);

Libro primoLibro = new Libro("123-456-789", "Un libro a caso", DateTime.Now, "storia", Stato.disponibile, scaffale1 ,200);
DVD primoDVD = new DVD("ABC123DEF456GHI789", "I 3 moschettieri", DateTime.Now.AddYears(-30), 
    "Intrattenimento per bambini", Stato.in_prestito, scaffale2 ,2000);

biblioteca.documenti.Add(primoLibro);
biblioteca.documenti.Add(primoDVD);

biblioteca.prestiti.Add(new Prestito(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(1), primoDVD, mario));



 biblioteca.ricercaDocumento("Un libro a caso");
 biblioteca.ricercaPrestitoTramiteNome("Mario");
 biblioteca.nuovoPrestito(new Prestito(DateTime.Now.AddDays(5), DateTime.Now.AddMonths(1), primoLibro, luigi));