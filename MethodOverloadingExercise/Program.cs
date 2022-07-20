// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static decimal Add(decimal num1, decimal num2)
    {
        return num1 + num2;
    }

    public static string Add(int num1, int num2, bool isMoney)
    {
        if(isMoney)
        {
            if (num1 + num2 == 1)
            {
                return $"{num1 + num2} dollar";
            }
            else
            {
                return $"{num1 + num2} dollars";
            }
        }
        else
        {
            return $"{num1 + num2}";
        }
        
    }

    private static void Main(string[] args)
    {

    }
}