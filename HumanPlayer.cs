using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Enter a roll 1-6:");
            int myRoll = Int32.Parse(Console.ReadLine());
            return myRoll;
        }
    }
}