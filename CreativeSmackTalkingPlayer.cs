using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        public List<string> TauntList { get; }

        public CreativeSmackTalkingPlayer()
        {
            TauntList = new List<string>
            {
                "Abydocomist!", "Bedswerver!", "Besprawler!", "Bobolyne!", "Cumberworld!", "Dalcop!", "Dew-Beater!", "Dorbel!", "Drate-Poke!", "Driggle-Draggle!", "Fopdoodle!", "Fustilugs!", "Fustilarian!", "Gillie-Wet-Foot!", "Gnashgab!" , "Gobermouch!" , "Gowpenful-O’-Anything!" , "Klazomaniac!","Leasing-Monger!", "Loiter-Sack!", "Lubberwort!", "Muck-Spout!", "Mumblecrust!", "Quisby!", "Raggabrash!", "Rakefire!", "Roiderbanks!", "Saddle-Goose!", "Scobberlotcher!", "Skelpie-Limmer!", "Smell-Feast!", "Smellfungus!", "Snoutband!", "Sorner!", "Stampcrab!", "Stymphalist!", "Tallowcatch!", "Triptaker!", "Wandought!", "Whiffle-Whaffle!", "Yaldson!","Zoilist!"
            };
        }

        public override int Roll()
        {
            Console.WriteLine(TauntList[new Random().Next(TauntList.Count) + 1]);
            return new Random().Next(DiceSize) + 1;
        }
    }
}