using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
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