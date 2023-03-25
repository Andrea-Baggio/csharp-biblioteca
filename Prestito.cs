public class Prestito
{
    public DateTime? InizioPrestito { get; set; }
    public DateTime? FinePrestito { get; set; }
    public Documento Documento { get; set; }
    public UtenteRegistrato Utente { get; set; }


    public Prestito(Documento documento, UtenteRegistrato utente) { 
        Documento = documento;
        Utente = utente;
    }
}
