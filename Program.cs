﻿using RPGPOOCSharp.Models;

Knight arus = new Knight("Arus", 23, "Knight");
Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
Ninja james = new Ninja("James", 20, "Ninja");
Knight gladius = new Knight("Gladius", 25, "Knight");
Wizard sarah = new Wizard("Sarah", 21, "Green Wizard");
Ninja jessie = new Ninja("Jessie", 22, "Ninja");

Console.WriteLine(arus);
Console.WriteLine(arus.Attack());
Console.WriteLine(" ");
Console.WriteLine(jennica);
Console.WriteLine(jennica.Attack(6));
Console.WriteLine(" ");
Console.WriteLine(james);
Console.WriteLine(james.Attack(8));
Console.WriteLine(" ");
Console.WriteLine(gladius);
Console.WriteLine(gladius.Attack(7));
Console.WriteLine(" ");
Console.WriteLine(sarah);
Console.WriteLine(sarah.Attack(9));
Console.WriteLine(" ");
Console.WriteLine(jessie);
Console.WriteLine(jessie.Attack(5));