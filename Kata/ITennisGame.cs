using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    interface ITennisGame
    {
        string PrintScore();
        void Player1WinsTheBall();
        void Player2WinsTheBall();
    }
}
