Random random = new Random();
int number = random.Next(100,1000);

Console.WriteLine(number);

int Firstnumber = number /100;
int Lastnumber = number % 10;
int result = Firstnumber*10 + Lastnumber;

Console.WriteLine(result);

