public class UtenteRegistrato
{
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Telefono { get; set; }    

    public UtenteRegistrato(string cognome, string nome)
    {
        Cognome = cognome;
        Nome = nome;
    }

}
