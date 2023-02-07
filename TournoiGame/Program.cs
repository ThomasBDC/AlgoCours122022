// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bonjour et bienvenue dans le jeux du tournoi !");

//Tournoi aura une taille max de 8
//string[] participantsBase = new string[] { "Berenger", "Denis", "Emmanuel", "Hanan", "Kevin", "Marc-Harvey", "Sebastien", "Thomas" };
string[] participantsBase= new string[] { "Adam", "Alex", "Aaron", "Ben", "Carl", "Dan", "David", "Edward", "Fred", "Frank", "George", "Hal", "Hank", "Ike", "John", "Jack", "Joe", "Larry", "Monte", "Matthew", "Mark", "Nathan", "Otto", "Paul", "Peter", "Roger", "Roger", "Steve", "Thomas", "Tim", "Ty", "Victor", "Walter", "Berenger", "Denis", "Emmanuel", "Hanan", "Kevin", "Marc-Harvey", "Sebastien", "Thomas" };


//Objectif : affoicher le premier tour
int cptTour = 0;
GenerateTour(participantsBase);

void GenerateTour(string[] participants)
{
    cptTour++;
    Console.WriteLine("Tour n°" + cptTour);
    //8participants, j'ai donc 4 matchs
    string[] particpantsTourSuivants = new string[participants.Length/2];
    for(int i=0; i<participants.Length/2;i++)
    {
        var match = GenerateMatch(participants);
        string vainqueur = DoMatch(match);
        WriteMatch(match, vainqueur, i+1);
        particpantsTourSuivants[i] = vainqueur;
    }

    if (particpantsTourSuivants.Length > 1)
    {
        GenerateTour(particpantsTourSuivants);
    }
    else
    {
        Console.WriteLine("Nous avons un grand gagnant !");
        Console.WriteLine(particpantsTourSuivants[0]);
    }
}


string DoMatch(string[] match)
{
    var rnd = new Random();
    var vainquer = rnd.Next(match.Length);
    return match[vainquer];
}

//Générer deux joueurs alétoires
//Retourner un tableau avec 2 index de joueurs
string[] GenerateMatch(string[] participants)
{
    string[] match = new string[2];

    match[0] = getRandomParticpant(participants);
    match[1] = getRandomParticpant(participants);

    return match;
}

string getRandomParticpant(string[] participant)
{
    var rnd = new Random();
    string participantTire = "";

    do
    {
        int particpantIndex = rnd.Next(participant.Length);
        participantTire = participant[particpantIndex];
        participant[particpantIndex] = "";
    } 
    while (participantTire == "");


    return participantTire;
}

void WriteMatch(string[] match, string vainqueur, int numMatch)
{
    Console.WriteLine("");
    Console.Write("    Match n°" + numMatch + " : ");
    if (match[0] == vainqueur)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    Console.Write(match[0]);
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write(" VS ");
    if (match[1] == vainqueur)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    Console.Write(match[1]);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("");
}