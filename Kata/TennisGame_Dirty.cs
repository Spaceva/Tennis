namespace Kata
{
    public class TennisGame_Dirty : ITennisGame
    {
        private int p1, p2;

        public string PrintScore()
        {
            bool p1W = false;
            bool p2W = false;
            bool deuce = false;
            bool p1A = false;
            bool p2A = false;

            // On regarde si un joueur gagne
            if (p1 == 4 && p2 == 0)
            {
                p1W = true;
            }
            if (p1 == 0 && p2 == 4)
                p2W = true;
            if (p1 > 3 && p1 > p2 + 1)
                p1W = true;
            if (p2 > 3 && p2 > p1 + 1)
                p2W = true;

            // Sinon peut être que c'est deuce ?
            if (p1 > 2 && p2 > 2 && p1 == p2)
                deuce = true;

            // Ou serré ?
            if (p1 > 2 && p2 > 2)
            {
                if (p1 == p2 + 1)
                    return "advantage Player1";
                if (p2 == p1 + 1)
                    return "advantage Player2";

                // Mais un des joueurs a peut être finalement gagné ?
                if (p1 == p2 + 2)
                    return "Player1 wins";
                if (p2 == p1 + 2)
                    return "Player2 wins";
            }

            // On affiche le score
            if (p1W)
                return "Player1 wins";
            else if (p2W)
                return "Player2 wins";
            else if (deuce)
                return "deuce";
            else if (p1A)
                return "advantage Player1";
            else if (p2A)
                return "advantage Player2";
            else
            {
                var s = string.Format("{0} - {1}", p1, p2);
                s = s.Replace("0", "love");
                s = s.Replace("1", "fifteen");
                s = s.Replace("2", "thirty");
                s = s.Replace("3", "forty");
                return s;
            }
        }

        public void Player1WinsTheBall()
        {
            p1++;
        }

        public void Player2WinsTheBall()
        {
            p2++;
        }
    }
}
