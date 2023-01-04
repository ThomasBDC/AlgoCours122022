

using PoupeeRusseNsP;

var poupee = new PoupeeRusse("Rouge",
                new PoupeeRusse("Bleu",
                    new PoupeeRusse("Verte", 
                        new PoupeeRusse("Jaune", null))));

Console.WriteLine(poupee.Couleur);