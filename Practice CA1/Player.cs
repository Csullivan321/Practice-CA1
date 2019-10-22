﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CA1
{
    public class Player
    {
        public  int PlayerId  { get;  }
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public Player(int id, string name, int score)
        {
            PlayerId = id;
            PlayerName = name;
            Score = score;

        }
    }
}
