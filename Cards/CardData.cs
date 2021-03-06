﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Cards
    {
        public static List<Card> CardDB = new List<Card>
        {
            // Testing Dummy
            new MinionCard(name: "Testing Dummy", manaCost: 1, attack: 0, health: 1, description:
                "This card is useless. It dies at the end of the turn!")
            {
                Effects = new Dictionary<Effect, Action<GameState, MinionCard>>()
                {
                    { Effect.TurnEnd, (state, self) => self.Health = 0 }
                }
            },

        };
    }
}
