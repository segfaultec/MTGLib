﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MTGLib
{
    public class Player
    {
        public bool hasLost = false;

        public Library library = new Library();
        public Hand hand = new Hand();
        public Graveyard graveyard = new Graveyard();

        public int life = 20;

        public Dictionary<string, int> counters = new Dictionary<string, int>();

        public Player()
        {

        }

        public void Draw(int count = 1)
        {
            while (count > 0)
            {
                MTG.Instance.MoveZone(library.Get(0), library, hand);
                count--;
            }
        }

        public void Mill(int count = 1)
        {
            while (count > 0)
            {
                MTG.Instance.MoveZone(library.Get(0), library, graveyard);
            }
        }
    }

}