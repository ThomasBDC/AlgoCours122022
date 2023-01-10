using PoupeeRusseNsP;


var allColors = new string[] { "rouge", "vert", "mauve", "kaki", "jaunatre" };

ShowAllPoupees(PopulatePoupees());

PoupeeRusse PopulatePoupees(int increment = 0, PoupeeRusse poupeeActuelle = null)
{
    //Création de l'élément parent
    if (increment == 0)
    {
        poupeeActuelle = new PoupeeRusse(allColors[increment]);
    }

    increment++;
    if(increment < allColors.Length)
    { 
        poupeeActuelle.Fille = new PoupeeRusse(allColors[increment]);
        PopulatePoupees(increment, poupeeActuelle.Fille);
    }

    return poupeeActuelle;
}

void ShowAllPoupees(PoupeeRusse poupeeParam)
{
    Console.WriteLine(poupeeParam.Couleur);
    if (poupeeParam.Fille != null)
    {
        ShowAllPoupees(poupeeParam.Fille);
    }
}