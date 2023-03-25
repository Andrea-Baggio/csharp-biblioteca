class Dvd : Documento
{
    public Dvd(string codice, string titolo) : base(codice, titolo)
    {
    }

    public int length { get; set; }
}