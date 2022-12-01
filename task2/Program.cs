int a = int.Parse(Console.ReadLine());
if (a % 7 == 0 & a % 23 == 0)
{
    Console.WriteLine(" -> кратно ");
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(" -> не кратно ");
    Console.WriteLine(a);
}
