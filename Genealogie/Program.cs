// See https://aka.ms/new-console-template for more information
using Genealogie;

string[] genres = new string[] { "fils", "fille" };

/*
 * ------------------------------Père--------------------------------1
 * ------Fils---------        ----Fils-----      ----Fils------2
 * Petit Fils soeur     moi       Cousin 1 Cousin 2     Cousin 3 Cousin43
 *       Arrière petit fils   4
 * */





printChild(populateFamily(5), "  ");

/*
 * 
 * Créer une famille depuis Papi,avec nbGeneration générations
 * Chaque membre aura un nombre aléatoire d'enfant
 * 
 * */
Humain populateFamily(int nbGenerationSousParentActuel, Humain parentActuel=null, int cptGeneration= 0)
{
    //JE dois créer papi si parentActuel est null
    if(parentActuel == null)
    {
        parentActuel = new Humain("Père", new List<Humain>());
    }
    cptGeneration++;
    if (nbGenerationSousParentActuel != 0)
    {
        //Je génère un nombre aléatoire
        //Ce sera son nombre d'enfant
        Random rnd = new Random();
        int nbChild = rnd.Next(4);//chiffre entre 0 et 3

        //Je dois ajouter les enfants à papi
        for (int i = 0; i < nbChild; i++)
        {
            //J'ai fils
            //Au hasard que ce soit fils ou fille
            string nameChild = genres[rnd.Next(2)];

            if (cptGeneration >= 2)
            {
                if (nameChild == genres[1])
                {
                    nameChild = "Petite " + nameChild;

                }
                else
                {
                    nameChild = "Petit " + nameChild;
                }
            }
            
            if (cptGeneration >= 3)
            {
                //je veux ajouter 'Arrière' cptArriere fois
                int cptArriere = cptGeneration - 2;

                for (int j = 0; j < cptArriere; j++)
                {
                    nameChild = "Arrière " + nameChild;
                }
            }

            var child = new Humain(nameChild, new List<Humain>());
            //J'ajoute des enfants à chacuns de mes enfants
            populateFamily(nbGenerationSousParentActuel - 1, child, cptGeneration);
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
        printChild(child, indent+ "            ");
    }
}
