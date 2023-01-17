// See https://aka.ms/new-console-template for more information
using Genealogie;


/*
 * ------------------------------Papi--------------------------------
 * ------Papa---------        ----Tonton-----      ----Tatie------
 * Frere soeur     moi       Cousin 1 Cousin 2     Cousin 3 Cousin4
 *       neuveu   
 * */





printChild(populateFamily(4), "  ");

/*
 * 
 * Créer une famille depuis Papi,avec nbGeneration générations
 * Chaque membre aura un nombre aléatoire d'enfant
 * 
 * */
Humain populateFamily(int nbGenerationSousParentActuel, Humain parentActuel=null)
{
    //JE dois créer papi si parentActuel est null
    if(parentActuel == null)
    {
        parentActuel = new Humain("Papi", new List<Humain>());
    }

    if (nbGenerationSousParentActuel != 0)
    {
        //Je génère un nombre aléatoire
        //Ce sera son nombre d'enfant
        Random rnd = new Random();
        int nbChild = rnd.Next(4);//chiffre entre 0 et 3

        //Je dois ajouter les enfants à papi
        for (int i = 0; i < nbChild; i++)
        {
            var child = new Humain("Fils", new List<Humain>());
            //J'ajoute des enfants à chacuns de mes enfants
            populateFamily(nbGenerationSousParentActuel - 1, child);
            parentActuel.Enfants.Add(child);
        }

    }

    return parentActuel;
}

void printChild(Humain man, string indent)
{
    Console.WriteLine(indent + man.Nom);
    foreach (var child in man.Enfants)
    {
        printChild(child, indent+ "  ");
    }
}
