// See https://aka.ms/new-console-template for more information
using Banque_V1;
using System.Globalization;

Console.WriteLine("Hello, World!");

//déclarer et construire deux clients
//par ex  N°1 Dupont toto habitant Créteil
// N°2 Abdala Momo habitant Cachan

Client cl1 = new Client(1, "Dupont", "toto", "Creteil");

Client cl2 = new Client(2, "Abdala", "Momo", "Cachan");

Console.WriteLine(cl1);

//afficher toutes les informations sur les deux clients


// déclarer et construire trois comptes
// l'un à toto, un compte courant numéroté 10
// les deux autres à momo, un compte codevi numéro 11 et un compte courant numero 12

Compte c1 = new Compte(10, cl1);
Compte c2 = new Compte(11, cl2);
Compte c3 = new Compte(12, cl2);

//afficher la description des trois comptes

Console.WriteLine(c1.Description);
Console.WriteLine(c2.Description);
Console.WriteLine(c3.Description);

// créditez le compte de toto de 10
c1.crediter(10);

// créditez le compte courant de momo de 20
c2.crediter(20);
// créditez le compte codevi de momo de 20
c3.crediter(20);

//accordez un découvert de 15 à toto et de 15 à momo sur leur compte courant
Console.WriteLine(c1.setDecouvertAutorise(15));
Console.WriteLine(c2.setDecouvertAutorise(15));

//affichez la description des trois comptes avec le découvert autorisé en plus

Console.WriteLine(c1.Description);
Console.WriteLine(c2.Description);
Console.WriteLine(c3.Description);

// débitez le compte courant de momo de 30
Console.WriteLine(c2.debiter(30));
Console.WriteLine(c2.Description);

//débitez le compte courant de momo de 10 (il devrait théoriquement s'afficher un message d'erreur)
Console.WriteLine(c2.debiter(30));
Console.WriteLine(c2.Description);
//Modifiez le découvert de momo sur son compte courant, pour qu'il soit de 5 (normalement là aussi, on devrait avoir un message d'erreur)
Console.WriteLine(c2.setDecouvertAutorise(5));
Console.WriteLine(c2.Description);
