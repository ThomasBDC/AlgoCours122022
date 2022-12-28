using System.Diagnostics;

Console.WriteLine("Bonjour et bienvenue dans le jeu du juste prix");

bool newGame = true;

int[] maxNbToFind = new int[]
{
    //Facile
    100,
    //Moyen
    500, 
    //Difficile
    1000
};

while(newGame)
{

    
    //---------------Début de la partie---------------
    int maxNbTours = 10;

    //Récupérer un entier aléatoire
    Random rnd = new Random();
    Console.WriteLine("Niveau de la partie : facile | moyen | difficile");
    string reponseNiveau = Console.ReadLine();
    int maxNb = 100;
    switch (reponseNiveau)
    {
        case "facile":
            maxNb = maxNbToFind[0];
            break;
        case "moyen":
            maxNb = maxNbToFind[1];
            break;
        case "difficile":
            maxNb = maxNbToFind[2];
            break;
        default:
            Console.WriteLine("Pas compris, le max sera donc de 100");
            break;
    }

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Je réfléchis à un nombre entre 1 et {maxNb} ....");
    Console.WriteLine("Essaye de le deviner !");
    Console.ForegroundColor = ConsoleColor.White;
    int nbToFind = rnd.Next(1, maxNb);

    int propositionNb = 0;
    int cptTours = 0;


    //---------------Chaque tour---------------
    do
    {
        bool propositionValid = false;
        do
        {
            Console.WriteLine("Quel est votre proposition");
            string proposition = Console.ReadLine();
            try
            {
                //Le code qui peut échouer
                propositionNb = Convert.ToInt32(proposition);

                propositionValid = true;
            }
            catch
            {
                //Le code qui est exécuté si cela a échoué
                Console.WriteLine("Merci d'entrer un entier numérique");
                propositionValid = false;
            }
        } while (propositionValid == false);


        if (nbToFind > propositionNb)
        {
            Console.WriteLine($"C'est plus");
        }
        else if (nbToFind < propositionNb)
        {
            Console.WriteLine("C'est moins");
        }
        cptTours++;
        Console.WriteLine($"Tours restants :{(maxNbTours - cptTours)}");
    }
    while (nbToFind != propositionNb && cptTours < maxNbTours);

    //---------------Partie terminée---------------
    if (nbToFind == propositionNb)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"BRAVOOO, vous avez gagné en {cptTours} essai(s) !!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Perdu, le nombre était {nbToFind}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Voulez-vous faire une nouvelle partie ? O/N");
    string reponse = Console.ReadLine();

    if (reponse != "O" && reponse != "o")
    {
        newGame = false;
    }
}
