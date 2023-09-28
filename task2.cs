int n = 30;
int j=0;
for(int i = 2; i <=n / 2; i++)
{
    if (n % i == 0)
    {
        j++;
    }
    else
    {
        j =0;
    }
}
if (j != 0)
{
    Console.WriteLine("Murekkeb Ededdir");
}
else if (n == 1  || n==0)
{
    Console.WriteLine("Ne sade ne de murekkeb ededdir");
}
else
{
    Console.WriteLine("Sade Ededdir");
}