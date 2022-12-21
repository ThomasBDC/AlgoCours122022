using System.Diagnostics;

Console.WriteLine("Bonjour et bienvenue dans le jeu du juste prix");
Console.WriteLine("Essayez de deviner un nombre entre 1 et 100");

int maxPropal = 10;
//Récupérer un entier aléatoire
Random rnd = new Random();
int nbToFind = rnd.Next(1, 100);

int propositionNb = 0;
int cptTours = 0;
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
    Console.WriteLine($"Tours restants :{(maxPropal - cptTours)}");
}
while (nbToFind != propositionNb && cptTours < maxPropal);

if (nbToFind == propositionNb)
{
    Console.WriteLine("Gagné");
}
else
{
    Console.WriteLine($"Perdu, le nombre était {nbToFind}");
}
