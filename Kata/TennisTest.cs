using System;
using System.Collections.Generic;
using Xunit;

namespace Kata
{
    public class TennisTest
    {
        private ITennisGame tennis;

        [Fact]
        public void Should_Print_Score_Correctly()
        {
            var games = new List<object[]>();
            games.Add(new object[] { 0, 0, "love - love" });
            games.Add(new object[] { 1, 0, "fifteen - love" });
            games.Add(new object[] { 0, 1, "love - fifteen" });
            games.Add(new object[] { 1, 1, "fifteen - fifteen" });

            games.Add(new object[] { 2, 0, "thirty - love" });
            games.Add(new object[] { 2, 1, "thirty - fifteen" });
            games.Add(new object[] { 2, 2, "thirty - thirty" });
            games.Add(new object[] { 1, 2, "fifteen - thirty" });
            games.Add(new object[] { 0, 2, "love - thirty" });

            games.Add(new object[] { 3, 0, "forty - love" });
            games.Add(new object[] { 3, 1, "forty - fifteen" });
            games.Add(new object[] { 3, 2, "forty - thirty" });
            games.Add(new object[] { 3, 3, "deuce" });
            games.Add(new object[] { 2, 3, "thirty - forty" });
            games.Add(new object[] { 1, 3, "fifteen - forty" });
            games.Add(new object[] { 0, 3, "love - forty" });

            games.Add(new object[] { 4, 1, "Player1 wins" });
            games.Add(new object[] { 4, 2, "Player1 wins" });
            games.Add(new object[] { 4, 3, "advantage Player1" });
            games.Add(new object[] { 4, 4, "deuce" });
            games.Add(new object[] { 3, 4, "advantage Player2" });
            games.Add(new object[] { 2, 4, "Player2 wins" });
            games.Add(new object[] { 1, 4, "Player2 wins" });

            games.Add(new object[] { 5, 4, "advantage Player1" });
            games.Add(new object[] { 3, 4, "advantage Player2" });
            games.Add(new object[] { 4, 5, "advantage Player2" });
            games.Add(new object[] { 5, 5, "deuce" });
            games.Add(new object[] { 4, 6, "Player2 wins" });
            games.Add(new object[] { 6, 4, "Player1 wins" });


            foreach (var game in games)
            {
                Play((int)game[0], (int)game[1], (string)game[2]);
            }
        }

        private void Play(int ballsToPlayer1, int ballsToPlayer2, string expectedScore)
        {
            tennis = new TennisGame_Dirty();

            for (int i = 0; i < ballsToPlayer1; i++)
                tennis.Player1WinsTheBall();

            for (int i = 0; i < ballsToPlayer2; i++)
                tennis.Player2WinsTheBall();

            Assert.Equal(expectedScore, tennis.PrintScore());
        }
    }
}
