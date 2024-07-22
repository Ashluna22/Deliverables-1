using System;

public class Program
{
    public static void Main()
    {
        double sodaleft = 0;
        int sodastock = 100;
        double sodabought = 0;
        int sodarestock = 40;

        Console.WriteLine("How many Sodas have been sold today? 100 are in stock ");

        sodabought = Convert.ToDouble(Console.ReadLine());

        if (sodabought <= sodastock)
        {
            sodaleft = sodastock - sodabought;
        }
        else
        {
            sodaleft = sodastock; // Do not adjust stock if the input is higher than stock
            Console.WriteLine("You cannot sell more sodas than are in stock.");
        }

        Console.WriteLine($"There are: {sodaleft} sodas left in stock.");

        if (sodaleft <= sodarestock)
        {
            Console.WriteLine("Please Restock Sodas");
        }

        double chipleft = 0;
        int chipstock = 40;
        double chipbought = 0;
        int chiprestock = 20;

        Console.WriteLine("How many Chips have been sold today? 40 are in stock ");

        chipbought = Convert.ToDouble(Console.ReadLine());

        if (chipbought <= chipstock)
        {
            chipleft = chipstock - chipbought;
        }
        else
        {
            chipleft = chipstock; // Do not adjust stock if the input is higher than stock
            Console.WriteLine("You cannot sell more chips than are in stock.");
        }

        Console.WriteLine($"There are: {chipleft} chips left in stock.");

        if (chipleft <= chiprestock)
        {
            Console.WriteLine("Please Restock Chips");
        }

        double candyleft = 0;
        int candystock = 60;
        double candybought = 0;
        int candyrestock = 40;

        Console.WriteLine("How many Candys have been sold today? 60 are in stock ");

        candybought = Convert.ToDouble(Console.ReadLine());

        if (candybought <= candystock)
        {
            candyleft = candystock - candybought;
        }
        else
        {
            candyleft = candystock; // Do not adjust stock if the input is higher than stock
            Console.WriteLine("You cannot sell more candies than are in stock.");
        }

        Console.WriteLine($"There are: {candyleft} candies left in stock.");

        if (candyleft <= candyrestock)
        {
            Console.WriteLine("Please Restock Candies");
        }
    }
}