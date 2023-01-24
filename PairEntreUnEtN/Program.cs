//Afficher les nombres pairs ENTRE 1 é N un nombre 

//Qu'est-ce que je dois demander à l'utilisateur ?

Console.WriteLine("Quel est le nombre max ?");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Voici les nombres pairs entre 1 et " + n);
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

/*
 n = 5
1  2   3   4   5  
for int i = 1 i<=n                
comment savoir si un nombre est pair ?
n%2 == 0 
 */



