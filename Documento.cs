public class Documento
{
    public string Codice { get; set; } = string.Empty;
    public string Titolo { get; set; } = string.Empty;
    public string? Settore { get; set; } = string.Empty;
    public string? Scaffale { get; set; } = string.Empty;
    public string? Autore { get; set; } = string.Empty;



    public Documento(string codice, string titolo) { 
        Codice = codice;
        Titolo = titolo;
    }
}
