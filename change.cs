Console.Write("Enter a price : ");
int price = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter what you paid : "); 
int paid = Convert.ToInt32(Console.ReadLine()); 
int change = paid - price;
while (change >= 1000)
{
    Console.Write("1000, "); change -= 1000;
}
while (change >= 500)
{
    Console.Write("500, "); change -= 500;
}
while (change >= 200)
{
    Console.Write("200, "); change -= 200;
}
while (change >= 100)
{
    Console.Write("100, "); change -= 100;
}
while (change >= 50)
{
    Console.Write("50, "); change -= 50;
}
while (change >= 25)
{
    Console.Write("25, "); change -= 25;
}
while (change >= 10)
{
    Console.Write("10, "); change -= 10;
}
while (change >= 5)
{
    Console.Write("5, "); change -= 5;
}
while (change >= 2) 
{
    Console.Write("2, "); change -= 2;
}
while (change >= 1) 
{
    Console.Write("1, "); change -= 1;
}
Console.Write("0");
Console.ReadKey();
