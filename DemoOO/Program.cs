
using DemoOO.Classe;


Guerrier G = new Guerrier();
Pretre P = new Pretre();
Mage M = new Mage();
 

G.Nom = "Bridil";
G.Stats();
G.ShowCharacterProfile();
//Console.WriteLine(G.Nom + " " + G.Force + " " + G.Endurance + " " + G.Sagesse + " " + G.Intelligence); 


P.Nom = "Rudolph";
P.Stats();
P.ShowCharacterProfile();
//Console.WriteLine(P.Nom + " " + P.Force + " " + P.Endurance + " " + P.Sagesse + " " + P.Intelligence);


M.Nom = "Jaina";
M.Stats();
M.ShowCharacterProfile();
//Console.WriteLine(M.Nom + " " + M.Force + " " + M.Endurance + " " + M.Sagesse + " " + M.Intelligence);
