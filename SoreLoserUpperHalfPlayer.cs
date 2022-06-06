using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : SoreLoserPlayer
    {
        public override int Roll()
        {
            int thisRoll = new Random().Next(DiceSize) + 1;
            if (thisRoll < 4)
            {
                thisRoll += 3;
            }
            // Return a random number between 1 and DiceSize
            return thisRoll;
        }
    }
}