int a = int.Parse(Console.ReadLine());

if (a % 7 == 0 & a % 23 == 0)
{
    Console.Write(" -> кратно ");
    Console.Write(a);
}
else
{
    Console.Write(" -> не кратно ");
    Console.Write(a);
}