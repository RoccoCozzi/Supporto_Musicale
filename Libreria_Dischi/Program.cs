
using Libreria_Dischi;

Supporto_Musicale supporto = new()
{
    id = 34,
    nome = "beatols",
    descrizione = "beeeeello",
    prezzo_unitario = 9.99m
};

Brano brano = new()
{
    codice = 366655,
    titolo = "The Song",
    genere = "Rock",
    durata = 3.54m
};

supporto.ListaBrani.Add(brano);

Console.WriteLine(supporto);
Console.WriteLine(brano);
