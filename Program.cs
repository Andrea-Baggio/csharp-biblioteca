UtenteRegistrato user = new UtenteRegistrato("Cognome", "Nome", "email123", "password1234", "346740284");

Console.WriteLine($"Cognome: {user.Cognome}");
Console.WriteLine($"Nome: {user.Nome}");
Console.WriteLine($"Email: {user.Email}");
Console.WriteLine($"Password: {user.Password}");
Console.WriteLine($"N. cellulare: {user.Telefono}");

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


class Libro : Documento
{
    public int NumPage { get; set; }

    public Libro(int numPage)
    {
        NumPage = numPage;
    }
}


class Dvd : Documento
{
    public TimeSpan length { get; set; }
}


public class Biblioteca
{
    public List<Documento> ListaDocumenti { get; set; }
    public List<UtenteRegistrato> ListaUtenti { get; set; }



    public Biblioteca()
    {
        ListaDocumenti = new List<Documento>();
        ListaUtenti = new List<UtenteRegistrato>();
    }

    //public Documento CercaDocumento(string codice)
    //{

    //    foreach(Documento documento in ListaDocumenti)
    //    {
    //        if(documento.Codice == codice)
    //        {
    //            return documento;
    //        }
    //    }

    //    //non ho trovato niente
    //    return null;
    //}

    public Documento CercaDocumento(string titolo)
    {

        foreach (Documento documento in ListaDocumenti)
        {
            if (documento.Titolo == titolo)
            {
                return documento;
            }
        }

        //non ho trovato niente
        return null;
    }
}