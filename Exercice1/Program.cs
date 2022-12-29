using System.Diagnostics;

Console.WriteLine("Bonjour et bienvenue dans le jeu du juste prix");

List<int> allGamesResult = new List<int>();

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
    Console.WriteLine("");

    allGamesResult.Add(cptTours);

    Console.WriteLine("---- STATISTIQUES ----");
    /*Transformer ces 4 méthodes LINQ en méthode faite à la main 1*/
    Console.WriteLine($"Nb victoires : {getNbVictoires(allGamesResult)}");
    Console.WriteLine($"Nb défaites : {getNbDefeat(allGamesResult)}");
    Console.WriteLine($"Meilleur score :{getMin(allGamesResult)}");
    Console.WriteLine($"Moyenne: {getAverage(allGamesResult)}");



    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Voulez-vous faire une nouvelle partie ? O/N");
    string reponse = Console.ReadLine();

    if (reponse != "O" && reponse != "o")
    {
        newGame = false;
    }
}

int getMin(List<int> maListe)
{
    int min = 11100;

    foreach (int number in maListe)
    {
        if (number < min)
        {
            min = number;
        }
    }

    return min;
}


int getNbVictoires(List<int> mesScores)
{
    int nbVictory = 0;
    foreach(int scores in mesScores){
        if (scores < 10){
            nbVictory++; 
        }
    }
    return nbVictory;
}
int getNbDefeat(List<int> mesScores)
{
    int nbDefeat = 0;
    foreach(int scores in mesScores){
        if (scores >= 10){
            nbDefeat++; 
        }
    }
    return nbDefeat;
}

double getAverage(List<int> mesScores){
    // score:      5      8     10
    // nbTotal 0   5    5+8=13  13+10=23
    
    // la moyenne -> nbTotal / nbElement
    //23 /3
    double nbElement = 0;
    double nbTotal =0;
    foreach(double score in mesScores){
        nbElement++;
        nbTotal = nbTotal + score;
    }
    double Average = nbTotal / nbElement;
    return Average;
}