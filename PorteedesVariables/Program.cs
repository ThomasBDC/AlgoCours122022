// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string prenom = "John";

string nom = "";

if (prenom == "John")
{
    nom = "Lennon";
    Console.WriteLine(nom); 
}

string nomPrenom = prenom + nom;
DitBonjour();

//Ma fonction pour dire bonjour
void DitBonjour()
{
    Console.WriteLine("Bonjour ! "+nomPrenom);
}