UtenteRegistrato utentes = new UtenteRegistrato("Gognome", "Bone", "yoyo98email", "gattiPleonastici", "3456776543");

Console.WriteLine($"Codice prodotto: {utentes.Cognome}");


public class UtenteRegistrato
{
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Telefono { get; set; }    
    //public bool Registrato { get; set; } poi vedi se riesci a fare la distinzione tra registrato e non


    public UtenteRegistrato(string cognome, string nome, string email, string password, string telefono)
    {
        Cognome = cognome;
        Nome = nome;
        Email = email;
        Password = password;
        Telefono = telefono;
    }

}


public class Documento
{
    public string Codice { get; set; }
    public string Titolo { get; set; }
    public string Settore { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; set; }
}
