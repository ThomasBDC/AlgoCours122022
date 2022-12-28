using System.Diagnostics;

Console.WriteLine("Bonjour et bienvenue dans le jeu du juste prix");

bool newGame = true;

while(newGame)
{

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Je réfléchis à un nombre entre 1 et 100 ....");
    Console.WriteLine("Essaye de le deviner !");
    Console.ForegroundColor = ConsoleColor.White;
    //---------------Début de la partie---------------
    int maxNbTours = 10;
    //Récupérer un entier aléatoire
    Random rnd = new Random();
    int nbToFind = rnd.Next(1, 100);

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
        Console.WriteLine("Gagné");
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
