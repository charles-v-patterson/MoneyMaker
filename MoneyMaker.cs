using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      int goldCoin = 10;
      int silverCoin = 5;
      
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("Enter an amount to convert to coins: ");
      string amount = Console.ReadLine();
      double convertedAmount = Convert.ToDouble(amount);

      Console.WriteLine($"{amount} cents is equal to...");

      double goldCoins = Math.Floor(convertedAmount / goldCoin);
      double remainingAmount = convertedAmount % goldCoin;

      double silverCoins = Math.Floor(remainingAmount / silverCoin);
      remainingAmount = remainingAmount % silverCoin;

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainingAmount}");


    }
  }
}
