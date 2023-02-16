using geometric_shapes;
using System;


Sqr s1 = new Sqr(5);

Console.WriteLine($"Perimeter is {s1.Perimeter()} and Area is {s1.Area()}");

Rect r1 = new Rect(3, 5);

Console.WriteLine($"Perimeter is {r1.Perimeter()} and Area is {r1.Area()}");

Quad q1 = new Quad(3, 4, 5, 6);

Console.WriteLine($"Perimeter is {q1.Perimeter()}");








//var fullname = Person.Fullname("Jake", "Witte");
//Console.WriteLine(fullname);
//var revfullname = Person.RevFullname(lastname: "Jacob", firstname: "Witte");
//Console.WriteLine(revfullname);
//Person jake = new();

//Console.WriteLine($"15 plus 3 equals {MathLib.Add(15, 3)}");
//Console.WriteLine($"15 minus 3 equals {MathLib.Subtract(15, 3)}");
//Console.WriteLine($"15 times 3 equals {MathLib.Multiply(15, 3)}");
//Console.WriteLine($"15 divided by 0 equals {MathLib.Divide(15, 0)}");
