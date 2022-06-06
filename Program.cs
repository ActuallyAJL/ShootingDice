using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            large.Play(player1);

            Console.WriteLine("-------------------");

            Player stp = new SmackTalkingPlayer();
            stp.Name = "Smack Talker";

            stp.Play(player1);

            Console.WriteLine("-------------------");

            Player ohp = new OneHigherPlayer();
            ohp.Name = "One Higher";

            ohp.Play(player1);

            Console.WriteLine("-------------------");

            Player hp = new HumanPlayer();
            hp.Name = "Human";

            hp.Play(player1);

            Console.WriteLine("-------------------");

            Player cstp = new CreativeSmackTalkingPlayer();
            cstp.Name = "Creative Smack Talker";

            cstp.Play(player1);

            Console.WriteLine("-------------------");

            Player slp = new SoreLoserPlayer();
            slp.Name = "Sore Loser";

            slp.Play(player1);

            Console.WriteLine("-------------------");

            Player uhp = new UpperHalfPlayer();
            uhp.Name = "Upper Half";

            uhp.Play(player1);

            Console.WriteLine("-------------------");

            Player sluhp = new SoreLoserUpperHalfPlayer();
            sluhp.Name = "Sore Loser Upper Half";

            sluhp.Play(player1);

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}