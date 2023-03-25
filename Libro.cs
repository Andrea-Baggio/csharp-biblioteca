class Libro : Documento
{
    public Libro(string codice, string titolo) : base(codice, titolo)
    {
    }

    public int? NumPage { get; set; }
}
