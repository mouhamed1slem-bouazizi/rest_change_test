Console.Write("Enter a price : ");
int price = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter what you paid : ");
int paid = Convert.ToInt32(Console.ReadLine());
int change = paid - price;
int c1000, c500, c200, c100, c50, c25, c10, c5; c1000 = c500 = c200 = c100 = c50 = c25 = c10 = c5 = 0;
while (change >= 1000)
{ c1000 += 1; change -= 1000; }
while (change >= 500)
{ c500 += 1; change -= 500; }
while (change >= 200)
{ c200 += 1; change -= 200; }
while (change >= 100)
{ c100 += 1; change -= 100; }
while (change >= 50)
{ c50 += 1; change -= 50; }
while (change >= 25)
{ c25 += 1; change -= 25; }
while (change >= 10)
{ c10 += 1; change -= 10; }
while (change >= 5)
{ c5 += 1; change -= 5; }
if (c1000 == 1) Console.WriteLine("One 1000");
else if (c1000 > 1) Console.WriteLine(c1000 + " 1000");
if (c500 == 1) Console.WriteLine("One 500");
else if (c500 > 1) Console.WriteLine(c500 + " : 500");
if (c200 == 1) Console.WriteLine("One 200");
else if (c200 > 1) Console.WriteLine(c200 + " : 200");
if (c100 == 1) Console.WriteLine("One 100");
else if (c100 > 1) Console.WriteLine(c100 + " : 100");
if (c50 == 1) Console.WriteLine("One 50");
else if (c50 > 1) Console.WriteLine(c50 + " : 50");
if (c25 == 1) Console.WriteLine("One 25");
else if (c25 > 1) Console.WriteLine(c25 + " : 25");
if (c10 == 1) Console.WriteLine("One 10");
else if (c10 > 1) Console.WriteLine(c10 + " : 10");
if (c5 == 1) Console.WriteLine("One 5");
else if (c5 > 1) Console.WriteLine(c5 + " : 5");
Console.ReadKey();
