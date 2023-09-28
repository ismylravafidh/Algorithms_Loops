int n = 128 ;
int sum = 0;
while (n >=2)
{
    if (n % 2 == 0)
    {
        sum ++;
        n /= 2;
    }
    else
    {
        sum *= 0;
        break;
    }
}
if (sum == 0)
{
    Console.WriteLine("2-nin quvveti deyil");
}
else
{
    Console.WriteLine("2^" + sum);
}