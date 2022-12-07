string[,] allStudents = new string[,]
{
    {"Pascal", "Theo","Jacques" },//Classe 0
    {"Henri", "Mat","Boolo" },//Classe 1
    {"Mathil", "Ines","Iner" },//Classe 2
    {"Emilie", "Anais","Adelina" }//Classe 3
};

for(int i = 0; i < allStudents.GetLength(0); i++)
{
    for (int j = 0; j < allStudents.GetLength(1); j++)
    {
        Console.WriteLine(allStudents[i, j]);
    }
}