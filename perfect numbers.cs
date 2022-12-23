// See https://aka.ms/new-console-template for more informatio

Console.WriteLine("pleas enter the first number");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("pleas enter the second number");
int number2 = int.Parse(Console.ReadLine());

int sum;

for(int j =number1;j< number2;j++)
{
    sum = 0;
    for(int i=1; i<=j/2;i++)
        if(j%i==0)
    {
            sum += i;
    }
    if( sum == j)
    {
        Console.WriteLine("{0} is perfect", j);
    }
}