// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Bonjour, merci de me donner la taille du tableau que vous voulez trier");
string reponse = Console.ReadLine();
int ReponseInt = Convert.ToInt16(reponse);
int[] MyTab = CreateTableau(ReponseInt);

Console.WriteLine("Tableau avant le tri : ");
AfficherTableau(MyTab);

//Trier le tableau
var tableauTrie = TriABulle(MyTab);
//Afficher le tableau trié
Console.WriteLine("Tableau après le tri : ");
AfficherTableau(tableauTrie);



int[] TriABulle(int[] tabToTri)
{
    //Je copie mon tableau à trier dans ma variable tabToTri (le tableau que je vais trier
    int[] tableauTrie = new int[tabToTri.Length];
    tabToTri.CopyTo(tableauTrie, 0);

    //Parcourir mon tableau
    //Comparer l'élément en cours, avec l'élément précédent

    bool UneInversionAEteFaite = false;
    int cptPassage = 0;
    
    do
    {
        UneInversionAEteFaite = false;
        for (int i = 1; i < tableauTrie.Length - cptPassage; i++)
        {
            //Si tableauTrie[i] < tableauTrie[i-1]
            if (tableauTrie[i] < tableauTrie[i - 1])
            {
                //J'inverse les deux valeurs
                int value = tableauTrie[i];
                tableauTrie[i] = tableauTrie[i - 1];
                tableauTrie[i - 1] = value;
                UneInversionAEteFaite = true;
            }
        }
    } while (UneInversionAEteFaite);




    return tableauTrie;
}

void AfficherTableau(int[] leTableau)
{
    string tableau = "";
    foreach (var nombre in leTableau)
    {
        tableau += nombre.ToString() + " | ";
    }
    Console.WriteLine(tableau);
}

int[] CreateTableau(int size)
{
    int[] tableau = new int[size];
    var rnd = new Random();
    for(int i=0; i< tableau.Length; i++)
    {
        tableau[i] = rnd.Next(1, 1000);
    }
    return tableau;
}