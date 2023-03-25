public class Biblioteca
{
    public List<Documento> ListaDocumenti = new();
    public List<UtenteRegistrato> ListaUtenti = new();
    public List<Prestito> ListaPrestiti = new();


    public void AggiungiDocumento(Documento documento) => ListaDocumenti.Add(documento);
    public void AggiungiUtente(UtenteRegistrato utente) => ListaUtenti.Add(utente);
    public void AggiungiPrestito(Prestito prestito) => ListaPrestiti.Add(prestito);


    public Documento? CercaPerCodice(string codice) => ListaDocumenti.FirstOrDefault(documento => documento.Codice == codice);
    public IEnumerable<Documento> CercaPerTitolo(string titolo) => ListaDocumenti.Where(documento => documento.Titolo == titolo);
    public IEnumerable<Prestito> CercaPrestito(string nomeUtente, string cognomeUtente) =>
            ListaPrestiti.Where(prestito => prestito.Utente.Nome == nomeUtente && prestito.Utente.Cognome == cognomeUtente);
}