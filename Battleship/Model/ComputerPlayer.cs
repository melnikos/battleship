﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship.Model
{
    class ComputerPlayer: Player
    {
        public void TakeTurn(Player otherPlayer)
        {
            TakeTurnAutomated(otherPlayer);
        }
    }
}
