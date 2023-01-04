// See https://aka.ms/new-console-template for more information
using Genealogie;

Humain Papi = new Humain("Papi", new List<Humain>
{
    new Humain("Papa", new List<Humain>() 
    { 
        new Humain("Frère", new List<Humain>()), 
        new Humain("Soeur", new List<Humain>()
        {
            new Humain("Neuveu", new List<Humain>())
        }),
        new Humain("Moi", new List<Humain>()),
    }),
    new Humain("Tonton", new List<Humain>()
    {
        new Humain("Cousin 1", new List<Humain>()),
        new Humain("Cousin 2", new List<Humain>()),
    }),
    new Humain("Tatie", new List<Humain>()
    {
        new Humain("Cousin 3", new List<Humain>()),
        new Humain("Cousin 4", new List<Humain>()),
    }),
});


printChild(Papi, "  ");


void printChild(Humain man, string indent)
{
    Console.WriteLine(indent + man.Nom);
    foreach (var child in man.Enfants)
    {
        printChild(child, indent+ "  ");
    }
}
