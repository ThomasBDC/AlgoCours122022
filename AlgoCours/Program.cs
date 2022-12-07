using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

string[,] villes = new string[,]
{
    {"Toulouse",    "25"},
    {"Marseille",   "50"},
    {"Lyon",        "77"},
    {"Paris",       "185"},
    {"Nantes",      "250"},
    {"Montpellier", "55"}
};

//Message de bienvenue
Console.WriteLine("Bonjour et bienvenue à la gare de Carcassonne. Voici les destinations possibles : ");
WriteAllCities();
//Demande données utilisateur
Console.WriteLine("Quel est votre prénom ?");
string prenom = Console.ReadLine();

Console.WriteLine("Bonjour " + prenom+", quel est votre âge ?");
int age = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Ou voulez allez ?");
WriteAllCities();

string destination = Console.ReadLine();

decimal prix = GetPriceForCity(destination);

//Si le prix n'a pas été changé, c'est que la ville n'existe pas
if (prix == -1)
{
    Console.WriteLine("Ville introuvable");
}
else //Sinon ça veut dire qu'on peut continuer
{
    decimal promotion = GetPromotionForAge(age);

    Console.WriteLine("Prix de base en euros");
    Console.WriteLine(prix);

    Console.WriteLine("Remise en %");
    Console.WriteLine(promotion);

    Console.WriteLine("Remise en euros");
    Console.WriteLine(CalculRemise(promotion, prix));
    
    Console.WriteLine("Prix remisé en euros");
    Console.WriteLine(CalculPrixRemise(promotion, prix));
}



//Demander qqchose à l'utilisateur 
Console.ReadLine();


#region Fonctions

void WriteAllCities()
{
    string mesVilles = "";
    for (int i = 0; i < villes.GetLength(0); i++)
    {
        mesVilles += villes[i, 0] + " !%! ";
    }
    Console.WriteLine(mesVilles);
}

decimal CalculRemise(decimal promotion, decimal prix)
{
    decimal remise = (promotion / 100) * prix;
    return remise;
}

decimal CalculPrixRemise(decimal promotion, decimal prix)
{
    //Calculer la remise 
    decimal remise = CalculRemise(promotion, prix);
    //Faire prix - remise
    decimal prixRemise = prix - remise;
    return prixRemise;
}

decimal GetPromotionForAge(int age)
{
    decimal promotion = 0;
    if (age < 19)
    {
        promotion = 50;
    }
    else if (age > 77 || age < 33)
    {
        promotion = 25;
    }
    else
    {
        promotion = 0;
    }
    return promotion;
}

decimal GetPriceForCity(string destination)
{
    decimal prix = -1;

    // On parcourt les villes on aura pour chaque incrément
    // Ville -> villes[i,0]
    // Prix -> villes[i,1]
    for (int i = 0; i < villes.GetLength(0); i++)
    {
        if (villes[i, 0] == destination)
        {
            prix = Convert.ToDecimal(villes[i, 1]);
        }
    }

    return prix;
}
#endregion